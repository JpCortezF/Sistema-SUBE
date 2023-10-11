namespace Sube
{
    partial class FormEmergente
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
            btnSi = new Button();
            btnNo = new Button();
            lblSalir = new Label();
            SuspendLayout();
            // 
            // btnSi
            // 
            btnSi.Cursor = Cursors.Hand;
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Location = new Point(47, 117);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(101, 31);
            btnSi.TabIndex = 0;
            btnSi.Text = "Sí";
            btnSi.UseVisualStyleBackColor = true;
            btnSi.Click += btnSi_Click;
            // 
            // btnNo
            // 
            btnNo.Cursor = Cursors.Hand;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Location = new Point(175, 117);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(101, 31);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalir.Location = new Point(47, 54);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(97, 18);
            lblSalir.TabIndex = 2;
            lblSalir.Text = "Mensaje Salir";
            // 
            // FormEmergente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(304, 160);
            Controls.Add(lblSalir);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormEmergente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salir";
            Load += FormEmergente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSi;
        private Button btnNo;
        private Label lblSalir;
    }
}