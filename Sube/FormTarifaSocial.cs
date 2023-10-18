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
        Pasajero passenger;
        public FormTarifaSocial(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void FormTarifaSocial_Load(object sender, EventArgs e)
        {
            lblDescuento.Text = "Conocé todo sobre el descuento en transporte.";
            lblDirigido.Text = "¿A quién está dirigido?";
            label1.Text = $"• {ETarifaSocial.Estudiantil}";
            label2.Text = $"• {ETarifaSocial.Jubilado} y/o pensionados";
            label3.Text = $"• {ETarifaSocial.ExComatienteDeMalvinas}";
            label4.Text = $"• {ETarifaSocial.Discapacitado}";
            lblCosto.Text = "¿Cuál es el costo del trámito?";
            rdbEstudiantil.Text = $"{ETarifaSocial.Estudiantil}";
            rdbJubilado.Text = $"{ETarifaSocial.Jubilado}";
            rdbCombatiente.Text = $"{ETarifaSocial.ExComatienteDeMalvinas}";
            rdbDiscapacitado.Text = $"{ETarifaSocial.Discapacitado}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSeleccionado = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (radioButtonSeleccionado != null)
            {
                MessageBox.Show("¡Trámite reliazado!\nEn los próximos minutos vas a poder gozar de los descuentos", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string radioButtonTarifa = radioButtonSeleccionado.Text;
                if(Enum.TryParse(radioButtonTarifa, out ETarifaSocial tarifaSocial))
                {
                    passenger.MySube.TarifaSocial = tarifaSocial;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                passenger.MySube.TarifaSocial = ETarifaSocial.Ninguna;
            }

        }
    }
}
