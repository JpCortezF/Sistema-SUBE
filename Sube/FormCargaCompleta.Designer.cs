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
            btnSalir = new Button();
            panel1 = new Panel();
            lblTitulo = new Label();
            label2 = new Label();
            lblSaldo = new Label();
            lblAcreditado = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(340, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 42);
            btnSalir.TabIndex = 0;
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
            panel1.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(80, 9);
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
            label2.Location = new Point(153, 176);
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
            lblSaldo.Location = new Point(118, 111);
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
            lblAcreditado.Location = new Point(104, 216);
            lblAcreditado.Name = "lblAcreditado";
            lblAcreditado.Size = new Size(141, 17);
            lblAcreditado.TabIndex = 15;
            lblAcreditado.Text = "Saldo acreditado";
            // 
            // FormCargaCompleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 321);
            ControlBox = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Panel panel1;
        private Label lblTitulo;
        private Label label2;
        private Label lblSaldo;
        private Label lblAcreditado;
    }
}