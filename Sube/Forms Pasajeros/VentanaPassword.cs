using Biblioteca_DataBase;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class VentanaPassword : Form
    {
        List<Pasajero> listPassengers;
        public VentanaPassword()
        {
            InitializeComponent();
        }

        private void VentanaPassword_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "En un futuro estaria bueno mandarle\nla clave a través del mail que haya ingresado";          
        }
        public string DevolverPass()
        {
            string clave="";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataBase<Pasajero> data = new DataBase<Pasajero>();

            string queryPass = "SELECT * FROM pasajeros WHERE email = @email";
            parameters["@email"] = txtCorreo.Text;
            Pasajero passenger = new Pasajero();
            listPassengers = data.Select(queryPass, parameters, passenger.Map);
            if(listPassengers.Count > 0)
            {
                clave = listPassengers[0].Password;
                DialogResult = DialogResult.OK;
            }
            else
            {
                clave = "El email no se encuentra registrado";
            }
            return clave;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txtCorreo.Text))
            {
                DialogResult = DialogResult.Continue;
            }
        }
        private bool ValidarEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
