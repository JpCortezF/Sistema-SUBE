using Biblioteca_DataBase;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Sube
{
    public partial class InicioPasajero : Form
    {
        Pasajero passenger;
        TarjetaSube mySube;
        private Form currentChildForm = null;
        FormSubePasajero formSube = null;

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripStatusLabel dummyLabel;
        private Timer timer;

        public InicioPasajero(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
            InstanciarStatusTrip();
            string query = @"SELECT * FROM pasajeros INNER JOIN tarjetas ON tarjetas.id = pasajeros.idSube WHERE idSube = @IdSube AND id = @IdCardNumber";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@IdSube", passenger.IdSube },
                { "@IdCardNumber", passenger.IdSube },
            };
            DataBase<TarjetaSube> data = new DataBase<TarjetaSube>();
            List<TarjetaSube> listSube = new List<TarjetaSube>();
            listSube = data.Select(query, parameters, TarjetaSube.MapTarjetaSube);
            this.mySube = listSube.FirstOrDefault();
        }

        private void InicioPasajero_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("| SALIR |");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
            lblNombre.Text = $"¡Hola {passenger.Name + " " + passenger.LastName}!";
        }
        private GraphicsPath CrearRegionConEsquinasRedondeadas(int width, int height, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(width - (radio * 2), 0, radio * 2, radio * 2, 270, 90); // Esquina superior derecha
            path.AddArc(width - (radio * 2), height - (radio * 2), radio * 2, radio * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, height - (radio * 2), radio * 2, radio * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radio = 15; // Ajusta el radio según tus preferencias

            this.Region = new Region(CrearRegionConEsquinasRedondeadas(this.Width, this.Height, radio));
        }
        private void itemSalir_Click(object sender, EventArgs e)
        {
            FormEmergente emergente = new FormEmergente("¿Está seguro que desea salir?", "Salir");
            emergente.ShowDialog();
            if (emergente.DialogResult == DialogResult.OK)
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                Close();
            }
        }
        private void vIAJARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is TomarTransporte))
            {
                TomarTransporte transporte = new TomarTransporte(passenger, mySube);
                OpenChildForm(transporte);
            }
        }
        private void subeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormSubePasajero))
            {
                FormSubePasajero miSube = new FormSubePasajero(passenger, mySube, this);
                OpenChildForm(miSube);
            }
        }
        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormViajes))
            {
                FormViajes viajes = new FormViajes(this, passenger, mySube);
                OpenChildForm(viajes);
            }
        }

        private void tarifaSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormTarifaSocial))
            {
                FormTarifaSocial tarifaSocial = new FormTarifaSocial(passenger, formSube);
                OpenChildForm(tarifaSocial);
            }
        }
        /// <summary>
        /// Abre un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="childForm">El formulario hijo que se abrirá.</param>
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.MdiParent = this;
            childForm.Location = new Point(0, 0);
            childForm.FormClosed += (s, args) =>
            {
                currentChildForm = null;
            };
            lblNombre.Visible = false;
            pictureBox1.Visible = false;
            childForm.Show();
        }
        /// <summary>
        /// Maneja el evento de hacer clic en el elemento de menú "Buscador". Abre el formulario de búsqueda de usuarios como un formulario hijo en el formulario principal, asegurándose de que solo un formulario hijo esté abierto a la vez.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (en este caso, el elemento de menú "Buscador").</param>
        /// <param name="e">Argumentos del evento.</param>

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
                lblNombre.Visible = false;
            }
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormDarDeBaja))
            {
                FormDarDeBaja DeBaja = new FormDarDeBaja(passenger);
                OpenChildForm(DeBaja);
            }
        }

        private void mISTRÁMITESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is FormPasajeroTramites))
            {
                FormPasajeroTramites Tramites = new FormPasajeroTramites(passenger);
                OpenChildForm(Tramites);
            }
        }
        public void ItemsMdiParentVisibles()
        {
            lblNombre.Visible = true;
            pictureBox1.Visible = true;
        }
        private void InstanciarStatusTrip()
        {
            statusStrip = new StatusStrip();

            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabel.Spring = true;

            // No inicialices dummyLabel aquí

            statusStrip.Items.Add(toolStripStatusLabel);

            // Configura el StatusStrip para que esté en la parte inferior del formulario
            statusStrip.Dock = DockStyle.Bottom;

            statusStrip.BackColor = Color.DarkGray;
            //statusStrip.ForeColor = Color.Black;
            statusStrip.SizingGrip = false;

            Controls.Add(statusStrip);

            // Establece la alineación del ToolStripStatusLabel
            toolStripStatusLabel.Alignment = ToolStripItemAlignment.Right;

            // Inicia el temporizador después de configurar los componentes
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Inicializa dummyLabel después de iniciar el temporizador
            dummyLabel = new ToolStripStatusLabel(DateTime.Now.ToString("HH:mm"));
            dummyLabel.ForeColor = Color.White;
            statusStrip.Items.Add(dummyLabel);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualiza la hora actual en el ToolStripStatusLabel
            dummyLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void InicioPasajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
