using Biblioteca_TarjetaSube;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class FormCargaCompleta : Form
    {
        TarjetaSube sube;

        public FormCargaCompleta(TarjetaSube sube, string amount)
        {
            InitializeComponent();
            this.sube = sube;
            lblAcreditado.Text = "Saldo acreditado $" + amount;
        }
        private void FormCargaCompleta_Load(object sender, EventArgs e)
        {
            double balance = sube.Balance;
            lblSaldo.Text = $"${balance.ToString("F2")}";
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
        private void lblContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
