namespace Sube
{
    partial class FormIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnHardcoce = new Button();
            lblClave = new Label();
            btnMostrarPass = new Button();
            lblRegistro = new Label();
            btnIngresar = new Button();
            lblOlvideClave = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            lblErrorDni = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            cmbDni = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 58);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 0;
            label1.Text = "* Tipo de documento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnHardcoce);
            groupBox1.Controls.Add(lblClave);
            groupBox1.Controls.Add(btnMostrarPass);
            groupBox1.Controls.Add(lblRegistro);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(lblOlvideClave);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblErrorDni);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbDni);
            groupBox1.Location = new Point(403, -1);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 390);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // btnHardcoce
            // 
            btnHardcoce.BackColor = Color.IndianRed;
            btnHardcoce.Cursor = Cursors.Hand;
            btnHardcoce.FlatStyle = FlatStyle.Flat;
            btnHardcoce.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHardcoce.ForeColor = SystemColors.Control;
            btnHardcoce.Location = new Point(67, 306);
            btnHardcoce.Name = "btnHardcoce";
            btnHardcoce.Size = new Size(97, 39);
            btnHardcoce.TabIndex = 20;
            btnHardcoce.Text = "Hardcode";
            btnHardcoce.UseVisualStyleBackColor = false;
            btnHardcoce.Click += btnHardcoce_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.DarkRed;
            lblClave.Location = new Point(68, 254);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(63, 16);
            lblClave.TabIndex = 19;
            lblClave.Text = "MsjClave";
            lblClave.Visible = false;
            // 
            // btnMostrarPass
            // 
            btnMostrarPass.BackgroundImage = (Image)resources.GetObject("btnMostrarPass.BackgroundImage");
            btnMostrarPass.BackgroundImageLayout = ImageLayout.Zoom;
            btnMostrarPass.Cursor = Cursors.Hand;
            btnMostrarPass.Location = new Point(330, 225);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 4;
            btnMostrarPass.UseVisualStyleBackColor = true;
            btnMostrarPass.Click += btnMostrarPass_Click_1;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Cursor = Cursors.Hand;
            lblRegistro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistro.ForeColor = Color.LimeGreen;
            lblRegistro.Location = new Point(274, 317);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(121, 17);
            lblRegistro.TabIndex = 6;
            lblRegistro.Text = "ó Registrate ahora";
            lblRegistro.Click += lblRegistro_Click_1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(170, 306);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(89, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblOlvideClave
            // 
            lblOlvideClave.AutoSize = true;
            lblOlvideClave.Cursor = Cursors.Hand;
            lblOlvideClave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblOlvideClave.ForeColor = Color.DodgerBlue;
            lblOlvideClave.Location = new Point(67, 254);
            lblOlvideClave.Name = "lblOlvideClave";
            lblOlvideClave.Size = new Size(89, 15);
            lblOlvideClave.TabIndex = 5;
            lblOlvideClave.Text = "Olvidé mi clave";
            lblOlvideClave.Click += lblOlvideClave_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(67, 225);
            txtPass.MaxLength = 4;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(267, 26);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 203);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 12;
            label4.Text = "* Clave";
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.DarkRed;
            lblErrorDni.Location = new Point(68, 179);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(57, 16);
            lblErrorDni.TabIndex = 6;
            lblErrorDni.Text = "MsjError";
            lblErrorDni.Visible = false;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(67, 150);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(316, 26);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 128);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 4;
            label2.Text = "* N° de documento";
            // 
            // cmbDni
            // 
            cmbDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDni.FormattingEnabled = true;
            cmbDni.Location = new Point(67, 80);
            cmbDni.Name = "cmbDni";
            cmbDni.Size = new Size(316, 28);
            cmbDni.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LigthMode;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 389);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIngreso";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIngreso";
            Load += FormIngreso_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Label lblClave;
        private Button btnMostrarPass;
        private Label lblRegistro;
        private Button btnIngresar;
        private Label lblOlvideClave;
        private TextBox txtPass;
        private Label label4;
        private Label lblErrorDni;
        private TextBox txtDni;
        private Label label2;
        private ComboBox cmbDni;
        private Button btnHardcoce;
        private PictureBox pictureBox1;
    }
}