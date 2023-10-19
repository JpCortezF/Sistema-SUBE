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
            lblTransportes = new Label();
            btnSalir = new Button();
            label1 = new Label();
            lblSaldo = new Label();
            btnCargar = new Button();
            lblTarifa = new Label();
            lblActualTarifa = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.proyectoSube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 233);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.BackColor = Color.Transparent;
            lblTarjeta.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarjeta.ForeColor = Color.Black;
            lblTarjeta.Location = new Point(39, 169);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(198, 22);
            lblTarjeta.TabIndex = 4;
            lblTarjeta.Text = "Card Number 6061";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(39, 206);
            lblName.Name = "lblName";
            lblName.Size = new Size(142, 23);
            lblName.TabIndex = 5;
            lblName.Text = "Passenger name";
            // 
            // lblTransportes
            // 
            lblTransportes.AutoSize = true;
            lblTransportes.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransportes.Location = new Point(443, 51);
            lblTransportes.Name = "lblTransportes";
            lblTransportes.Size = new Size(122, 18);
            lblTransportes.TabIndex = 7;
            lblTransportes.Text = "Informacion ---";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(868, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(32, 28);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 342);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 8;
            label1.Text = "Saldo";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Green;
            lblSaldo.Location = new Point(22, 374);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(72, 18);
            lblSaldo.TabIndex = 9;
            lblSaldo.Text = "$ pesos";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.LightGreen;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.ForeColor = SystemColors.ControlText;
            btnCargar.Location = new Point(269, 344);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(148, 48);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Carga virtual";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Cursor = Cursors.Hand;
            lblTarifa.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarifa.ForeColor = Color.CadetBlue;
            lblTarifa.Location = new Point(655, 384);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(148, 18);
            lblTarifa.TabIndex = 11;
            lblTarifa.Text = "Acceder tarifa --->";
            lblTarifa.Click += lblTarifa_Click;
            // 
            // lblActualTarifa
            // 
            lblActualTarifa.AutoSize = true;
            lblActualTarifa.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActualTarifa.Location = new Point(596, 344);
            lblActualTarifa.Name = "lblActualTarifa";
            lblActualTarifa.Size = new Size(76, 18);
            lblActualTarifa.TabIndex = 12;
            lblActualTarifa.Text = "Mi tarifa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 87);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 13;
            label2.Text = "Boleto colectivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(459, 117);
            label3.Name = "label3";
            label3.Size = new Size(182, 15);
            label3.TabIndex = 14;
            label3.Text = "Min: $52, 96 | Max: $68, 09";
            // 
            // FormSubePasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(900, 430);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblActualTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(btnCargar);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(lblTransportes);
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
        private Label lblTransportes;
        private Button btnSalir;
        private Label label1;
        private Label lblSaldo;
        private Button btnCargar;
        private Label lblTarifa;
        private Label lblActualTarifa;
        private Label label2;
        private Label label3;
    }
}