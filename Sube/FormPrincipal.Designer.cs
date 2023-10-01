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
            pictureBox1 = new PictureBox();
            btnPasajero = new Button();
            btnAdmin = new Button();
            lblPrincipal = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_sube_blanco_sombra_web;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(284, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 126);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnPasajero
            // 
            btnPasajero.BackColor = Color.LightSkyBlue;
            btnPasajero.FlatStyle = FlatStyle.Flat;
            btnPasajero.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasajero.Location = new Point(284, 284);
            btnPasajero.Name = "btnPasajero";
            btnPasajero.Size = new Size(282, 39);
            btnPasajero.TabIndex = 6;
            btnPasajero.Text = "Pasajero";
            btnPasajero.UseVisualStyleBackColor = false;
            btnPasajero.Click += btnPasajero_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.LightGreen;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Location = new Point(284, 227);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(282, 39);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrincipal.Location = new Point(13, 170);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(176, 24);
            lblPrincipal.TabIndex = 4;
            lblPrincipal.Text = "Mensaje Principal";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(284, 347);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(282, 39);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 411);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnPasajero);
            Controls.Add(btnAdmin);
            Controls.Add(lblPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPasajero;
        private Button btnAdmin;
        private Label lblPrincipal;
        private Button btnSalir;
    }
}