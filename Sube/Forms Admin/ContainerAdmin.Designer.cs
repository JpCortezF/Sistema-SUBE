namespace Sube
{
    partial class ContainerAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerAdmin));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            buscadorToolStripMenuItem = new ToolStripMenuItem();
            notificacionesToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, buscadorToolStripMenuItem, notificacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 39);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inicioToolStripMenuItem.ForeColor = Color.Black;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(102, 35);
            inicioToolStripMenuItem.Text = "INICIO";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // buscadorToolStripMenuItem
            // 
            buscadorToolStripMenuItem.Name = "buscadorToolStripMenuItem";
            buscadorToolStripMenuItem.Size = new Size(155, 35);
            buscadorToolStripMenuItem.Text = "BUSCADOR";
            buscadorToolStripMenuItem.Click += buscadorToolStripMenuItem_Click;
            // 
            // notificacionesToolStripMenuItem
            // 
            notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            notificacionesToolStripMenuItem.Size = new Size(223, 35);
            notificacionesToolStripMenuItem.Text = "NOTIFICACIONES";
            notificacionesToolStripMenuItem.Click += notificacionesToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondoAdmin2;
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1084, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(314, 527);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // ContainerAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ContainerAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContainterAdmin";
            Load += ContainerAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem buscadorToolStripMenuItem;
        private ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}



