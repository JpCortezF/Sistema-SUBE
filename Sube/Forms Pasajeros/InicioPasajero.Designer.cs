namespace Sube
{
    partial class InicioPasajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioPasajero));
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            vIAJARToolStripMenuItem = new ToolStripMenuItem();
            mISUBEToolStripMenuItem = new ToolStripMenuItem();
            subeToolStripMenuItem = new ToolStripMenuItem();
            viajesToolStripMenuItem = new ToolStripMenuItem();
            tarifaSocialToolStripMenuItem = new ToolStripMenuItem();
            darDeBajaToolStripMenuItem = new ToolStripMenuItem();
            subeGOLDToolStripMenuItem = new ToolStripMenuItem();
            mISTRÁMITESToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, vIAJARToolStripMenuItem, mISUBEToolStripMenuItem, mISTRÁMITESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(117, 29);
            iNICIOToolStripMenuItem.Text = "| INICIO |";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // vIAJARToolStripMenuItem
            // 
            vIAJARToolStripMenuItem.Name = "vIAJARToolStripMenuItem";
            vIAJARToolStripMenuItem.Size = new Size(129, 29);
            vIAJARToolStripMenuItem.Text = "| VIAJAR |";
            vIAJARToolStripMenuItem.Click += vIAJARToolStripMenuItem_Click;
            // 
            // mISUBEToolStripMenuItem
            // 
            mISUBEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subeToolStripMenuItem, viajesToolStripMenuItem, tarifaSocialToolStripMenuItem, darDeBajaToolStripMenuItem, subeGOLDToolStripMenuItem });
            mISUBEToolStripMenuItem.Name = "mISUBEToolStripMenuItem";
            mISUBEToolStripMenuItem.Size = new Size(143, 29);
            mISUBEToolStripMenuItem.Text = "| MI SUBE |";
            // 
            // subeToolStripMenuItem
            // 
            subeToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            subeToolStripMenuItem.Name = "subeToolStripMenuItem";
            subeToolStripMenuItem.Size = new Size(168, 24);
            subeToolStripMenuItem.Text = "Sube";
            subeToolStripMenuItem.Click += subeToolStripMenuItem_Click;
            // 
            // viajesToolStripMenuItem
            // 
            viajesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            viajesToolStripMenuItem.Size = new Size(168, 24);
            viajesToolStripMenuItem.Text = "Viajes";
            viajesToolStripMenuItem.Click += viajesToolStripMenuItem_Click;
            // 
            // tarifaSocialToolStripMenuItem
            // 
            tarifaSocialToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tarifaSocialToolStripMenuItem.Name = "tarifaSocialToolStripMenuItem";
            tarifaSocialToolStripMenuItem.Size = new Size(168, 24);
            tarifaSocialToolStripMenuItem.Text = "Tarifa Social";
            tarifaSocialToolStripMenuItem.Click += tarifaSocialToolStripMenuItem_Click;
            // 
            // darDeBajaToolStripMenuItem
            // 
            darDeBajaToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            darDeBajaToolStripMenuItem.Size = new Size(168, 24);
            darDeBajaToolStripMenuItem.Text = "Dar de baja";
            darDeBajaToolStripMenuItem.Click += darDeBajaToolStripMenuItem_Click;
            // 
            // subeGOLDToolStripMenuItem
            // 
            subeGOLDToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            subeGOLDToolStripMenuItem.Name = "subeGOLDToolStripMenuItem";
            subeGOLDToolStripMenuItem.Size = new Size(168, 24);
            subeGOLDToolStripMenuItem.Text = "Sube GOLD";
            subeGOLDToolStripMenuItem.Click += subeGOLDToolStripMenuItem_Click;
            // 
            // mISTRÁMITESToolStripMenuItem
            // 
            mISTRÁMITESToolStripMenuItem.Name = "mISTRÁMITESToolStripMenuItem";
            mISTRÁMITESToolStripMenuItem.Size = new Size(211, 29);
            mISTRÁMITESToolStripMenuItem.Text = "| MIS TRÁMITES |";
            mISTRÁMITESToolStripMenuItem.Click += mISTRÁMITESToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LigthMode;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.ImageAlign = ContentAlignment.BottomCenter;
            lblNombre.Location = new Point(332, 495);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 31);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "¡Hola!";
            // 
            // InicioPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LigthMode;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 550);
            ControlBox = false;
            Controls.Add(lblNombre);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "InicioPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioPasajero";
            FormClosed += InicioPasajero_FormClosed;
            Load += InicioPasajero_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mISUBEToolStripMenuItem;
        private ToolStripMenuItem viajesToolStripMenuItem;
        private ToolStripMenuItem tarifaSocialToolStripMenuItem;
        private ToolStripMenuItem subeToolStripMenuItem;
        private ToolStripMenuItem vIAJARToolStripMenuItem;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem darDeBajaToolStripMenuItem;
        private ToolStripMenuItem mISTRÁMITESToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label lblNombre;
        private ToolStripMenuItem subeGOLDToolStripMenuItem;
    }
}