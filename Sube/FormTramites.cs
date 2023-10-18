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
    public partial class FormTramites : Form
    {
        public FormTramites(List<Tramites> tramites)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = tramites;
            lblCount.Text = tramites.Count.ToString();
        }
    }
}
