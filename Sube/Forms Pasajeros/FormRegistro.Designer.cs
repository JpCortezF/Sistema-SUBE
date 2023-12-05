namespace Sube
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            grpDatos = new GroupBox();
            btnHardcode = new Button();
            btnMostrarPass = new Button();
            label7 = new Label();
            label6 = new Label();
            txtLastname = new TextBox();
            txtName = new TextBox();
            label11 = new Label();
            txtRepetirClave = new TextBox();
            lblClave = new Label();
            label8 = new Label();
            txtClave = new TextBox();
            label4 = new Label();
            btnMasculino = new Button();
            btnFemenino = new Button();
            btnX = new Button();
            grpTarjeta = new GroupBox();
            label2 = new Label();
            txtTarjeta4 = new TextBox();
            txtTarjeta3 = new TextBox();
            txtTarjeta2 = new TextBox();
            textBox5 = new TextBox();
            lblTarjeta = new Label();
            btnContinuar = new Button();
            label9 = new Label();
            lblCorreo = new Label();
            label5 = new Label();
            txtCorreo = new TextBox();
            lblDni = new Label();
            label3 = new Label();
            txtDni = new TextBox();
            btnDni = new Button();
            panelDatos = new Panel();
            pictureBox1 = new PictureBox();
            grpDatos.SuspendLayout();
            grpTarjeta.SuspendLayout();
            panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.BackColor = SystemColors.ButtonFace;
            grpDatos.Controls.Add(btnHardcode);
            grpDatos.Controls.Add(btnMostrarPass);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(txtLastname);
            grpDatos.Controls.Add(txtName);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(txtRepetirClave);
            grpDatos.Controls.Add(lblClave);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(txtClave);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(btnMasculino);
            grpDatos.Controls.Add(btnFemenino);
            grpDatos.Controls.Add(btnX);
            grpDatos.Controls.Add(grpTarjeta);
            grpDatos.Controls.Add(btnContinuar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(lblCorreo);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtDni);
            grpDatos.Controls.Add(btnDni);
            grpDatos.Location = new Point(30, 0);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(418, 760);
            grpDatos.TabIndex = 4;
            grpDatos.TabStop = false;
            // 
            // btnHardcode
            // 
            btnHardcode.BackColor = Color.IndianRed;
            btnHardcode.Cursor = Cursors.Hand;
            btnHardcode.FlatStyle = FlatStyle.Flat;
            btnHardcode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHardcode.ForeColor = SystemColors.Control;
            btnHardcode.Location = new Point(26, 630);
            btnHardcode.Name = "btnHardcode";
            btnHardcode.Size = new Size(147, 41);
            btnHardcode.TabIndex = 50;
            btnHardcode.Text = "HARDCODE ->";
            btnHardcode.UseVisualStyleBackColor = false;
            btnHardcode.Click += btnHardcode_Click;
            // 
            // btnMostrarPass
            // 
            btnMostrarPass.BackgroundImage = (Image)resources.GetObject("btnMostrarPass.BackgroundImage");
            btnMostrarPass.BackgroundImageLayout = ImageLayout.Zoom;
            btnMostrarPass.Cursor = Cursors.Hand;
            btnMostrarPass.Location = new Point(361, 492);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 11;
            btnMostrarPass.UseVisualStyleBackColor = true;
            btnMostrarPass.Click += btnMostrarPass_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 106);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 48;
            label7.Text = "* Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 168);
            label6.Name = "label6";
            label6.Size = new Size(83, 16);
            label6.TabIndex = 47;
            label6.Text = "* Apellidos";
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastname.Location = new Point(26, 187);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(388, 26);
            txtLastname.TabIndex = 46;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(25, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(388, 26);
            txtName.TabIndex = 45;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(27, 530);
            label11.Name = "label11";
            label11.Size = new Size(112, 16);
            label11.TabIndex = 41;
            label11.Text = "* Repetir Clave";
            // 
            // txtRepetirClave
            // 
            txtRepetirClave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepetirClave.Location = new Point(27, 549);
            txtRepetirClave.MaxLength = 4;
            txtRepetirClave.Name = "txtRepetirClave";
            txtRepetirClave.PasswordChar = '•';
            txtRepetirClave.Size = new Size(387, 26);
            txtRepetirClave.TabIndex = 11;
            txtRepetirClave.TextChanged += txtRepetirClave_TextChanged;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.DarkRed;
            lblClave.Location = new Point(28, 578);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(77, 15);
            lblClave.TabIndex = 39;
            lblClave.Text = "lblErrorClave";
            lblClave.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 472);
            label8.Name = "label8";
            label8.Size = new Size(57, 16);
            label8.TabIndex = 38;
            label8.Text = "* Clave";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(25, 492);
            txtClave.MaxLength = 4;
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '•';
            txtClave.PlaceholderText = "Ej. 9030";
            txtClave.Size = new Size(388, 26);
            txtClave.TabIndex = 10;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 306);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 23;
            label4.Text = "* Genero";
            // 
            // btnMasculino
            // 
            btnMasculino.BackColor = Color.WhiteSmoke;
            btnMasculino.Cursor = Cursors.Hand;
            btnMasculino.FlatStyle = FlatStyle.Flat;
            btnMasculino.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasculino.Location = new Point(28, 325);
            btnMasculino.Name = "btnMasculino";
            btnMasculino.Size = new Size(130, 28);
            btnMasculino.TabIndex = 6;
            btnMasculino.Text = "Masculino";
            btnMasculino.UseVisualStyleBackColor = false;
            // 
            // btnFemenino
            // 
            btnFemenino.BackColor = Color.WhiteSmoke;
            btnFemenino.Cursor = Cursors.Hand;
            btnFemenino.FlatStyle = FlatStyle.Flat;
            btnFemenino.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFemenino.Location = new Point(155, 325);
            btnFemenino.Name = "btnFemenino";
            btnFemenino.Size = new Size(130, 28);
            btnFemenino.TabIndex = 7;
            btnFemenino.Text = "Femenino";
            btnFemenino.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.WhiteSmoke;
            btnX.Cursor = Cursors.Hand;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnX.Location = new Point(284, 325);
            btnX.Name = "btnX";
            btnX.Size = new Size(130, 28);
            btnX.TabIndex = 8;
            btnX.Text = "x";
            btnX.UseVisualStyleBackColor = false;
            // 
            // grpTarjeta
            // 
            grpTarjeta.Controls.Add(label2);
            grpTarjeta.Controls.Add(txtTarjeta4);
            grpTarjeta.Controls.Add(txtTarjeta3);
            grpTarjeta.Controls.Add(txtTarjeta2);
            grpTarjeta.Controls.Add(textBox5);
            grpTarjeta.Controls.Add(lblTarjeta);
            grpTarjeta.Location = new Point(12, 3);
            grpTarjeta.Name = "grpTarjeta";
            grpTarjeta.Size = new Size(427, 100);
            grpTarjeta.TabIndex = 36;
            grpTarjeta.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 17;
            label2.Text = "* N° de tarjeta";
            // 
            // txtTarjeta4
            // 
            txtTarjeta4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTarjeta4.Location = new Point(323, 47);
            txtTarjeta4.MaxLength = 4;
            txtTarjeta4.Name = "txtTarjeta4";
            txtTarjeta4.Size = new Size(78, 26);
            txtTarjeta4.TabIndex = 3;
            txtTarjeta4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTarjeta3
            // 
            txtTarjeta3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTarjeta3.Location = new Point(217, 47);
            txtTarjeta3.MaxLength = 4;
            txtTarjeta3.Name = "txtTarjeta3";
            txtTarjeta3.Size = new Size(78, 26);
            txtTarjeta3.TabIndex = 2;
            txtTarjeta3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTarjeta2
            // 
            txtTarjeta2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTarjeta2.Location = new Point(108, 47);
            txtTarjeta2.MaxLength = 4;
            txtTarjeta2.Name = "txtTarjeta2";
            txtTarjeta2.Size = new Size(78, 26);
            txtTarjeta2.TabIndex = 1;
            txtTarjeta2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonFace;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.WindowFrame;
            textBox5.Location = new Point(14, 50);
            textBox5.MaxLength = 4;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(78, 19);
            textBox5.TabIndex = 0;
            textBox5.TabStop = false;
            textBox5.Text = "6061";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarjeta.ForeColor = Color.DarkRed;
            lblTarjeta.Location = new Point(14, 82);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(85, 15);
            lblTarjeta.TabIndex = 28;
            lblTarjeta.Text = "lblErrorTarjeta";
            lblTarjeta.Visible = false;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.LimeGreen;
            btnContinuar.Cursor = Cursors.Hand;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Control;
            btnContinuar.Location = new Point(266, 631);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(147, 41);
            btnContinuar.TabIndex = 13;
            btnContinuar.Text = "CONTINUAR ->";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(27, 366);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 35;
            label9.Text = "lblErrorDNI";
            label9.Visible = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.DarkRed;
            lblCorreo.Location = new Point(27, 444);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(84, 15);
            lblCorreo.TabIndex = 34;
            lblCorreo.Text = "lblErrorCorreo";
            lblCorreo.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 396);
            label5.Name = "label5";
            label5.Size = new Size(145, 16);
            label5.TabIndex = 30;
            label5.Text = "* Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(27, 415);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(387, 26);
            txtCorreo.TabIndex = 9;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.DarkRed;
            lblDni.Location = new Point(27, 277);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(68, 15);
            lblDni.TabIndex = 27;
            lblDni.Text = "lblErrorDNI";
            lblDni.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 229);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 22;
            label3.Text = "* DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(27, 248);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(335, 26);
            txtDni.TabIndex = 4;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnDni
            // 
            btnDni.BackgroundImage = (Image)resources.GetObject("btnDni.BackgroundImage");
            btnDni.BackgroundImageLayout = ImageLayout.Zoom;
            btnDni.Cursor = Cursors.Hand;
            btnDni.Location = new Point(361, 247);
            btnDni.Name = "btnDni";
            btnDni.Size = new Size(53, 27);
            btnDni.TabIndex = 5;
            btnDni.UseVisualStyleBackColor = true;
            btnDni.Click += btnDni_Click;
            // 
            // panelDatos
            // 
            panelDatos.AutoScroll = true;
            panelDatos.Controls.Add(grpDatos);
            panelDatos.Location = new Point(359, 0);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(468, 458);
            panelDatos.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DarkMode;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 389);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panelDatos);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistro";
            Load += FormRegistro_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpTarjeta.ResumeLayout(false);
            grpTarjeta.PerformLayout();
            panelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private GroupBox grpTarjeta;
        private Label label2;
        private TextBox txtTarjeta4;
        private TextBox txtTarjeta3;
        private TextBox txtTarjeta2;
        private TextBox textBox5;
        private Label lblTarjeta;
        private Button btnContinuar;
        private Label label9;
        private Label lblCorreo;
        private Label label5;
        private TextBox txtCorreo;
        private Label lblDni;
        private Button btnX;
        private Button btnFemenino;
        private Button btnMasculino;
        private Label label4;
        private Label label3;
        private TextBox txtDni;
        private Button btnDni;
        private Label label11;
        private TextBox txtRepetirClave;
        private Label lblClave;
        private Label label8;
        private TextBox txtClave;
        private Panel panelDatos;
        private Label label7;
        private Label label6;
        private TextBox txtLastname;
        private TextBox txtName;
        private Button btnMostrarPass;
        private Button btnHardcode;
        private PictureBox pictureBox1;
    }
}