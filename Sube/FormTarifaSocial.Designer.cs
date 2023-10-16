namespace Sube
{
    partial class FormTarifaSocial
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
            lblDirigido = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTramite = new Button();
            lblCosto = new Label();
            lblGratuito = new Label();
            button1 = new Button();
            lblDescuento = new Label();
            SuspendLayout();
            // 
            // lblDirigido
            // 
            lblDirigido.AutoSize = true;
            lblDirigido.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDirigido.Location = new Point(12, 47);
            lblDirigido.Name = "lblDirigido";
            lblDirigido.Size = new Size(86, 22);
            lblDirigido.TabIndex = 0;
            lblDirigido.Text = "A quien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 175);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 5;
            label4.Text = "label1";
            // 
            // btnTramite
            // 
            btnTramite.BackColor = Color.ForestGreen;
            btnTramite.Cursor = Cursors.Hand;
            btnTramite.FlatStyle = FlatStyle.Flat;
            btnTramite.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTramite.ForeColor = SystemColors.Control;
            btnTramite.Location = new Point(533, 263);
            btnTramite.Name = "btnTramite";
            btnTramite.Size = new Size(144, 35);
            btnTramite.TabIndex = 6;
            btnTramite.Text = "Iniciar trámite";
            btnTramite.UseVisualStyleBackColor = false;
            btnTramite.Click += btnTramite_Click;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCosto.Location = new Point(12, 223);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(68, 22);
            lblCosto.TabIndex = 7;
            lblCosto.Text = "Costo";
            // 
            // lblGratuito
            // 
            lblGratuito.AutoSize = true;
            lblGratuito.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGratuito.Location = new Point(12, 258);
            lblGratuito.Name = "lblGratuito";
            lblGratuito.Size = new Size(66, 17);
            lblGratuito.TabIndex = 8;
            lblGratuito.Text = "Gratuito";
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(659, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 26);
            button1.TabIndex = 9;
            button1.Text = " x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(12, 9);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(85, 17);
            lblDescuento.TabIndex = 10;
            lblDescuento.Text = "Descuento";
            // 
            // FormTarifaSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(689, 310);
            ControlBox = false;
            Controls.Add(lblDescuento);
            Controls.Add(button1);
            Controls.Add(lblGratuito);
            Controls.Add(lblCosto);
            Controls.Add(btnTramite);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDirigido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTarifaSocial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTarifaSocial";
            Load += FormTarifaSocial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDirigido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTramite;
        private Label lblCosto;
        private Label lblGratuito;
        private Button button1;
        private Label lblDescuento;
    }
}