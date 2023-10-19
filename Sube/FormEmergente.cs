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
    public partial class FormEmergente : Form
    {
        string message;
        public FormEmergente(string message, string tittle)
        {
            InitializeComponent();
            this.message = message;
            this.Text = tittle;
        }

        private void FormEmergente_Load(object sender, EventArgs e)
        {
            lblSalir.Text = message;
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
