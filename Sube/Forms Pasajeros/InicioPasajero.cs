using Biblioteca_DataBase;
using Biblioteca_Serializadora;
using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using Logica;
using NPOI.SS.Formula.Functions;
using Sube.CustomControls;
using Sube.Forms_Pasajeros;
using SubeEvent;
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
        SistemaSube sistema = new SistemaSube();
        private Form currentChildForm = null;
        FormSubePasajero formSube = null;
        ToolStripMenuItem itemSalir = new ToolStripMenuItem("| SALIR |");
        List<Configuracion> listConfig = new List<Configuracion>();
        SerializadorJSON<List<Configuracion>> JSON = new SerializadorJSON<List<Configuracion>>();
        public delegate List<Configuracion> FactoryMethod();
        ToggleButton toggleButton;
        bool darkMode = true;

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripStatusLabel dummyLabel;
        private Timer timer;

        public InicioPasajero(Pasajero passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
            toggleButton = new ToggleButton();
            mySube = sistema.ReturnSubePassenger(passenger);
            InstanciarStatusTrip();
            string ruta = @"..\..\..\Data";
            string nombre = "Config.Json";
            string path = Path.Combine(ruta, nombre);
            List<Configuracion> CrearListaPredeterminada()
            {
                return new List<Configuracion>();
            }
            listConfig = JSON.Deserialize(path, CrearListaPredeterminada);

            if (listConfig != null)
            {
                foreach (Configuracion config in listConfig)
                {
                    if (config.ConfiguracionProg == "darkMode")
                    {
                        bool.TryParse(config.Dato, out darkMode);
                    }
                }
            }

        }

        private void InicioPasajero_Load(object sender, EventArgs e)
        {
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
            toggleButton.CheckedChanged += ToggleButton_Click;
            lblNombre.Text = $"¡Hola {passenger.Name}!";
            if (darkMode == true)
            {
                Image gifImage = Properties.Resources.DarkMode;
                pictureBox1.Image = gifImage;
                lblNombre.Location = new Point(322, 480);
                pictureBox1.Controls.Add(lblNombre);
                darkMode = true;
            }
            else
            {
                Image gifImage = Properties.Resources.LigthMode;
                pictureBox1.Image = gifImage;
                lblNombre.Location = new Point(322, 480);
                pictureBox1.Controls.Add(lblNombre);
                darkMode = false;
            }
            toggleButton.Checked = darkMode;
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
                foreach (Configuracion config in listConfig)
                {
                    if (config.ConfiguracionProg == "darkMode")
                    {
                        config.Dato = darkMode.ToString();
                        break;
                        /*
                        Configuracion opcion = new Configuracion("darkMode", darkMode);
                        listConfig.Add(opcion);
                        */
                    }
                }

                string ruta = @"..\..\..\Data";
                string nombre = "Config.Json";
                string path = Path.Combine(ruta, nombre);
                JSON.Serialize(path, listConfig);
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
            pictureBox1.Visible = false;
            toggleButton.Enabled = false;
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
            toggleButton.Enabled = true;
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

            statusStrip.BackColor = Color.DimGray;
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

            // Configura las propiedades según sea necesario
            toggleButton.OnBackColor = Color.MediumSlateBlue;
            toggleButton.OnToggleColor = Color.WhiteSmoke;
            toggleButton.OffBackColor = Color.Gray;
            toggleButton.OffToggleColor = Color.Gainsboro;
            toggleButton.SolidStyle = true;

            // Agrega el ToggleButton al StatusStrip
            statusStrip.Items.Add(new ToolStripControlHost(toggleButton));
            toggleButton.MouseHover += ToggleButton_MouseHover;
            toggleButton.Click += ToggleButton_Click;
        }
        private void ToggleButton_MouseHover(object sender, EventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            toggleButton.Cursor = Cursors.Hand;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            dummyLabel.Text = DateTime.Now.ToString("HH:mm");
        }
        private void ToggleButton_Click(object sender, EventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            if (toggleButton.Checked)
            {
                Image gifImage = Properties.Resources.DarkMode;
                pictureBox1.Image = gifImage;
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.Controls.Add(lblNombre);
                BackgroundImage = Properties.Resources.DarkMode;
                menuStrip1.BackColor = Color.MediumSlateBlue;
                itemSalir.BackColor = Color.MediumSlateBlue;
                darkMode = true;
            }
            else
            {
                Image gifImage = Properties.Resources.LigthMode;
                pictureBox1.Image = gifImage;
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.Controls.Add(lblNombre);
                BackgroundImage = Properties.Resources.LigthMode;
                menuStrip1.BackColor = SystemColors.ActiveCaption;
                itemSalir.BackColor = SystemColors.ActiveCaption;
                darkMode = false;
            }
        }
        private void InicioPasajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }

        private void subeGOLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm is null || !(currentChildForm is SubeGold))
            {
                SubeGold subeGoldForm = new SubeGold(mySube);
                OpenChildForm(subeGoldForm);
            }
        }
    }
}
