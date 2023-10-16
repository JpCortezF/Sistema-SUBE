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
    public partial class FormBuscarUser : Form
    {
        Dictionary<string, Pasajero> dictionaryPassengers;

        public FormBuscarUser(Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.dictionaryPassengers = passengers;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DNI", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof (string));
            foreach (var entry in dictionaryPassengers)
            {
                dt.Rows.Add(entry.Key, entry.Value.Name, entry.Value.LastName);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
