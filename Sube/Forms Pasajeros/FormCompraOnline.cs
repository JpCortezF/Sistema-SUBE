using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Microsoft.Win32;
using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube.Forms_Pasajeros
{
    public partial class FormCompraOnline : Form
    {
        List<Pasajero> listPassengers;
        private FormPasajero parentForm;
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        DataBase<Pasajero> data = new DataBase<Pasajero>();
        DataBase<TarjetaSube> dataSube = new DataBase<TarjetaSube>();

        public FormCompraOnline(FormPasajero parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != string.Empty)
            {
                string query = "SELECT * FROM pasajeros WHERE dni = @dni AND idSube IS NULL";
                parameters["@dni"] = txtDni.Text;
                Pasajero passenger = new Pasajero();
                listPassengers = data.Select(query, parameters, passenger.Map);
                if (listPassengers.Count > 0)
                {
                    passenger = listPassengers.FirstOrDefault();
                    Random rnd = new Random();
                    int _rnd = rnd.Next(1000, 9999);
                    int _rnd2 = rnd.Next(1000, 9999);
                    int _rnd3 = rnd.Next(1000, 9999);
                    passenger.IdSube = $"6061{_rnd}{_rnd2}{_rnd3}";

                    parameters.Clear();
                    string querySube = "SELECT * FROM tarjetas WHERE id = @subeRandom";
                    parameters.Add("@subeRandom", passenger.IdSube);
                    TarjetaSube sube = new TarjetaSube();
                    if(dataSube.Select(querySube, parameters, sube.Map).Count == 0)
                    {
                        SubeONLINE subeOnline = new SubeONLINE(passenger);
                        subeOnline.MdiParent = parentForm;
                        subeOnline.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Felicitaciones, lograste crear una SUBE ya existente! jaja", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No puede tener más de una SUBE a su nombre", "Nueva SUBE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }
        private void FormCompraOnline_Load(object sender, EventArgs e)
        {
            cmbDni.Items.Add("DNI - Documento Nacional de Identidad");
            cmbDni.Items.Add("LE - Libreta Enrolamiento");
            cmbDni.Items.Add("LC - Libreta Cívica");
            cmbDni.Items.Add("DE - Documento Extranjero");
            txtDni.TextChanged += txt_TextChanged;
            cmbDni.SelectedIndex = 0;
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            txtDni.Text = Regex.Replace(txtDni.Text, @"[^0-9]", "");
        }

    }
}
