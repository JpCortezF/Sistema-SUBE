﻿using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormDarDeBaja : Form
    {
        Pasajero passenger;

        public FormDarDeBaja(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void FormDarDeBaja_Load(object sender, EventArgs e)
        {
            lblMotivos.Text = "Está por iniciar el trámite para dar de baja su tarjeta SUBE";
            lblAdvertencia.Text = "Tene en cuenta que si das de baja tu SUBE\nTe va a extrañar :(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
            Close();
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSeleccionado = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (radioButtonSeleccionado != null)
            {
                FormBajaUsuario bajaUsuario = new FormBajaUsuario(passenger);
                bajaUsuario.ShowDialog();
                if (bajaUsuario.DialogResult == DialogResult.OK)
                {
                    string radioButtonTramite = radioButtonSeleccionado.Text;
                    MessageBox.Show("¡Solicitud enviada!\n¡Listo! Su trámite se encuentra en revisión", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query = @"INSERT INTO tramites (dniClaimer, claimMessage, claimTime, idClaimStatus) VALUES (@Dni, @ClaimMessage, @ClaimTime, @IdClaimStatus)";
                    DataBase<object> data = new DataBase<object>();
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@Dni", passenger.Dni },
                        { "@ClaimMessage", $"Reclamo: {radioButtonTramite}  " + txtClaim.Text },
                        { "@ClaimTime", DateTime.Now },
                        { "@IdClaimStatus", EClaimStatus.EnProceso },
                    };
                    data.Update(query, parameters);
                }
            }
            else
            {
                MessageBox.Show("No se registro ninguna opcion marcada", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDarDeBaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
