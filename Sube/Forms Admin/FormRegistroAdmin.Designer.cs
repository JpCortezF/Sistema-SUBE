namespace Sube
{
    partial class FormRegistroAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroAdmin));
            groupBox1 = new GroupBox();
            txtLastName = new TextBox();
            label12 = new Label();
            txtName = new TextBox();
            label10 = new Label();
            lblDNI = new Label();
            txtDNI = new TextBox();
            label8 = new Label();
            label1 = new Label();
            txtRepeatPassword = new TextBox();
            label5 = new Label();
            lblClave = new Label();
            btnMostrarPass = new Button();
            btnIngresar = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRepeatPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblClave);
            groupBox1.Controls.Add(btnMostrarPass);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 7);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(682, 307);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(12, 188);
            txtLastName.MaxLength = 0;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(316, 26);
            txtLastName.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 166);
            label12.Name = "label12";
            label12.Size = new Size(82, 19);
            label12.TabIndex = 32;
            label12.Text = "* Apellido";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(12, 115);
            txtName.MaxLength = 0;
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 26);
            txtName.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 93);
            label10.Name = "label10";
            label10.Size = new Size(78, 19);
            label10.TabIndex = 29;
            label10.Text = "* Nombre";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.DarkRed;
            lblDNI.Location = new Point(353, 71);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(57, 16);
            lblDNI.TabIndex = 27;
            lblDNI.Text = "MsjError";
            lblDNI.Visible = false;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(353, 42);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(316, 26);
            txtDNI.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(353, 20);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 26;
            label8.Text = "* DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(354, 217);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 24;
            label1.Text = "MsjClave";
            label1.Visible = false;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepeatPassword.Location = new Point(353, 188);
            txtRepeatPassword.MaxLength = 0;
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.PasswordChar = '•';
            txtRepeatPassword.Size = new Size(316, 26);
            txtRepeatPassword.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(353, 166);
            label5.Name = "label5";
            label5.Size = new Size(162, 19);
            label5.TabIndex = 23;
            label5.Text = "* Repetir contraseña";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.DarkRed;
            lblClave.Location = new Point(354, 142);
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
            btnMostrarPass.Location = new Point(616, 113);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 4;
            btnMostrarPass.UseVisualStyleBackColor = true;
            btnMostrarPass.Click += btnMostrarPass_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(270, 251);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(131, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Crear cuenta";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(353, 113);
            txtPassword.MaxLength = 0;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(267, 26);
            txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(353, 91);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 12;
            label4.Text = "* Contraseña";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.DarkRed;
            lblEmail.Location = new Point(13, 71);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 16);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "MsjError";
            lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(12, 42);
            txtEmail.MaxLength = 0;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 26);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 4;
            label2.Text = "* Email";
            // 
            // FormRegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nubes1;
            ClientSize = new Size(702, 326);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistroAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistroAdmin";
            Load += FormRegistroAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label label8;
        private Label label1;
        private TextBox txtRepeatPassword;
        private Label label5;
        private Label lblClave;
        private Button btnMostrarPass;
        private Button btnIngresar;
        private TextBox txtPassword;
        private Label label4;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtLastName;
        private Label label12;
        private TextBox txtName;
        private Label label10;
    }
}