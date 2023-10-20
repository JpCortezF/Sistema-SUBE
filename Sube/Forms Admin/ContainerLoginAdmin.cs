using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube.Forms_Admin
{
    public partial class ContainerLoginAdmin : Form
    {
        private Form currentChildForm = null;

        public ContainerLoginAdmin()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radio = 15; // Ajusta el radio según tus preferencias

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90); // Esquina superior izquierda
            path.AddArc(Width - (radio * 2), 0, radio * 2, radio * 2, -90, 90); // Esquina superior derecha
            path.AddArc(Width - (radio * 2), Height - (radio * 2), radio * 2, radio * 2, 0, 90); // Esquina inferior derecha
            path.AddArc(0, Height - (radio * 2), radio * 2, radio * 2, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void ContainerLoginAdmin_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem itemSalir = new ToolStripMenuItem("SALIR");
            menuStrip1.Items.Add(itemSalir);
            itemSalir.Alignment = ToolStripItemAlignment.Right;
            itemSalir.BackColor = SystemColors.ActiveCaption;
            itemSalir.ForeColor = SystemColors.ControlText;
            itemSalir.Click += itemSalir_Click;
            if (currentChildForm is null || !(currentChildForm is FormAdmin))
            {
                FormAdmin adminLogin = new FormAdmin(this);
                OpenChildForm(adminLogin);
            }
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
            childForm.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            if (currentChildForm is null || !(currentChildForm is FormAdmin))
            {
                FormAdmin adminLogin = new FormAdmin(this);
                OpenChildForm(adminLogin);
            }
        }
    }

}
