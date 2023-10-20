namespace Sube
{
    partial class FormCargaCompleta
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
            panel1 = new Panel();
            lblContinuar = new Label();
            lblTitulo = new Label();
            label2 = new Label();
            lblSaldo = new Label();
            lblAcreditado = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblContinuar);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 36);
            panel1.TabIndex = 12;
            // 
            // lblContinuar
            // 
            lblContinuar.AutoSize = true;
            lblContinuar.Cursor = Cursors.Hand;
            lblContinuar.Font = new Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContinuar.Location = new Point(776, 2);
            lblContinuar.Name = "lblContinuar";
            lblContinuar.Size = new Size(58, 33);
            lblContinuar.TabIndex = 17;
            lblContinuar.Text = "--->";
            lblContinuar.Click += lblContinuar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(314, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 29);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Saldo acreditado!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(631, 212);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 14;
            label2.Text = "Saldo actual";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Sans", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.SeaGreen;
            lblSaldo.Location = new Point(596, 147);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(158, 42);
            lblSaldo.TabIndex = 13;
            lblSaldo.Text = "$ saldo";
            // 
            // lblAcreditado
            // 
            lblAcreditado.AutoSize = true;
            lblAcreditado.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcreditado.ForeColor = SystemColors.ControlDark;
            lblAcreditado.Location = new Point(582, 252);
            lblAcreditado.Name = "lblAcreditado";
            lblAcreditado.Size = new Size(141, 17);
            lblAcreditado.TabIndex = 15;
            lblAcreditado.Text = "Saldo acreditado";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(606, 330);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(139, 18);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Volver al INICIO";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.proyectoSube;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(47, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 194);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormCargaCompleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 438);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(lblAcreditado);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lblSaldo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCargaCompleta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCargaCompleta";
            Load += FormCargaCompleta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblTitulo;
        private Label label2;
        private Label lblSaldo;
        private Label lblAcreditado;
        private Label lblContinuar;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}