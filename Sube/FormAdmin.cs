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
    public partial class FormAdmin : Form
    {
        Dictionary<string, Administrador> dictionaryAdmins;
        public FormAdmin()
        {
            InitializeComponent();
            this.dictionaryAdmins = new Dictionary<string, Administrador>();
        }
        private void hOMEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPrincipal fp = new FormPrincipal();
            fp.Show();
            Close();
        }

        private void lblRegistroAdmin_Click(object sender, EventArgs e)
        {
            FormRegistroAdmin frm = new FormRegistroAdmin(dictionaryAdmins);
            frm.Show();
            Close();
        }


    }
}
