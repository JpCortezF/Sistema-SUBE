using Biblioteca_TarjetaSube;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubeEvent;

namespace Sube.Forms_Pasajeros
{
    public partial class SubeGold : Form
    {
        SistemaSube sistemaSube = new SistemaSube();
        SistemaViajes sistemaViaje = new SistemaViajes();
        TarjetaSube sube;
        public SubeGold(TarjetaSube sube)
        {
            InitializeComponent();
            this.sube = sube;
        }

        private void SubeGold_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "¿Deseas suscribirte a Sube GOLD?";
            label1.Text = "La próxima vez que inicies sesión verás reflejada la SUBE GOLD\nCon esta SUBE pagas 1 de 2 viajes que realices.\nCada 10 viajes se hara un descuento a tu saldo.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubeGold_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Desea cancelar la suscripción?", "Sube GOLD");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                if (sube != null)
                {
                    if (sube.TarifaSocial == ETarifaSocial.SubeGold)
                    {
                        SubeGoldEventHandler(sube, false);
                    }
                    else
                    {
                        MessageBox.Show("Usted no posee Sube GOLD", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Su sube está dada de baja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuscripccion_Click(object sender, EventArgs e)
        {
            if (sube != null)
            {
                if (sube.TarifaSocial == ETarifaSocial.SubeGold)
                {
                    MessageBox.Show("Usted ya posee Sube GOLD", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SubeGoldEventHandler(sube, true);
                }
            }
            else
            {
                MessageBox.Show("Su sube está dada de baja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SubeGoldEventHandler(TarjetaSube sube, bool isSubscribed)
        {
            if (isSubscribed)
            {
                sistemaSube.UpdateSubeGold(sube);
                MessageBox.Show($"¡Felicidades! Te has suscrito a Sube GOLD.", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sistemaSube.ResetSocialRate(sube);
                MessageBox.Show("Has cancelado la suscripción a Sube GOLD.", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sistemaViaje.DeleteTravels(sube);
            }
        }
    }
}
