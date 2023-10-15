namespace Sube
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(31, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(71, 22);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Titulo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Location = new Point(31, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 130);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TomarTransporte
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 234);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TomarTransporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TomarTransporte";
            Load += TomarTransporte_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}