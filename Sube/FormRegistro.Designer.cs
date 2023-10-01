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
            lblCorreoRepetido = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            lblDni = new Label();
            btnX = new Button();
            btnFemenino = new Button();
            btnMasculino = new Button();
            label4 = new Label();
            label3 = new Label();
            txtDni = new TextBox();
            btnDni = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            sUBEToolStripMenuItem = new ToolStripMenuItem();
            iNGRESARToolStripMenuItem = new ToolStripMenuItem();
            grpDatos.SuspendLayout();
            grpTarjeta.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.BackColor = SystemColors.ButtonFace;
            grpDatos.Controls.Add(grpTarjeta);
            grpDatos.Controls.Add(btnContinuar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(lblCorreo);
            grpDatos.Controls.Add(lblCorreoRepetido);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(textBox1);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(btnX);
            grpDatos.Controls.Add(btnFemenino);
            grpDatos.Controls.Add(btnMasculino);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtDni);
            grpDatos.Controls.Add(btnDni);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(155, 44);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(461, 519);
            grpDatos.TabIndex = 4;
            grpDatos.TabStop = false;
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
            grpTarjeta.Text = "Tarjeta";
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
            lblTarjeta.Location = new Point(13, 82);
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
            btnContinuar.Location = new Point(271, 463);
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
            label9.Location = new Point(31, 285);
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
            // lblCorreoRepetido
            // 
            lblCorreoRepetido.AutoSize = true;
            lblCorreoRepetido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreoRepetido.ForeColor = Color.DarkRed;
            lblCorreoRepetido.Location = new Point(31, 439);
            lblCorreoRepetido.Name = "lblCorreoRepetido";
            lblCorreoRepetido.Size = new Size(84, 15);
            lblCorreoRepetido.TabIndex = 33;
            lblCorreoRepetido.Text = "lblErrorCorreo";
            lblCorreoRepetido.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 391);
            label6.Name = "label6";
            label6.Size = new Size(200, 16);
            label6.TabIndex = 32;
            label6.Text = "* Repetir Correo electrónico";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(31, 410);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 26);
            textBox1.TabIndex = 10;
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
            // btnX
            // 
            btnX.Cursor = Cursors.Hand;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnX.Location = new Point(288, 254);
            btnX.Name = "btnX";
            btnX.Size = new Size(130, 28);
            btnX.TabIndex = 8;
            btnX.Text = "x";
            btnX.UseVisualStyleBackColor = true;
            // 
            // btnFemenino
            // 
            btnFemenino.Cursor = Cursors.Hand;
            btnFemenino.FlatStyle = FlatStyle.Flat;
            btnFemenino.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFemenino.Location = new Point(159, 254);
            btnFemenino.Name = "btnFemenino";
            btnFemenino.Size = new Size(130, 28);
            btnFemenino.TabIndex = 7;
            btnFemenino.Text = "Femenino";
            btnFemenino.UseVisualStyleBackColor = true;
            // 
            // btnMasculino
            // 
            btnMasculino.Cursor = Cursors.Hand;
            btnMasculino.FlatStyle = FlatStyle.Flat;
            btnMasculino.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasculino.Location = new Point(31, 254);
            btnMasculino.Name = "btnMasculino";
            btnMasculino.Size = new Size(130, 28);
            btnMasculino.TabIndex = 6;
            btnMasculino.Text = "Masculino";
            btnMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 226);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 23;
            label4.Text = "* Genero";
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
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(335, 26);
            txtDni.TabIndex = 4;
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
            menuStrip1.Size = new Size(788, 39);
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
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 552);
            ControlBox = false;
            Controls.Add(grpDatos);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistro";
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
        private Label lblCorreoRepetido;
        private Label label6;
        private TextBox textBox1;
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
    }
}