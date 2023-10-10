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
            menuStrip1 = new MenuStrip();
            mISUBEToolStripMenuItem = new ToolStripMenuItem();
            mISUBEToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            lblPasajero = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mISUBEToolStripMenuItem, mISUBEToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 37);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mISUBEToolStripMenuItem
            // 
            mISUBEToolStripMenuItem.BackColor = SystemColors.Control;
            mISUBEToolStripMenuItem.Name = "mISUBEToolStripMenuItem";
            mISUBEToolStripMenuItem.Size = new Size(103, 33);
            mISUBEToolStripMenuItem.Text = "INICIO";
            mISUBEToolStripMenuItem.Click += mISUBEToolStripMenuItem_Click;
            // 
            // mISUBEToolStripMenuItem1
            // 
            mISUBEToolStripMenuItem1.Name = "mISUBEToolStripMenuItem1";
            mISUBEToolStripMenuItem1.Size = new Size(129, 33);
            mISUBEToolStripMenuItem1.Text = "MI SUBE";
            mISUBEToolStripMenuItem1.Click += mISUBEToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lblPasajero);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 416);
            panel1.TabIndex = 2;
            // 
            // lblPasajero
            // 
            lblPasajero.AutoSize = true;
            lblPasajero.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajero.ForeColor = Color.White;
            lblPasajero.Location = new Point(12, 62);
            lblPasajero.Name = "lblPasajero";
            lblPasajero.Size = new Size(224, 29);
            lblPasajero.TabIndex = 4;
            lblPasajero.Text = "Nombre del pasajero";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.headerShortMiSube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(934, 149);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // InicioPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "InicioPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioPasajero";
            Load += InicioPasajero_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mISUBEToolStripMenuItem;
        private ToolStripMenuItem mISUBEToolStripMenuItem1;
        private Panel panel1;
        private Label lblPasajero;
        private PictureBox pictureBox1;
    }
}