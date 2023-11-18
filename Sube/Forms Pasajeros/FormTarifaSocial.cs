using Biblioteca_DataBase;
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
    public partial class FormTarifaSocial : Form
    {
        Pasajero passenger;
        public FormTarifaSocial(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void FormTarifaSocial_Load(object sender, EventArgs e)
        {

            lblDescuento.Text = "Conocé todo sobre el descuento en transporte.";
            lblDirigido.Text = "¿A quién está dirigido?";
            label1.Text = $"• {ETarifaSocial.Estudiantil}";
            label2.Text = $"• {ETarifaSocial.Jubilado} y/o pensionados";
            label3.Text = $"• {ETarifaSocial.ExComatienteDeMalvinas}";
            label4.Text = $"• {ETarifaSocial.Discapacitado}";
            lblCosto.Text = "¿Cuál es el costo del trámite?";
            rdbEstudiantil.Text = $"{ETarifaSocial.Estudiantil}";
            rdbJubilado.Text = $"{ETarifaSocial.Jubilado}";
            rdbCombatiente.Text = $"{ETarifaSocial.ExComatienteDeMalvinas}";
            rdbDiscapacitado.Text = $"{ETarifaSocial.Discapacitado}";
            rdbSinSubsidio.Text = $"{ETarifaSocial.SinSubsidio}";

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
                List<Tramites> listaTramites = new List<Tramites>();
                //SerializadorXML<List<Tramites>> serializeTramites = new SerializadorXML<List<Tramites>>();
                string ruta = @"..\..\..\Data";
                string nombre = @".\MisTramites.xml";
                string path = ruta + nombre;
                //listaTramites = serializeTramites.Deserialize(path);
                listaTramites = Serializador.ReadXMLTramites(path);

                MessageBox.Show("¡Solicitud enviada!\n¡Listo! Su trámite se encuentra en revisión", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string radioButtonTarifa = radioButtonSeleccionado.Text;


                if (Enum.TryParse(radioButtonTarifa, out ETarifaSocial tarifaSocial))
                {
                    string query = @"INSERT INTO tramites (dniClaimer, claimMessage, claimTime, idClaimStatus) VALUES (@Dni, @ClaimMessage, @ClaimTime, @IdClaimStatus)";
                    DataBase<object> data = new DataBase<object>();
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@Dni", passenger.Dni },
                        { "@ClaimMessage", $"Reclamo:{tarifaSocial}  " + txtClaim.Text },
                        { "@ClaimTime", DateTime.Now },
                        { "@IdClaimStatus", EClaimStatus.EnProceso },
                    };
                    data.Insert(query, parameters);

                    //serializeTramites.Serialize(path, listaTramites);
                    Serializador.WriteXMLTramites(path, listaTramites);

                }
            }
            else
            {
               //passenger.MySube.TarifaSocial = ETarifaSocial.Ninguna;
            }

        }

        private void FormTarifaSocial_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioPasajero inicio = (InicioPasajero)this.MdiParent;
            inicio.ItemsMdiParentVisibles();
        }
    }
}
