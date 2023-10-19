﻿namespace Sube
{
    partial class TomarTransporte
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
            comboBox1 = new ComboBox();
            txtKilometros = new TextBox();
            lblKilometres = new Label();
            btnViajar = new Button();
            txtLinea = new TextBox();
            lblLinea = new Label();
            label1 = new Label();
            grpTransporte = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            grpTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(283, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(82, 27);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Titulo";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(552, 60);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.PlaceholderText = "Ejemplo: 7";
            txtKilometros.Size = new Size(100, 23);
            txtKilometros.TabIndex = 3;
            txtKilometros.TextChanged += txtKilometros_TextChanged;
            // 
            // lblKilometres
            // 
            lblKilometres.AutoSize = true;
            lblKilometres.Location = new Point(484, 28);
            lblKilometres.Name = "lblKilometres";
            lblKilometres.Size = new Size(82, 15);
            lblKilometres.TabIndex = 7;
            lblKilometres.Text = "Kilometros";
            // 
            // btnViajar
            // 
            btnViajar.BackColor = Color.MediumAquamarine;
            btnViajar.Cursor = Cursors.Hand;
            btnViajar.FlatStyle = FlatStyle.Flat;
            btnViajar.Location = new Point(634, 370);
            btnViajar.Name = "btnViajar";
            btnViajar.Size = new Size(101, 29);
            btnViajar.TabIndex = 0;
            btnViajar.Text = "VIAJAR";
            btnViajar.UseVisualStyleBackColor = false;
            btnViajar.Click += btnViajar_Click;
            // 
            // txtLinea
            // 
            txtLinea.Location = new Point(271, 60);
            txtLinea.Name = "txtLinea";
            txtLinea.PlaceholderText = "Subte A, Linea 85, Roca...";
            txtLinea.Size = new Size(195, 23);
            txtLinea.TabIndex = 2;
            // 
            // lblLinea
            // 
            lblLinea.AutoSize = true;
            lblLinea.Location = new Point(292, 28);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(146, 15);
            lblLinea.TabIndex = 10;
            lblLinea.Text = "Linea del transporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 11;
            label1.Text = "Seleccioná tu transporte";
            // 
            // grpTransporte
            // 
            grpTransporte.Controls.Add(label1);
            grpTransporte.Controls.Add(txtKilometros);
            grpTransporte.Controls.Add(comboBox1);
            grpTransporte.Controls.Add(lblKilometres);
            grpTransporte.Controls.Add(lblLinea);
            grpTransporte.Controls.Add(txtLinea);
            grpTransporte.Location = new Point(12, 57);
            grpTransporte.Name = "grpTransporte";
            grpTransporte.Size = new Size(723, 156);
            grpTransporte.TabIndex = 12;
            grpTransporte.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.busGif;
            pictureBox1.Location = new Point(218, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.subwayGif;
            pictureBox2.Location = new Point(173, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(381, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.trainGif;
            pictureBox3.Location = new Point(218, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(292, 169);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // TomarTransporte
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(767, 411);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(grpTransporte);
            Controls.Add(btnViajar);
            Controls.Add(lblTitulo);
            Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "TomarTransporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viajá con tu SUBE";
            Load += TomarTransporte_Load;
            grpTransporte.ResumeLayout(false);
            grpTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private ComboBox comboBox1;
        private TextBox txtKilometros;
        private Label lblKilometres;
        private Button btnViajar;
        private TextBox txtLinea;
        private Label lblLinea;
        private Label label1;
        private GroupBox grpTransporte;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}