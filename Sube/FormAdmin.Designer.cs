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
            menuStrip1 = new MenuStrip();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            lblClave = new Label();
            btnMostrarPass = new Button();
            lblRegistro = new Label();
            btnIngresar = new Button();
            label6 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            lblErrorDni = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSkyBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new Size(84, 28);
            hOMEToolStripMenuItem.Text = "HOME";
            hOMEToolStripMenuItem.Click += hOMEToolStripMenuItem_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblClave);
            groupBox1.Controls.Add(btnMostrarPass);
            groupBox1.Controls.Add(lblRegistro);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblErrorDni);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(159, 60);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 361);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(77, 251);
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
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(339, 222);
            button1.Name = "button1";
            button1.Size = new Size(53, 27);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(76, 222);
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
            label5.Location = new Point(76, 200);
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
            lblClave.Location = new Point(76, 170);
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
            btnMostrarPass.Location = new Point(338, 141);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 4;
            btnMostrarPass.UseVisualStyleBackColor = true;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Cursor = Cursors.Hand;
            lblRegistro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistro.ForeColor = Color.LimeGreen;
            lblRegistro.Location = new Point(231, 305);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(76, 17);
            lblRegistro.TabIndex = 6;
            lblRegistro.Text = "Registrarse";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(125, 294);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(89, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(75, 170);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Olvidé mi clave";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(75, 141);
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
            label4.Location = new Point(75, 119);
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
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 471);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private GroupBox groupBox1;
        private Label lblClave;
        private Button btnMostrarPass;
        private Label lblRegistro;
        private Button btnIngresar;
        private Label label6;
        private TextBox txtPass;
        private Label label4;
        private Label lblErrorDni;
        private TextBox txtDni;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
    }
}