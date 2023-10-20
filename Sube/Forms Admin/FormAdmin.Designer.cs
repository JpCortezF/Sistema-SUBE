namespace Sube
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            txtDni = new TextBox();
            label7 = new Label();
            label1 = new Label();
            txtRepeatPassword = new TextBox();
            label5 = new Label();
            lblClave = new Label();
            btnMostrarPass = new Button();
            lblRegistroAdmin = new Label();
            btnIngresar = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            lblErrorDni = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRepeatPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblClave);
            groupBox1.Controls.Add(btnMostrarPass);
            groupBox1.Controls.Add(lblRegistroAdmin);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblErrorDni);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 427);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(280, 361);
            button2.Name = "button2";
            button2.Size = new Size(112, 39);
            button2.TabIndex = 28;
            button2.Text = "Hardcode";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(75, 171);
            label3.Name = "label3";
            label3.Size = new Size(57, 16);
            label3.TabIndex = 27;
            label3.Text = "MsjError";
            label3.Visible = false;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(74, 142);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(316, 26);
            txtDni.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(74, 120);
            label7.Name = "label7";
            label7.Size = new Size(48, 19);
            label7.TabIndex = 26;
            label7.Text = "* DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(77, 329);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 24;
            label1.Text = "MsjClave";
            label1.Visible = false;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepeatPassword.Location = new Point(76, 300);
            txtRepeatPassword.MaxLength = 0;
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.PasswordChar = '•';
            txtRepeatPassword.Size = new Size(314, 26);
            txtRepeatPassword.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(76, 278);
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
            lblClave.Location = new Point(76, 248);
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
            btnMostrarPass.Location = new Point(338, 219);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 4;
            btnMostrarPass.UseVisualStyleBackColor = true;
            btnMostrarPass.Click += btnMostrarPass_Click;
            // 
            // lblRegistroAdmin
            // 
            lblRegistroAdmin.AutoSize = true;
            lblRegistroAdmin.Cursor = Cursors.Hand;
            lblRegistroAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroAdmin.ForeColor = Color.LimeGreen;
            lblRegistroAdmin.Location = new Point(188, 372);
            lblRegistroAdmin.Name = "lblRegistroAdmin";
            lblRegistroAdmin.Size = new Size(76, 17);
            lblRegistroAdmin.TabIndex = 6;
            lblRegistroAdmin.Text = "Registrarse";
            lblRegistroAdmin.Click += lblRegistroAdmin_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(77, 361);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(89, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(75, 248);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Olvidé mi clave";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(75, 219);
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
            label4.Location = new Point(75, 197);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 12;
            label4.Text = "* Contraseña";
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.DarkRed;
            lblErrorDni.Location = new Point(75, 84);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(57, 16);
            lblErrorDni.TabIndex = 6;
            lblErrorDni.Text = "MsjError";
            lblErrorDni.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(74, 55);
            txtEmail.MaxLength = 0;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 26);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 33);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 4;
            label2.Text = "* Email";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.nubes1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(490, 445);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label lblClave;
        private Button btnMostrarPass;
        private Label lblRegistroAdmin;
        private Button btnIngresar;
        private Label label6;
        private TextBox txtPassword;
        private Label label4;
        private Label lblErrorDni;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private TextBox txtRepeatPassword;
        private Label label5;
        private Label label3;
        private TextBox txtDni;
        private Label label7;
        private Button button2;
    }
}