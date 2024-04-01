namespace Sube.Forms_Pasajeros
{
    partial class FormCompraOnline
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
            btnIngresar = new Button();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbDni = new ComboBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(516, 291);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(201, 49);
            btnIngresar.TabIndex = 20;
            btnIngresar.Text = "Compra ONLINE";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(459, 149);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(316, 26);
            txtDni.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 127);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 26;
            label2.Text = "* N° de documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(459, 57);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 21;
            label1.Text = "* Tipo de documento";
            // 
            // cmbDni
            // 
            cmbDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDni.FormattingEnabled = true;
            cmbDni.Location = new Point(459, 79);
            cmbDni.Name = "cmbDni";
            cmbDni.Size = new Size(316, 28);
            cmbDni.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.brigdeTrainGif;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(415, 390);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // FormCompraOnline
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 389);
            ControlBox = false;
            Controls.Add(btnIngresar);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDni);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCompraOnline";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCompraOnline";
            Load += FormCompraOnline_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private TextBox txtDni;
        private Label label2;
        private Label label1;
        private ComboBox cmbDni;
        private PictureBox pictureBox2;
    }
}