using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Biblioteca_DataBase;
using Logica;
using MyExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.Formula.Functions;
using System.Collections;
using NPOI.POIFS.Crypt.Dsig;
using Sube.Forms_Pasajeros;

namespace Sube
{
    public partial class TomarTransporte : Form
    {
        List<LineasTransporte> lineas = new List<LineasTransporte>();
        LineasTransporte miLinea = new LineasTransporte();
        SistemaSube sistemaSube = new SistemaSube();
        SistemaViajes sistemaViaje = new SistemaViajes();
        Pasajero passenger;
        TarjetaSube sube;
        Viajes miViaje;
        ETransporte miTransporte;
        public TomarTransporte(Pasajero passenger, TarjetaSube sube)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.sube = sube;
        }

        private void TomarTransporte_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "¡Viaja con tu SUBE!";
            lblKilometres.Text = "Ingrese cantidad de kilometros";
            comboBox1.Items.Add(ETransporte.Colectivo);
            comboBox1.Items.Add(ETransporte.Subte);
            comboBox1.Items.Add(ETransporte.Tren);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            miTransporte = (ETransporte)comboBox1.SelectedItem;
            comboBox2.Items.Clear();
            lineas = sistemaSube.CargarLineasTransporte(miTransporte);
            comboBox2.Items.AddRange(lineas.Select(linea => linea.Line).ToArray());

            txtKilometros.Enabled = false;
            txtKilometros.Clear();            
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {
            if (ValidarIngresoTextBox())
            {
                if (!string.IsNullOrEmpty(passenger.IdSube))
                {
                    try
                    {
                        if (float.TryParse(txtKilometros.Text, out float kilometros))
                        {
                            if(kilometros < 27)
                            {
                                foreach (LineasTransporte linea in lineas)
                                {
                                    if (miLinea.Line == linea.Line)
                                    {
                                        miLinea.Id = linea.Id;
                                        break;
                                    }
                                }
                                miViaje = new Viajes(kilometros, miTransporte);
                                TarifaSocialPasajero boletoViaje = new TarifaSocialPasajero(sube.TarifaSocial, miViaje);
                                miViaje.TicketCost = boletoViaje.ReturnTicketCost(miViaje);
                                sube.Balance -= miViaje.TicketCost;
                                
                                double balance = sube.Balance;
                                if (sube.Balance > -211.84)
                                {                                 
                                    switch (miTransporte)
                                    {
                                        case ETransporte.Colectivo:
                                            pictureBox1.Visible = true;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = false;
                                            break;
                                        case ETransporte.Subte:
                                            pictureBox2.Visible = true;
                                            pictureBox1.Visible = false;
                                            pictureBox3.Visible = false;
                                            break;
                                        case ETransporte.Tren:
                                            pictureBox3.Visible = true;
                                            pictureBox2.Visible = false;
                                            pictureBox1.Visible = false;
                                            break;
                                    }
                                    int totalTravels = sistemaViaje.CountTravels(sube);
                                    if (totalTravels % 2 == 0)
                                    {
                                        sistemaViaje.DiscountGoldEvent += sistemaViaje.HandleDiscountGoldEvent;
                                    }
                                    else
                                    {
                                        sistemaViaje.DiscountGoldEvent -= sistemaViaje.HandleDiscountGoldEvent;
                                    }
                                    miViaje = sistemaViaje.CountTravelsWithSubeGold(sube, miViaje, totalTravels);
                                    MessageBox.Show($"PAGO REALIZADO: ${miViaje.TicketCost}\nSALDO: ${sube.Balance.ToString("F2")}\nSIN SUBSIDIO: ${PrecioViajes.ValorSinSubsidio}", "En viaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    EnViaje formViaje = new EnViaje(sube, miLinea, miViaje);
                                    formViaje.ShowDialog();
                                    if(formViaje.DialogResult == DialogResult.OK)
                                    {
                                        if(sube.TarifaSocial == ETarifaSocial.SubeGold)
                                        {
                                            if (totalTravels % 10 == 0)
                                            {
                                                MessageBox.Show("Llegate a los 10 viajes con tu SUBE GOLD.\nEl saldo se vera reflajado en tu cuenta!", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    sube.Balance += miViaje.TicketCost;
                                    MessageBox.Show("Saldo insuficiente", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                throw new KilometrosException("La cantidad de kilómetros excede el límite permitido (27 km).");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Su SUBE se encuentra dada de baja...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se registro ningun viaje", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarIngresoTextBox()
        {
            bool allCompleted = true;
            foreach (Control control in grpTransporte.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        allCompleted = false;
                        break;
                    }
                }
            }
            return allCompleted;
        }
        private void txtKilometros_TextChanged(object sender, EventArgs e)
        {
            txtKilometros.Text = Regex.Replace(txtKilometros.Text, @"[^0-9]", "");
        }

        private void TomarTransporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                miLinea.Line = comboBox2.SelectedItem.ToString();
                txtKilometros.Enabled = true;
            }

        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            btnContinuar.Visible = false;
        }
    }
}
