namespace Sube
{
    partial class CargaSube
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
            lblTitulo = new Label();
            btnSalir = new Button();
            panel1 = new Panel();
            lblContinuar = new Label();
            pictureBox2 = new PictureBox();
            lblMensaje = new Label();
            txtCarga = new TextBox();
            lblSaldo = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnCargar = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(340, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 29);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cargar SUBE!";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(886, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 44);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblContinuar);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 36);
            panel1.TabIndex = 3;
            // 
            // lblContinuar
            // 
            lblContinuar.AutoSize = true;
            lblContinuar.Cursor = Cursors.Hand;
            lblContinuar.Font = new Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContinuar.Location = new Point(22, 2);
            lblContinuar.Name = "lblContinuar";
            lblContinuar.Size = new Size(58, 33);
            lblContinuar.TabIndex = 18;
            lblContinuar.Text = "<---";
            lblContinuar.Click += lblContinuar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.proyectoSube;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(37, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 194);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;
            lblMensaje.Location = new Point(37, 86);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(70, 17);
            lblMensaje.TabIndex = 17;
            lblMensaje.Text = "Mensaje";
            // 
            // txtCarga
            // 
            txtCarga.BackColor = SystemColors.Control;
            txtCarga.BorderStyle = BorderStyle.FixedSingle;
            txtCarga.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtCarga.Location = new Point(572, 146);
            txtCarga.MaxLength = 4;
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(180, 45);
            txtCarga.TabIndex = 0;
            txtCarga.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.SeaGreen;
            lblSaldo.Location = new Point(577, 64);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(148, 39);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "$ saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(613, 117);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 11;
            label2.Text = "Saldo actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(562, 205);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 12;
            label1.Text = "Método de pago actual";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.mercado_pago;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(566, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 84);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(606, 391);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 14;
            label3.Text = "o Presencial";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.ActiveCaption;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.Location = new Point(594, 336);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(121, 37);
            btnCargar.TabIndex = 15;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(474, 148);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "$ARS";
            textBox1.Size = new Size(96, 38);
            textBox1.TabIndex = 16;
            // 
            // CargaSube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(846, 438);
            Controls.Add(textBox1);
            Controls.Add(lblMensaje);
            Controls.Add(btnCargar);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtCarga);
            Controls.Add(label2);
            Controls.Add(lblSaldo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CargaSube";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargaSube";
            Load += CargaSube_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Button btnSalir;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblMensaje;
        private Label lblContinuar;
        private TextBox txtCarga;
        private Label lblSaldo;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnCargar;
        private TextBox textBox1;
    }
}