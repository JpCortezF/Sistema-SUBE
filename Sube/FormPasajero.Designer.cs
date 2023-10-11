namespace Sube
{
    partial class FormPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasajero));
            label3 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnTitularidad = new Button();
            btnRegistrar = new Button();
            btnSalir = new Button();
            lblIngresar = new Label();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(126, 412);
            label3.Name = "label3";
            label3.Size = new Size(120, 16);
            label3.TabIndex = 32;
            label3.Text = "Comprala online";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(42, 374);
            button2.Name = "button2";
            button2.Size = new Size(277, 35);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 209);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(142, 340);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 30;
            label2.Text = "Registrala";
            // 
            // btnTitularidad
            // 
            btnTitularidad.BackColor = Color.LightSkyBlue;
            btnTitularidad.Cursor = Cursors.Hand;
            btnTitularidad.FlatStyle = FlatStyle.Flat;
            btnTitularidad.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTitularidad.ForeColor = Color.Black;
            btnTitularidad.Location = new Point(42, 474);
            btnTitularidad.Name = "btnTitularidad";
            btnTitularidad.Size = new Size(277, 35);
            btnTitularidad.TabIndex = 28;
            btnTitularidad.Text = "Consultá titularidad";
            btnTitularidad.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSkyBlue;
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(42, 302);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(277, 35);
            btnRegistrar.TabIndex = 25;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaptionText;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(42, 526);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(277, 37);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresar.ForeColor = Color.Gray;
            lblIngresar.Location = new Point(108, 275);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(138, 16);
            lblIngresar.TabIndex = 23;
            lblIngresar.Text = "Ingresa a tu cuenta";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(255, 128, 128);
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(42, 237);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(277, 35);
            btnIngresar.TabIndex = 22;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // FormPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 579);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnTitularidad);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSalir);
            Controls.Add(lblIngresar);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPasajero";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnTitularidad;
        private Button btnRegistrar;
        private Button btnSalir;
        private Label lblIngresar;
        private Button btnIngresar;
    }
}