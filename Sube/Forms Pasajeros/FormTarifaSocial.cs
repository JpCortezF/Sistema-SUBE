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
    public partial class FormTarifaSocial : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;
        Pasajero passenger;
        public FormTarifaSocial(Pasajero passenger, Dictionary<string, Pasajero> dictionaryPassengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.dictionaryPassengers = dictionaryPassengers;
        }

        private void FormTarifaSocial_Load(object sender, EventArgs e)
        {
            lblDescuento.Text = "Conocé todo sobre el descuento en transporte.";
            lblDirigido.Text = "¿A quién está dirigido?";
            label1.Text = $"• {ETarifaSocial.Estudiantil}";
            label2.Text = $"• {ETarifaSocial.Jubilado} y/o pensionados";
            label3.Text = $"• {ETarifaSocial.ExComatienteDeMalvinas}";
            label4.Text = $"• {ETarifaSocial.Discapacitado}";
            lblCosto.Text = "¿Cuál es el costo del trámite?";
            rdbEstudiantil.Text = $"{ETarifaSocial.Estudiantil}";
            rdbJubilado.Text = $"{ETarifaSocial.Jubilado}";
            rdbCombatiente.Text = $"{ETarifaSocial.ExComatienteDeMalvinas}";
            rdbDiscapacitado.Text = $"{ETarifaSocial.Discapacitado}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSeleccionado = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (radioButtonSeleccionado != null)
            {
                List<Tramites> listaTramites = new List<Tramites>();
                string ruta = @"..\..\..\Data";
                string nombre = @".\MisTramites.xml";
                string path = ruta + nombre;
                listaTramites = Serializador.ReadXMLTramites(path);

                MessageBox.Show("¡Solicitud enviada!\n¡Listo! Su trámite se encuentra en revisión", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string radioButtonTarifa = radioButtonSeleccionado.Text;


                if (Enum.TryParse(radioButtonTarifa, out ETarifaSocial tarifaSocial))
                {
                    Random rnd = new Random();
                    int _rnd = rnd.Next(1, 99999);

                    Tramites miTramite = new Tramites(_rnd, passenger.ReturnrKey(dictionaryPassengers, passenger), $"Reclamo:{tarifaSocial}  " + txtClaim.Text, DateTime.Now, "En revision");
                    listaTramites.Add(miTramite);
                    Serializador.WriteXMLTramites(path, listaTramites);
                }
            }
            else
            {
                passenger.MySube.TarifaSocial = ETarifaSocial.Ninguna;
            }

        }
    }
}
