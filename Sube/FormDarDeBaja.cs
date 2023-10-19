using Biblioteca_TarjetaSube;
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
    public partial class FormDarDeBaja : Form
    {
        Pasajero passenger;
        Dictionary<string, Pasajero> dictionaryPassengers;

        public FormDarDeBaja(Pasajero passenger, Dictionary<string, Pasajero> passengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            dictionaryPassengers = passengers;
        }

        private void FormDarDeBaja_Load(object sender, EventArgs e)
        {
            lblMotivos.Text = "Está por iniciar el trámite para dar de baja su tarjeta SUBE";
            lblAdvertencia.Text = "Tene en cuenta que si das de baja tu SUBE\nTe va a extrañar :(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            FormBajaUsuario bajaUsuario = new FormBajaUsuario(passenger);
            bajaUsuario.ShowDialog();
            if(bajaUsuario.DialogResult == DialogResult.OK)
            {
                RadioButton radioButtonSeleccionado = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (radioButtonSeleccionado != null)
                {
                    string ruta = @"..\..\..\Data";
                    string nombre = "MisTramites.xml";
                    string path = Path.Combine(ruta, nombre);
                    List<Tramites> listaTramites = new List<Tramites>();

                    string radioButtonTramite = radioButtonSeleccionado.Text;

                    Random rnd = new Random();
                    int _rnd = rnd.Next(1, 99999);

   
                    Tramites miTramite = new Tramites(_rnd, passenger.ReturnrKey(dictionaryPassengers, passenger), $"Reclamo:{radioButtonTramite}  " + txtClaim.Text, DateTime.Now, false);
                    listaTramites.Add(miTramite);

                    Serializador.WriteXMLTramites(path, listaTramites);
                    MessageBox.Show("¡Solicitud enviada!\n¡Listo! Su trámite se encuentra en revisión", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
