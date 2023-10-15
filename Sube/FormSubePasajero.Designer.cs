namespace Sube
{
    partial class FormSubePasajero
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
            lblTarjeta = new Label();
            lblName = new Label();
            cmbBaja = new ComboBox();
            label2 = new Label();
            btnSalir = new Button();
            label1 = new Label();
            lblSaldo = new Label();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.proyectoSube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 194);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.BackColor = Color.Transparent;
            lblTarjeta.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarjeta.ForeColor = Color.Black;
            lblTarjeta.Location = new Point(39, 135);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(158, 18);
            lblTarjeta.TabIndex = 4;
            lblTarjeta.Text = "Card Number 6061";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(39, 173);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 19);
            lblName.TabIndex = 5;
            lblName.Text = "Passenger name";
            // 
            // cmbBaja
            // 
            cmbBaja.Cursor = Cursors.Hand;
            cmbBaja.FormattingEnabled = true;
            cmbBaja.Location = new Point(521, 37);
            cmbBaja.Name = "cmbBaja";
            cmbBaja.Size = new Size(94, 23);
            cmbBaja.TabIndex = 6;
            cmbBaja.SelectedIndexChanged += cmbBaja_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(389, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 19);
            label2.TabIndex = 7;
            label2.Text = "Dar de baja por:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(641, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 42);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 234);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 8;
            label1.Text = "Saldo";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Green;
            lblSaldo.Location = new Point(39, 265);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 17);
            lblSaldo.TabIndex = 9;
            lblSaldo.Text = "$ pesos";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.LightGreen;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.ForeColor = SystemColors.ControlText;
            btnCargar.Location = new Point(270, 234);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(103, 48);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Carga virtual";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // FormSubePasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(689, 310);
            ControlBox = false;
            Controls.Add(btnCargar);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(cmbBaja);
            Controls.Add(lblName);
            Controls.Add(lblTarjeta);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSubePasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSubePasajero";
            Load += FormSubePasajero_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTarjeta;
        private Label lblName;
        private ComboBox cmbBaja;
        private Label label2;
        private Button btnSalir;
        private Label label1;
        private Label lblSaldo;
        private Button btnCargar;
    }
}