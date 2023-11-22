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
        List<LineasTransporte> lineas = new List<LineasTransporte>();
        Pasajero passenger;
        TarjetaSube sube;
        Viajes miViaje;
        ETransporte miTransporte;
        string selectedLine;
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
            DataBase<LineasTransporte> data = new DataBase<LineasTransporte>();
            string query = "";
            comboBox2.Items.Clear();
            if (Enum.TryParse(transporte, out ETransporte tipoTransporte))
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                List<string> lineasOrdenadas = lineas.Select(linea => linea.Line).ToList();
                miTransporte = tipoTransporte;
                switch (miTransporte)
                {
                    case ETransporte.Colectivo:
                        lineas.Clear();
                        query = @"SELECT * FROM lineas WHERE idTransport = @idTransport";
                        parameters.Add("@idTransport", ETransporte.Colectivo);
                        lineas = data.Select(query, parameters, LineasTransporte.MapLineas);
                        foreach (LineasTransporte linea in lineas)
                        {
                            comboBox2.Items.Add(linea.Line);
                        }

                        lineasOrdenadas = lineas.Select(linea => linea.Line).ToList();
                        lineasOrdenadas.Sort((a, b) =>
                        {
                            int CompareNumerically(string x, string y)
                            {
                                if (int.TryParse(x, out int numX) && int.TryParse(y, out int numY))
                                {
                                    return numX.CompareTo(numY);
                                }
                                else
                                {
                                    Console.WriteLine($"Error al convertir {x} o {y} a número.");
                                    return 0;
                                }
                            }

                            return CompareNumerically(a, b);
                        });

                        // Asigna las líneas ordenadas al ComboBox
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(lineasOrdenadas.ToArray());

                        break;
                    case ETransporte.Subte:
                        lineas.Clear();
                        query = @"SELECT * FROM lineas WHERE idTransport = @idTransport";
                        parameters.Add("@idTransport", ETransporte.Subte);
                        lineas = data.Select(query, parameters, LineasTransporte.MapLineas);
                        foreach (LineasTransporte linea in lineas)
                        {
                            comboBox2.Items.Add(linea.Line);
                        }

                        lineasOrdenadas = lineas.Select(linea => linea.Line).ToList();
                        lineasOrdenadas.Sort((a, b) =>
                        {
                            return string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
                        });

                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(lineasOrdenadas.ToArray());

                        break;
                    case ETransporte.Tren:
                        lineas.Clear();
                        query = @"SELECT * FROM lineas WHERE idTransport = @idTransport";
                        parameters.Add("@idTransport", ETransporte.Tren);
                        lineas = data.Select(query, parameters, LineasTransporte.MapLineas);
                        foreach (LineasTransporte linea in lineas)
                        {
                            comboBox2.Items.Add(linea.Line);
                        }

                        lineasOrdenadas = lineas.Select(linea => linea.Line).ToList();
                        lineasOrdenadas.Sort((a, b) =>
                        {
                            return string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
                        });

                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(lineasOrdenadas.ToArray());

                        break;

                }
                txtKilometros.Enabled = false;
                txtKilometros.Clear();
            }
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {
            int idLine = 0;
            if (ValidarIngresoTextBox())
            {
                if (!string.IsNullOrEmpty(passenger.IdSube))
                {
                    try
                    {
                        if (float.TryParse(txtKilometros.Text, out float kilometros))
                        {
                            foreach (LineasTransporte linea in lineas)
                            {
                                if (selectedLine == linea.Line)
                                {
                                    idLine = linea.Id;
                                    break;
                                }
                            }
                            miViaje = new Viajes(kilometros, DateTime.Now, miTransporte, idLine);

                            TarifaSocialPasajero boletoViaje = new TarifaSocialPasajero(sube.TarifaSocial, miViaje);
                            miViaje.TicketCost = boletoViaje.ReturnTicketCost(miTransporte);

                            sube.Balance -= boletoViaje.ReturnTicketCost(miTransporte);
                            double balance = sube.Balance;
                            if (sube.Balance > -211.84)
                            {
                                Dictionary<string, object> parameters = new Dictionary<string, object>
                                {
                                    { "@balanceUpdate", sube.Balance },
                                    { "@idSube", sube.CardNumber },
                                    { "@IdCard", sube.CardNumber },
                                    { "@IdTransport", miViaje.TipoTransporte },
                                    { "@IdLine", idLine },
                                    { "@IdSocialRate", sube.TarifaSocial },
                                    { "@TicketCost", miViaje.TicketCost },
                                    { "@Kilometres", miViaje.Kilometres },
                                    { "@Date", DateTime.Now },
                                };
                                string queryUpdate = @"UPDATE tarjetas SET balance = @balanceUpdate WHERE id = @idSube";
                                DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();
                                data.Update(queryUpdate, parameters);
                                string queryInsert = @"INSERT INTO viajes(idCard, idTransport, idLine, idSocialRate, ticketCost, kilometres, date) VALUES(@IdCard, @IdTransport, @IdLine, @IdSocialRate, @TicketCost, @Kilometres, @Date)";
                                data.Insert(queryInsert, parameters);
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
                selectedLine = comboBox2.SelectedItem.ToString();
                txtKilometros.Enabled = true;
            }

        }
        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            btnContinuar.Visible = false;
        }
    }
}
