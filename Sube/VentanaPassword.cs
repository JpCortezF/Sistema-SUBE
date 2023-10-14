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
        Dictionary<string, Pasajero> dictionaryPassengers;
        Pasajero passenger;
        public VentanaPassword(Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            passenger = new Pasajero();
            dictionaryPassengers = passengers;
        }

        private void VentanaPassword_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "En un futuro estaria bueno mandarle\nla clave a través del mail que haya ingresado";          
        }
        public string DevolverPass()
        {
            string clave;
            passenger = passenger.FindPassengerByEmail(dictionaryPassengers, txtCorreo.Text);
            if(passenger is not null)
            {
                clave = passenger.Password;
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
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
