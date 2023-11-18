using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Biblioteca_DataBase;
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

namespace Sube
{
    public partial class TomarTransporte : Form
    {
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
            string transporte = comboBox1.SelectedItem.ToString();
            if (Enum.TryParse(transporte, out ETransporte tipoTransporte))
            {
                miTransporte = tipoTransporte;
            }
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
                            int.TryParse(txtLinea.Text, out int lineaTransporte);
                            miViaje = new Viajes(kilometros, DateTime.Now, miTransporte, lineaTransporte);

                            TarifaSocialPasajero boletoViaje = new TarifaSocialPasajero(sube.TarifaSocial, miViaje);
                            miViaje.TicketCost = boletoViaje.ReturnTicketCost(miTransporte);

                            sube.Balance -= boletoViaje.ReturnTicketCost(miTransporte);
                            double balance = sube.Balance;
                            if (sube.Balance > -211.84)
                            {
                                switch (miTransporte)
                                {
                                    case ETransporte.Colectivo:
                                        pictureBox1.Visible = true;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        string queryUpdate = @"UPDATE tarjetas SET balance = @balanceUpdate WHERE id = @idSube";

                                        Dictionary<string, object> parameters = new Dictionary<string, object>
                                        {
                                            { "@balanceUpdate", sube.Balance },
                                            { "@idSube", sube.CardNumber },
                                            { "@IdCard", sube.CardNumber },
                                            { "@IdTransport", miViaje.TipoTransporte },
                                            { "@IdLine", 1025 },
                                            { "@IdSocialRate", sube.TarifaSocial },
                                            { "@TicketCost", miViaje.TicketCost },
                                            { "@Kilometres", miViaje.Kilometres },
                                            { "@Date", DateTime.Now },
                                        };
                                        DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();
                                        data.Update(queryUpdate, parameters);
                                        string queryInsert = @"INSERT INTO viajes(idCard, idTransport, idLine, idSocialRate, ticketCost, kilometres, date) VALUES(@IdCard, @IdTransport, @IdLine, @IdSocialRate, @TicketCost, @Kilometres, @Date)";
                                        data.Insert(queryInsert, parameters);
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
                                MessageBox.Show($"¡Viaje realizado con éxito!\nPAGO REALIZADO: ${boletoViaje.ReturnTicketCost(miTransporte)}\nSALDO: ${balance.ToString("F2")}\nSIN SUBSIDIO: ${PrecioViajes.ValorSinSubsidio}", "En viaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //DataBase.Insert(passenger, sube, 2);

                            }
                            else
                            {
                                sube.Balance += boletoViaje.ReturnTicketCost(miTransporte);
                                MessageBox.Show("Saldo insuficiente", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            btnContinuar.Visible = false;
        }

        private void TomarTransporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
