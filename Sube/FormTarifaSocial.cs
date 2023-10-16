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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
