namespace Sube.Forms_Pasajeros
{
    partial class SubeONLINE
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
            pictureBox2 = new PictureBox();
            txtDomicilio = new TextBox();
            label7 = new Label();
            txtCarga = new TextBox();
            textBox1 = new TextBox();
            btnComprar = new Button();
            txtClaim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Reparto;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 389);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDomicilio.Location = new Point(429, 41);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(388, 26);
            txtDomicilio.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(429, 13);
            label7.Name = "label7";
            label7.Size = new Size(140, 16);
            label7.TabIndex = 49;
            label7.Text = "* Ingrese domicilio ";
            // 
            // txtCarga
            // 
            txtCarga.BackColor = SystemColors.Control;
            txtCarga.BorderStyle = BorderStyle.FixedSingle;
            txtCarga.Enabled = false;
            txtCarga.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtCarga.Location = new Point(536, 264);
            txtCarga.Name = "txtCarga";
            txtCarga.PlaceholderText = "500";
            txtCarga.Size = new Size(180, 45);
            txtCarga.TabIndex = 50;
            txtCarga.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(434, 266);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "$ARS";
            textBox1.Size = new Size(96, 38);
            textBox1.TabIndex = 52;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.LightSkyBlue;
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Location = new Point(543, 338);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(173, 44);
            btnComprar.TabIndex = 54;
            btnComprar.Text = "COMPRAR";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // txtClaim
            // 
            txtClaim.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaim.Location = new Point(429, 89);
            txtClaim.MaxLength = 138;
            txtClaim.Multiline = true;
            txtClaim.Name = "txtClaim";
            txtClaim.PlaceholderText = "Algo que nos quieras especificar del domicilio";
            txtClaim.Size = new Size(388, 110);
            txtClaim.TabIndex = 55;
            // 
            // SubeONLINE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 389);
            ControlBox = false;
            Controls.Add(txtClaim);
            Controls.Add(btnComprar);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(txtDomicilio);
            Controls.Add(txtCarga);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubeONLINE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubeONLINE";
            FormClosed += SubeONLINE_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox txtDomicilio;
        private Label label7;
        private TextBox txtCarga;
        private TextBox textBox1;
        private Button btnComprar;
        private TextBox txtClaim;
    }
}