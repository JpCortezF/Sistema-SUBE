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
    public partial class FormPasajero : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;

        public FormPasajero()
        {
            InitializeComponent();
            this.dictionaryPassengers = new Dictionary<string, Pasajero>();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nombre = "MisPasajeros.Json";
            string path = Path.Combine(ruta, nombre);
            dictionaryPassengers = Serializador.ReadJsonPassenger(path);
        }
        private void FormPasajero_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("| SALIR |");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
        }
        private void itemSalir_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                Close();
            }
        }
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            FormIngreso formIngreso = new FormIngreso(dictionaryPassengers);
            formIngreso.ShowDialog();
            if(formIngreso.DialogResult == DialogResult.OK)
            {
                Close();
            }
        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(dictionaryPassengers);
            formRegistro.ShowDialog();
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {

        }

        private void cOMPRAONLINEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngreso formIngreso = new FormIngreso(dictionaryPassengers);
            formIngreso.ShowDialog();
        }

        private void rEGISTRALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(dictionaryPassengers);
            formRegistro.ShowDialog();
        }
    }
}
