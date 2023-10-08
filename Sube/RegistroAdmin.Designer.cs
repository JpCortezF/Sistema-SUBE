namespace Sube
{
    partial class RegistroAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAdmin));
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            lblClave = new Label();
            btnMostrarPass = new Button();
            btnIngresar = new Button();
            label6 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            lblErrorDni = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblClave);
            groupBox1.Controls.Add(btnMostrarPass);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblErrorDni);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(163, 45);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 405);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(77, 312);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 24;
            label1.Text = "MsjClave";
            label1.Visible = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(339, 283);
            button1.Name = "button1";
            button1.Size = new Size(53, 27);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(76, 312);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 22;
            label3.Text = "Olvidé mi clave";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(76, 283);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '•';
            textBox1.Size = new Size(267, 26);
            textBox1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(76, 261);
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
            lblClave.Location = new Point(76, 231);
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
            btnMostrarPass.Location = new Point(338, 202);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 4;
            btnMostrarPass.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(166, 344);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(128, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Crear cuenta";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(75, 231);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Olvidé mi clave";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(75, 202);
            txtPass.MaxLength = 4;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(267, 26);
            txtPass.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(75, 180);
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
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(74, 55);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(316, 26);
            txtDni.TabIndex = 2;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(75, 159);
            label7.Name = "label7";
            label7.Size = new Size(57, 16);
            label7.TabIndex = 27;
            label7.Text = "MsjError";
            label7.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(74, 130);
            textBox2.MaxLength = 8;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 26);
            textBox2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(74, 108);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 26;
            label8.Text = "* DNI";
            // 
            // RegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(groupBox1);
            Name = "RegistroAdmin";
            Text = "RegistroAdmin";
            Controls.SetChildIndex(groupBox1, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private Label lblClave;
        private Button btnMostrarPass;
        private Button btnIngresar;
        private Label label6;
        private TextBox txtPass;
        private Label label4;
        private Label lblErrorDni;
        private TextBox txtDni;
        private Label label2;
    }
}