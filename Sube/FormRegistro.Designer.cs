﻿namespace Sube
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
            label12 = new Label();
            cmbTipoPasajero = new ComboBox();
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            sUBEToolStripMenuItem = new ToolStripMenuItem();
            iNGRESARToolStripMenuItem = new ToolStripMenuItem();
            btnMostrarCargados = new Button();
            grpDatos.SuspendLayout();
            grpTarjeta.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.BackColor = SystemColors.ButtonFace;
            grpDatos.Controls.Add(btnMostrarCargados);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(cmbTipoPasajero);
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
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(155, 44);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(461, 664);
            grpDatos.TabIndex = 4;
            grpDatos.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(32, 550);
            label12.Name = "label12";
            label12.Size = new Size(106, 16);
            label12.TabIndex = 44;
            label12.Text = "* Tarifa Social";
            // 
            // cmbTipoPasajero
            // 
            cmbTipoPasajero.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoPasajero.FormattingEnabled = true;
            cmbTipoPasajero.Location = new Point(32, 569);
            cmbTipoPasajero.Name = "cmbTipoPasajero";
            cmbTipoPasajero.Size = new Size(173, 28);
            cmbTipoPasajero.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(33, 468);
            label11.Name = "label11";
            label11.Size = new Size(112, 16);
            label11.TabIndex = 41;
            label11.Text = "* Repetir Clave";
            // 
            // txtRepetirClave
            // 
            txtRepetirClave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepetirClave.Location = new Point(32, 487);
            txtRepetirClave.MaxLength = 4;
            txtRepetirClave.Name = "txtRepetirClave";
            txtRepetirClave.PasswordChar = '•';
            txtRepetirClave.Size = new Size(387, 26);
            txtRepetirClave.TabIndex = 11;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.DarkRed;
            lblClave.Location = new Point(33, 516);
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
            label8.Location = new Point(33, 395);
            label8.Name = "label8";
            label8.Size = new Size(57, 16);
            label8.TabIndex = 38;
            label8.Text = "* Clave";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(32, 414);
            txtClave.MaxLength = 4;
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '•';
            txtClave.Size = new Size(387, 26);
            txtClave.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 229);
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
            btnMasculino.Location = new Point(32, 248);
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
            btnFemenino.Location = new Point(159, 248);
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
            btnX.Location = new Point(288, 248);
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
            grpTarjeta.Location = new Point(18, 47);
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
            textBox5.TabIndex = 21;
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
            btnContinuar.Location = new Point(273, 611);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(147, 41);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "CONTINUAR ->";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(31, 289);
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
            lblCorreo.Location = new Point(31, 367);
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
            label5.Location = new Point(32, 319);
            label5.Name = "label5";
            label5.Size = new Size(145, 16);
            label5.TabIndex = 30;
            label5.Text = "* Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(31, 338);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(387, 26);
            txtCorreo.TabIndex = 9;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.DarkRed;
            lblDni.Location = new Point(31, 200);
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
            label3.Location = new Point(31, 152);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 22;
            label3.Text = "* DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(31, 171);
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
            btnDni.Location = new Point(365, 170);
            btnDni.Name = "btnDni";
            btnDni.Size = new Size(53, 27);
            btnDni.TabIndex = 5;
            btnDni.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Paso 1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSkyBlue;
            menuStrip1.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sUBEToolStripMenuItem, iNGRESARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(787, 39);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // sUBEToolStripMenuItem
            // 
            sUBEToolStripMenuItem.Name = "sUBEToolStripMenuItem";
            sUBEToolStripMenuItem.Size = new Size(84, 35);
            sUBEToolStripMenuItem.Text = "SUBE";
            sUBEToolStripMenuItem.Click += sUBEToolStripMenuItem_Click_1;
            // 
            // iNGRESARToolStripMenuItem
            // 
            iNGRESARToolStripMenuItem.Name = "iNGRESARToolStripMenuItem";
            iNGRESARToolStripMenuItem.Size = new Size(145, 35);
            iNGRESARToolStripMenuItem.Text = "INGRESAR";
            iNGRESARToolStripMenuItem.Click += iNGRESARToolStripMenuItem_Click_1;
            // 
            // btnMostrarCargados
            // 
            btnMostrarCargados.Location = new Point(32, 617);
            btnMostrarCargados.Name = "btnMostrarCargados";
            btnMostrarCargados.Size = new Size(97, 30);
            btnMostrarCargados.TabIndex = 45;
            btnMostrarCargados.Text = "Mostrar";
            btnMostrarCargados.UseVisualStyleBackColor = true;
            btnMostrarCargados.Click += btnMostrarCargados_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 720);
            ControlBox = false;
            Controls.Add(grpDatos);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistro";
            Load += FormRegistro_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpTarjeta.ResumeLayout(false);
            grpTarjeta.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sUBEToolStripMenuItem;
        private ToolStripMenuItem iNGRESARToolStripMenuItem;
        private Label label11;
        private TextBox txtRepetirClave;
        private Label lblClave;
        private Label label8;
        private TextBox txtClave;
        private Label label12;
        private ComboBox cmbTipoPasajero;
        private Button btnMostrarCargados;
    }
}