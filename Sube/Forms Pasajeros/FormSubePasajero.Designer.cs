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
            lbl0to3Km = new Label();
            lbl3to6Km = new Label();
            lbl6to12km = new Label();
            lbl12to27km = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSubte = new Label();
            lblTren = new Label();
            label5 = new Label();
            lblSubsidio = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            lblTarjeta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarjeta.ForeColor = Color.Black;
            lblTarjeta.Location = new Point(43, 159);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(185, 24);
            lblTarjeta.TabIndex = 4;
            lblTarjeta.Text = "Card Number 6061";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(43, 196);
            lblName.Name = "lblName";
            lblName.Size = new Size(142, 23);
            lblName.TabIndex = 5;
            lblName.Text = "Passenger name";
            // 
            // lblTransportes
            // 
            lblTransportes.AutoSize = true;
            lblTransportes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransportes.Location = new Point(466, 52);
            lblTransportes.Name = "lblTransportes";
            lblTransportes.Size = new Size(127, 20);
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
            lblSaldo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Green;
            lblSaldo.Location = new Point(22, 374);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(72, 20);
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
            lblTarifa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarifa.ForeColor = Color.CadetBlue;
            lblTarifa.Location = new Point(655, 384);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(155, 20);
            lblTarifa.TabIndex = 11;
            lblTarifa.Text = "Acceder tarifa --->";
            lblTarifa.Click += lblTarifa_Click;
            // 
            // lblActualTarifa
            // 
            lblActualTarifa.AutoSize = true;
            lblActualTarifa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActualTarifa.Location = new Point(596, 344);
            lblActualTarifa.Name = "lblActualTarifa";
            lblActualTarifa.Size = new Size(74, 20);
            lblActualTarifa.TabIndex = 12;
            lblActualTarifa.Text = "Mi tarifa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(482, 88);
            label2.Name = "label2";
            label2.Size = new Size(135, 18);
            label2.TabIndex = 13;
            label2.Text = "Boleto colectivo:";
            // 
            // lbl0to3Km
            // 
            lbl0to3Km.AutoSize = true;
            lbl0to3Km.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl0to3Km.Location = new Point(482, 116);
            lbl0to3Km.Name = "lbl0to3Km";
            lbl0to3Km.Size = new Size(15, 16);
            lbl0to3Km.TabIndex = 14;
            lbl0to3Km.Text = "0";
            // 
            // lbl3to6Km
            // 
            lbl3to6Km.AutoSize = true;
            lbl3to6Km.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3to6Km.Location = new Point(482, 149);
            lbl3to6Km.Name = "lbl3to6Km";
            lbl3to6Km.Size = new Size(15, 16);
            lbl3to6Km.TabIndex = 15;
            lbl3to6Km.Text = "0";
            // 
            // lbl6to12km
            // 
            lbl6to12km.AutoSize = true;
            lbl6to12km.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl6to12km.Location = new Point(482, 178);
            lbl6to12km.Name = "lbl6to12km";
            lbl6to12km.Size = new Size(15, 16);
            lbl6to12km.TabIndex = 16;
            lbl6to12km.Text = "0";
            // 
            // lbl12to27km
            // 
            lbl12to27km.AutoSize = true;
            lbl12to27km.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl12to27km.Location = new Point(482, 212);
            lbl12to27km.Name = "lbl12to27km";
            lbl12to27km.Size = new Size(15, 16);
            lbl12to27km.TabIndex = 17;
            lbl12to27km.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(676, 88);
            label3.Name = "label3";
            label3.Size = new Size(117, 18);
            label3.TabIndex = 18;
            label3.Text = "Boleto subtes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(676, 147);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 19;
            label4.Text = "Boleto tren:";
            // 
            // lblSubte
            // 
            lblSubte.AutoSize = true;
            lblSubte.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubte.Location = new Point(676, 116);
            lblSubte.Name = "lblSubte";
            lblSubte.Size = new Size(15, 16);
            lblSubte.TabIndex = 20;
            lblSubte.Text = "0";
            // 
            // lblTren
            // 
            lblTren.AutoSize = true;
            lblTren.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTren.Location = new Point(676, 178);
            lblTren.Name = "lblTren";
            lblTren.Size = new Size(15, 16);
            lblTren.TabIndex = 21;
            lblTren.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(676, 206);
            label5.Name = "label5";
            label5.Size = new Size(157, 18);
            label5.TabIndex = 22;
            label5.Text = "Boleto sin subsidio:";
            // 
            // lblSubsidio
            // 
            lblSubsidio.AutoSize = true;
            lblSubsidio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubsidio.Location = new Point(676, 240);
            lblSubsidio.Name = "lblSubsidio";
            lblSubsidio.Size = new Size(15, 16);
            lblSubsidio.TabIndex = 23;
            lblSubsidio.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SubeGold;
            pictureBox2.Location = new Point(12, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 233);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // FormSubePasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(900, 430);
            ControlBox = false;
            Controls.Add(lblName);
            Controls.Add(lblTarjeta);
            Controls.Add(pictureBox2);
            Controls.Add(lblSubsidio);
            Controls.Add(label5);
            Controls.Add(lblTren);
            Controls.Add(lblSubte);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl12to27km);
            Controls.Add(lbl6to12km);
            Controls.Add(lbl3to6Km);
            Controls.Add(lbl0to3Km);
            Controls.Add(label2);
            Controls.Add(lblActualTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(btnCargar);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(lblTransportes);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSubePasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSubePasajero";
            FormClosed += FormSubePasajero_FormClosed;
            Load += FormSubePasajero_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTarjeta;
        private Label lblName;
        private Label lblTransportes;
        private Button btnSalir;
        private Label label1;
        private Label lblSaldo;
        private Button btnCargar;
        private Label lblTarifa;
        private Label lblActualTarifa;
        private Label label2;
        private Label lbl0to3Km;
        private Label lbl3to6Km;
        private Label lbl6to12km;
        private Label lbl12to27km;
        private Label label3;
        private Label label4;
        private Label lblSubte;
        private Label lblTren;
        private Label label5;
        private Label lblSubsidio;
        private PictureBox pictureBox2;
    }
}