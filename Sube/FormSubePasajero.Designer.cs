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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblTarjeta = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
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
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 246);
            button1.Name = "button1";
            button1.Size = new Size(108, 33);
            button1.TabIndex = 1;
            button1.Text = "Viajes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(265, 246);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 2;
            button2.Text = "Viajes";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(138, 246);
            button3.Name = "button3";
            button3.Size = new Size(108, 33);
            button3.TabIndex = 3;
            button3.Text = "turn around card";
            button3.UseVisualStyleBackColor = false;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarjeta.Location = new Point(39, 120);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(158, 23);
            lblTarjeta.TabIndex = 4;
            lblTarjeta.Text = "Card Number 6061";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 173);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(415, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // FormSubePasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 310);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lblTarjeta);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSubePasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSubePasajero";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblTarjeta;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
    }
}