using Biblioteca_TarjetaSube;
using Biblioteca_DataBase;
using Logica;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sube
{
    public partial class CargaSube : Form
    {
        TarjetaSube sube;
        public CargaSube(TarjetaSube sube)
        {
            InitializeComponent();
            this.sube = sube; 
        }
        private void lblContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void txtCarga_TextChanged(object sender, EventArgs e)
        {
            txtCarga.Text = Regex.Replace(txtCarga.Text, @"[^0-9]", "");
        }

        private void CargaSube_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "Carga tu SUBE de forma virtual desde Mercado Pago";
            lblSaldo.Text = $"${sube.Balance:F2}";
            txtCarga.TextChanged += txtCarga_TextChanged;
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
        public string DevolverMonto()
        {
            return txtCarga.Text;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {   
                float balance = sube.Balance;
                SistemaSube sistemaSube = new SistemaSube();
                if (!string.IsNullOrEmpty(txtCarga.Text))
                {
                    if (float.TryParse(txtCarga.Text, out balance))
                    {
                        sube.Balance += balance;
                        if (sube.Balance < 0)
                        {
                            sube.Balance -= balance;
                            MessageBox.Show("El saldo de la SUBE no puede quedar en NEGATIVO", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            sistemaSube.UpdateSubeBalance(sube);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }
                else
                {
                    txtCarga.BackColor = Color.RosyBrown;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
