using Biblioteca_TarjetaSube;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sube
{
    public partial class TomarTransporte : Form
    {
        public TomarTransporte()
        {
            InitializeComponent();
        }

        private void TomarTransporte_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Selecciona transporte";
            comboBox1.Items.Add(ETransporte.Colectivo);
            comboBox1.Items.Add(ETransporte.Subte);
            comboBox1.Items.Add(ETransporte.Tren);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transporte = comboBox1.SelectedItem.ToString();
            
        }
    }
}
