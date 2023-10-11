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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            btnCargar = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblSaldo = new Label();
            txtCarga = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(101, 9);
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
            btnSalir.Location = new Point(340, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 42);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 44);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblSaldo);
            groupBox1.Controls.Add(txtCarga);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 435);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(6, 120);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "$ARS";
            textBox1.Size = new Size(96, 38);
            textBox1.TabIndex = 16;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.ActiveCaption;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.Location = new Point(126, 308);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(121, 37);
            btnCargar.TabIndex = 15;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(138, 363);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 14;
            label3.Text = "o Presencial";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.mercado_pago;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(98, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 84);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(94, 177);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 12;
            label1.Text = "Método de pago actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(145, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 11;
            label2.Text = "Saldo actual";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.SeaGreen;
            lblSaldo.Location = new Point(109, 36);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(148, 39);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "$ saldo";
            // 
            // txtCarga
            // 
            txtCarga.BackColor = SystemColors.Control;
            txtCarga.BorderStyle = BorderStyle.FixedSingle;
            txtCarga.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtCarga.Location = new Point(104, 118);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(180, 45);
            txtCarga.TabIndex = 0;
            txtCarga.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 281);
            panel2.TabIndex = 15;
            // 
            // CargaSube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(389, 321);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CargaSube";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargaSube";
            Load += CargaSube_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitulo;
        private Button btnSalir;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblSaldo;
        private TextBox txtCarga;
        private Panel panel2;
        private Button btnCargar;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}