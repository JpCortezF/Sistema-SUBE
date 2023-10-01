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
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnFem = new Button();
            btnX = new Button();
            btnMas = new Button();
            lblClave = new Label();
            lblGenero = new Label();
            btnMostrarPass = new Button();
            lblRegistro = new Label();
            btnIngresar = new Button();
            label6 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblErrorDni = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            cmbDni = new ComboBox();
            pictureBox1 = new PictureBox();
            lblMensaje = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point);
            iNICIOToolStripMenuItem.ForeColor = Color.Black;
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(102, 35);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(781, 39);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 14);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 0;
            label1.Text = "* Tipo de documento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnFem);
            groupBox1.Controls.Add(btnX);
            groupBox1.Controls.Add(btnMas);
            groupBox1.Controls.Add(lblClave);
            groupBox1.Controls.Add(lblGenero);
            groupBox1.Controls.Add(btnMostrarPass);
            groupBox1.Controls.Add(lblRegistro);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblErrorDni);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbDni);
            groupBox1.Location = new Point(160, 173);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 414);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // btnFem
            // 
            btnFem.Cursor = Cursors.Hand;
            btnFem.FlatStyle = FlatStyle.Flat;
            btnFem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFem.Location = new Point(178, 184);
            btnFem.Name = "btnFem";
            btnFem.Size = new Size(106, 28);
            btnFem.TabIndex = 23;
            btnFem.Text = "Femenino";
            btnFem.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.Cursor = Cursors.Hand;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnX.Location = new Point(284, 184);
            btnX.Name = "btnX";
            btnX.Size = new Size(106, 28);
            btnX.TabIndex = 22;
            btnX.Text = "x";
            btnX.UseVisualStyleBackColor = true;
            // 
            // btnMas
            // 
            btnMas.Cursor = Cursors.Hand;
            btnMas.FlatStyle = FlatStyle.Flat;
            btnMas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMas.Location = new Point(75, 184);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(106, 28);
            btnMas.TabIndex = 21;
            btnMas.Text = "Masculino";
            btnMas.UseVisualStyleBackColor = true;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.DarkRed;
            lblClave.Location = new Point(75, 303);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(63, 16);
            lblClave.TabIndex = 19;
            lblClave.Text = "MsjClave";
            lblClave.Visible = false;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.DarkRed;
            lblGenero.Location = new Point(74, 217);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(73, 16);
            lblGenero.TabIndex = 18;
            lblGenero.Text = "MsjGenero";
            lblGenero.Visible = false;
            // 
            // btnMostrarPass
            // 
            btnMostrarPass.BackgroundImage = (Image)resources.GetObject("btnMostrarPass.BackgroundImage");
            btnMostrarPass.BackgroundImageLayout = ImageLayout.Zoom;
            btnMostrarPass.Location = new Point(337, 274);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(53, 27);
            btnMostrarPass.TabIndex = 14;
            btnMostrarPass.UseVisualStyleBackColor = true;
            btnMostrarPass.Click += btnMostrarPass_Click_1;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Cursor = Cursors.Hand;
            lblRegistro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistro.ForeColor = Color.LimeGreen;
            lblRegistro.Location = new Point(178, 363);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(121, 17);
            lblRegistro.TabIndex = 17;
            lblRegistro.Text = "ó Registrate ahora";
            lblRegistro.Click += lblRegistro_Click_1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(74, 352);
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
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(74, 303);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 16;
            label6.Text = "Olvidé mi clave";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(74, 274);
            txtPass.MaxLength = 4;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(267, 26);
            txtPass.TabIndex = 13;
            txtPass.TextChanged += txtPass_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 252);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 12;
            label4.Text = "* Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 163);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 7;
            label3.Text = "* Genero";
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorDni.ForeColor = Color.DarkRed;
            lblErrorDni.Location = new Point(75, 135);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(57, 16);
            lblErrorDni.TabIndex = 6;
            lblErrorDni.Text = "MsjError";
            lblErrorDni.Visible = false;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(74, 106);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(316, 26);
            txtDni.TabIndex = 5;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 84);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 4;
            label2.Text = "* N° de documento";
            // 
            // cmbDni
            // 
            cmbDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDni.FormattingEnabled = true;
            cmbDni.Location = new Point(74, 36);
            cmbDni.Name = "cmbDni";
            cmbDni.Size = new Size(316, 28);
            cmbDni.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fondoIngreso;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 124);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.Control;
            lblMensaje.Location = new Point(12, 56);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(105, 29);
            lblMensaje.TabIndex = 11;
            lblMensaje.Text = "Mensaje";
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 623);
            ControlBox = false;
            Controls.Add(lblMensaje);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIngreso";
            Load += FormIngreso_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnFem;
        private Button btnX;
        private Button btnMas;
        private Label lblClave;
        private Label lblGenero;
        private Button btnMostrarPass;
        private Label lblRegistro;
        private Button btnIngresar;
        private Label label6;
        private TextBox txtPass;
        private Label label4;
        private Label label3;
        private Label lblErrorDni;
        private TextBox txtDni;
        private Label label2;
        private ComboBox cmbDni;
        private PictureBox pictureBox1;
        private Label lblMensaje;
    }
}