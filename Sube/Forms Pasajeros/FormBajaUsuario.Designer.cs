namespace Sube
{
    partial class FormBajaUsuario
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
            lblMensaje = new Label();
            btnContinuar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.ControlDarkDark;
            lblMensaje.Location = new Point(12, 25);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(70, 17);
            lblMensaje.TabIndex = 18;
            lblMensaje.Text = "Mensaje";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.LightBlue;
            btnContinuar.Cursor = Cursors.Hand;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.Location = new Point(459, 146);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(118, 41);
            btnContinuar.TabIndex = 19;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(312, 146);
            button2.Name = "button2";
            button2.Size = new Size(118, 41);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormBajaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(589, 199);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(btnContinuar);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBajaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBajaUsuario";
            Load += FormBajaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnContinuar;
        private Button button2;
    }
}