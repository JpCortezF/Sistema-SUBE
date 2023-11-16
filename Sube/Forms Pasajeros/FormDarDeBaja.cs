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
        List<Pasajero> listPassengers;

        public FormDarDeBaja(Pasajero passenger, List<Pasajero> listPassengers)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.listPassengers = listPassengers;
        }

        private void FormDarDeBaja_Load(object sender, EventArgs e)
        {
            lblMotivos.Text = "Está por iniciar el trámite para dar de baja su tarjeta SUBE";
            lblAdvertencia.Text = "Tene en cuenta que si das de baja tu SUBE\nTe va a extrañar :(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
            Close();
        }

        private void btnTramite_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSeleccionado = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (radioButtonSeleccionado != null)
            {
                FormBajaUsuario bajaUsuario = new FormBajaUsuario(passenger);
                bajaUsuario.ShowDialog();
                if (bajaUsuario.DialogResult == DialogResult.OK)
                {
                    string ruta = @"..\..\..\Data";
                    string nombre = "MisTramites.xml";
                    string path = Path.Combine(ruta, nombre);
                    //SerializadorXML<List<Tramites>> serializeTramites = new SerializadorXML<List<Tramites>>();
                    List<Tramites> listaTramites = new List<Tramites>();
                    //listaTramites = serializeTramites.Deserialize(path);
                    listaTramites = Serializador.ReadXMLTramites(path);

                    string radioButtonTramite = radioButtonSeleccionado.Text;

                    Random rnd = new Random();
                    int _rnd = rnd.Next(1, 99999);


                    Tramites miTramite = new Tramites(_rnd, passenger.Dni, $"Reclamo:{radioButtonTramite}  " + txtClaim.Text, DateTime.Now, EClaimStatus.EnRevision);
                    listaTramites.Add(miTramite);

                    //serializeTramites.Serialize(path, listaTramites);
                    Serializador.WriteXMLTramites(path, listaTramites);
                    MessageBox.Show("¡Solicitud enviada!\n¡Listo! Su trámite se encuentra en revisión", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormDarDeBaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
