namespace Sube
{
    partial class VentanaPassword
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
            label5 = new Label();
            txtCorreo = new TextBox();
            lblMensaje = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 76);
            label5.Name = "label5";
            label5.Size = new Size(145, 16);
            label5.TabIndex = 32;
            label5.Text = "* Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(12, 109);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(295, 26);
            txtCorreo.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;
            lblMensaje.Location = new Point(13, 26);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(62, 15);
            lblMensaje.TabIndex = 33;
            lblMensaje.Text = "Mensaje";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ControlDark;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(12, 176);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 34);
            btnAceptar.TabIndex = 34;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // VentanaPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 236);
            Controls.Add(btnAceptar);
            Controls.Add(lblMensaje);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VentanaPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar Clave!";
            Load += VentanaPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtCorreo;
        private Label lblMensaje;
        private Button btnAceptar;
    }
}