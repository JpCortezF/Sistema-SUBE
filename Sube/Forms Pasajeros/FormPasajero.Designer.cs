namespace Sube
{
    partial class FormPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasajero));
            label3 = new Label();
            btnOnline = new Button();
            label2 = new Label();
            btnRegistrar = new Button();
            lblIngresar = new Label();
            btnIngresar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(558, 373);
            label3.Name = "label3";
            label3.Size = new Size(126, 16);
            label3.TabIndex = 32;
            label3.Text = "Compra tu SUBE ";
            // 
            // btnOnline
            // 
            btnOnline.BackColor = Color.LightSkyBlue;
            btnOnline.BackgroundImage = (Image)resources.GetObject("btnOnline.BackgroundImage");
            btnOnline.BackgroundImageLayout = ImageLayout.Zoom;
            btnOnline.Cursor = Cursors.Hand;
            btnOnline.FlatAppearance.BorderSize = 0;
            btnOnline.FlatStyle = FlatStyle.Flat;
            btnOnline.Location = new Point(522, 319);
            btnOnline.Name = "btnOnline";
            btnOnline.Size = new Size(197, 51);
            btnOnline.TabIndex = 26;
            btnOnline.UseVisualStyleBackColor = false;
            btnOnline.Click += btnOnline_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(558, 271);
            label2.Name = "label2";
            label2.Size = new Size(132, 16);
            label2.TabIndex = 30;
            label2.Text = "Registra tu cuenta";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSkyBlue;
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(522, 217);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(197, 51);
            btnRegistrar.TabIndex = 25;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.BackColor = Color.Transparent;
            lblIngresar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresar.ForeColor = Color.White;
            lblIngresar.Location = new Point(558, 167);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(138, 16);
            lblIngresar.TabIndex = 23;
            lblIngresar.Text = "Ingresa a tu cuenta";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(255, 128, 128);
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(521, 113);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(198, 51);
            btnIngresar.TabIndex = 22;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblIngresar);
            panel1.Controls.Add(btnOnline);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 430);
            panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.brigdeTrainGif;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 430);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumSlateBlue;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(830, 37);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(131, 33);
            iNICIOToolStripMenuItem.Text = "| INICIO |";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // FormPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(830, 430);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPasajero";
            Load += FormPasajero_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnOnline;
        private Label label2;
        private Button btnRegistrar;
        private Label lblIngresar;
        private Button btnIngresar;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}