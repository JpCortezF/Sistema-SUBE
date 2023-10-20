namespace Sube
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            btnPasajero = new Button();
            btnAdmin = new Button();
            lblPrincipal = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(267, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(332, 339);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 34);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnPasajero
            // 
            btnPasajero.BackColor = Color.LightSkyBlue;
            btnPasajero.Cursor = Cursors.Hand;
            btnPasajero.FlatAppearance.BorderSize = 0;
            btnPasajero.FlatStyle = FlatStyle.Flat;
            btnPasajero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasajero.Location = new Point(332, 280);
            btnPasajero.Name = "btnPasajero";
            btnPasajero.Size = new Size(164, 34);
            btnPasajero.TabIndex = 11;
            btnPasajero.Text = "Pasajero";
            btnPasajero.UseVisualStyleBackColor = false;
            btnPasajero.Click += btnPasajero_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.LightGreen;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Location = new Point(332, 222);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(164, 34);
            btnAdmin.TabIndex = 10;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = Color.Transparent;
            lblPrincipal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrincipal.ForeColor = SystemColors.Control;
            lblPrincipal.Location = new Point(69, 132);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(141, 18);
            lblPrincipal.TabIndex = 9;
            lblPrincipal.Text = "Mensaje Principal";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo_sube_blanco_sombra_web;
            pictureBox2.Location = new Point(305, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(817, 447);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(btnPasajero);
            Controls.Add(btnAdmin);
            Controls.Add(lblPrincipal);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnPasajero;
        private Button btnAdmin;
        private Label lblPrincipal;
        private PictureBox pictureBox2;
    }
}