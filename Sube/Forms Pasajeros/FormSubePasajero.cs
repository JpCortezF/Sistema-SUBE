using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using NPOI.POIFS.Crypt.Dsig;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormSubePasajero : Form
    {
        Pasajero passenger;
        TarjetaSube sube;
        private InicioPasajero parent;

        public FormSubePasajero(Pasajero passenger, TarjetaSube mySube, InicioPasajero parent)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.sube = mySube;
            this.parent = parent;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormSubePasajero_Load(object sender, EventArgs e)
        {
            if (sube != null)
            {
                if (sube.TarifaSocial == ETarifaSocial.SubeGold)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    CargarDatosEnPictureBox();
                    pictureBox2.Controls.Add(lblTarjeta);
                    pictureBox2.Controls.Add(lblName);
                }
                else
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    CargarDatosEnPictureBox();
                    pictureBox1.Controls.Add(lblTarjeta);
                    pictureBox1.Controls.Add(lblName);
                }
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                lblTarjeta.Text = "NULL";
                lblSaldo.Text = "   $0";
                lblActualTarifa.Text = $"Tarifa Social: {ETarifaSocial.Ninguna}";
                pictureBox1.Controls.Add(lblTarjeta);
                pictureBox1.Controls.Add(lblName);
            }
            lbl0to3Km.Text = $"De 0 a 3Km: ${PrecioViajes.ValorColectivo0To3Km}";
            lbl3to6Km.Text = $"De 3 a 6Km: ${PrecioViajes.ValorColectivo3To6Km}";
            lbl6to12km.Text = $"De 6 a 12Km: ${PrecioViajes.ValorColectivo6To12Km}";
            lbl12to27km.Text = $"De 12 a 27: ${PrecioViajes.ValorColectivo12To27Km}";
            lblSubte.Text = $"Todas las lineas: ${PrecioViajes.ValorSubte}";
            lblTren.Text = $"Todas las lineas: ${PrecioViajes.ValorTren}";
            lblSubsidio.Text = $"Sin subsidio: ${PrecioViajes.ValorSinSubsidio}";
        }
        private void CargarDatosEnPictureBox()
        {
            lblTransportes.Text = "Información sobre los transportes";
            lblName.Text = $"{passenger.Name + " " + passenger.LastName}";
            lblTarjeta.Text = $"{passenger.IdSube}";
            double balance = sube.Balance;
            lblSaldo.Text = $"${balance.ToString("F2")}";
            lblActualTarifa.Text = $"Tarifa Social: {sube.TarifaSocial}";          
            
            lblTarifa.Text = "Acceder a tarifa social --->";
            lblTarjeta.Location = new Point(30, 120);
            lblName.Location = new Point(30, 158);
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sube != null)
                {
                    Hide();

                    CargaSube cargarSube = new CargaSube(sube);
                    cargarSube.ShowDialog();
                    if (cargarSube.DialogResult == DialogResult.OK)
                    {
                        string amount = cargarSube.DevolverMonto();

                        FormCargaCompleta subeCargada = new FormCargaCompleta(sube, amount);
                        subeCargada.ShowDialog();
                        if (subeCargada.DialogResult == DialogResult.OK)
                        {
                            Show();
                            Close();
                        }
                    }
                    else
                    {
                        Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void lblTarifa_Click(object sender, EventArgs e)
        {
            Hide();
            FormTarifaSocial tarifaSocial = new FormTarifaSocial(passenger, this);
            tarifaSocial.MdiParent = parent;
            tarifaSocial.Show();
        }

        private void FormSubePasajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
