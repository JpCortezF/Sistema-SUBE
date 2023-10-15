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

namespace Sube
{
    public partial class FormViajes : Form
    {
        Queue<Viajes> queueTravels;
        public FormViajes()
        {
            InitializeComponent();
            queueTravels = new Queue<Viajes>();
        }
        private void FormViajes_Load(object sender, EventArgs e)
        {
            dataGridViajes.Parent = panel1;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
