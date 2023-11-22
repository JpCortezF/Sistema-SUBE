namespace Sube.Forms_Admin
{
    partial class FormAdminEstadoTramite
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
            btnAprobe = new Button();
            btnBajaTarjeta = new Button();
            cmbTarifa = new ComboBox();
            txtCredito = new TextBox();
            txtMail = new TextBox();
            txtApellido = new TextBox();
            txtNumTarjeta = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            lblBalance = new Label();
            lblTarifaSocial = new Label();
            lblTarjeta = new Label();
            lblUsuario = new Label();
            lblNumTarjeta = new Label();
            lblMail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDatos = new Label();
            btnDenegate = new Button();
            txtReclamo = new TextBox();
            SuspendLayout();
            // 
            // btnAprobe
            // 
            btnAprobe.BackColor = Color.LimeGreen;
            btnAprobe.FlatStyle = FlatStyle.Flat;
            btnAprobe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAprobe.ForeColor = SystemColors.Control;
            btnAprobe.Location = new Point(574, 336);
            btnAprobe.Name = "btnAprobe";
            btnAprobe.Size = new Size(157, 46);
            btnAprobe.TabIndex = 49;
            btnAprobe.Text = "Aprobar cambios";
            btnAprobe.UseVisualStyleBackColor = false;
            btnAprobe.Click += btnAprobe_Click;
            // 
            // btnBajaTarjeta
            // 
            btnBajaTarjeta.BackColor = Color.Firebrick;
            btnBajaTarjeta.FlatStyle = FlatStyle.Flat;
            btnBajaTarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaTarjeta.ForeColor = SystemColors.Control;
            btnBajaTarjeta.Location = new Point(323, 338);
            btnBajaTarjeta.Name = "btnBajaTarjeta";
            btnBajaTarjeta.Size = new Size(134, 46);
            btnBajaTarjeta.TabIndex = 48;
            btnBajaTarjeta.Text = "Baja Tarjeta";
            btnBajaTarjeta.UseVisualStyleBackColor = false;
            btnBajaTarjeta.Click += btnBajaTarjeta_Click;
            // 
            // cmbTarifa
            // 
            cmbTarifa.AutoCompleteMode = AutoCompleteMode.Append;
            cmbTarifa.Cursor = Cursors.Hand;
            cmbTarifa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTarifa.FormattingEnabled = true;
            cmbTarifa.Items.AddRange(new object[] { "DNI", "Nombre y Apellido", "N° de Tarjeta" });
            cmbTarifa.Location = new Point(297, 201);
            cmbTarifa.Name = "cmbTarifa";
            cmbTarifa.Size = new Size(190, 29);
            cmbTarifa.TabIndex = 46;
            // 
            // txtCredito
            // 
            txtCredito.BackColor = SystemColors.ControlLight;
            txtCredito.Enabled = false;
            txtCredito.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCredito.Location = new Point(297, 282);
            txtCredito.MaxLength = 8;
            txtCredito.Name = "txtCredito";
            txtCredito.Size = new Size(190, 29);
            txtCredito.TabIndex = 45;
            // 
            // txtMail
            // 
            txtMail.BackColor = SystemColors.ControlLight;
            txtMail.Enabled = false;
            txtMail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(47, 282);
            txtMail.MaxLength = 8;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(190, 29);
            txtMail.TabIndex = 44;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.ControlLight;
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(47, 201);
            txtApellido.MaxLength = 8;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 29);
            txtApellido.TabIndex = 43;
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.BackColor = SystemColors.ControlLight;
            txtNumTarjeta.Enabled = false;
            txtNumTarjeta.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumTarjeta.Location = new Point(297, 118);
            txtNumTarjeta.MaxLength = 8;
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(190, 29);
            txtNumTarjeta.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ControlLight;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(47, 118);
            txtNombre.MaxLength = 8;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 29);
            txtNombre.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(521, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 40;
            label1.Text = "Reclamo:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(297, 260);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(74, 19);
            lblBalance.TabIndex = 39;
            lblBalance.Text = "*Credito:";
            // 
            // lblTarifaSocial
            // 
            lblTarifaSocial.AutoSize = true;
            lblTarifaSocial.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarifaSocial.Location = new Point(297, 179);
            lblTarifaSocial.Name = "lblTarifaSocial";
            lblTarifaSocial.Size = new Size(112, 19);
            lblTarifaSocial.TabIndex = 38;
            lblTarifaSocial.Text = "*Tarifa Social:";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarjeta.Location = new Point(274, 59);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(86, 25);
            lblTarjeta.TabIndex = 37;
            lblTarjeta.Text = "Tarjeta:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(24, 59);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(95, 25);
            lblUsuario.TabIndex = 36;
            lblUsuario.Text = "Usuario:";
            // 
            // lblNumTarjeta
            // 
            lblNumTarjeta.AutoSize = true;
            lblNumTarjeta.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumTarjeta.Location = new Point(297, 96);
            lblNumTarjeta.Name = "lblNumTarjeta";
            lblNumTarjeta.Size = new Size(94, 19);
            lblNumTarjeta.TabIndex = 35;
            lblNumTarjeta.Text = "*N° Tarjeta:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(47, 260);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(53, 19);
            lblMail.TabIndex = 34;
            lblMail.Text = "*Mail:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(47, 179);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 19);
            lblApellido.TabIndex = 33;
            lblApellido.Text = "*Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(47, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 19);
            lblNombre.TabIndex = 32;
            lblNombre.Text = "*Nombre:";
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos.Location = new Point(24, 11);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(241, 33);
            lblDatos.TabIndex = 31;
            lblDatos.Text = "Datos completos:";
            // 
            // btnDenegate
            // 
            btnDenegate.BackColor = Color.Firebrick;
            btnDenegate.FlatStyle = FlatStyle.Flat;
            btnDenegate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDenegate.ForeColor = SystemColors.Control;
            btnDenegate.Location = new Point(793, 336);
            btnDenegate.Name = "btnDenegate";
            btnDenegate.Size = new Size(162, 46);
            btnDenegate.TabIndex = 50;
            btnDenegate.Text = "Denegar Cambios";
            btnDenegate.UseVisualStyleBackColor = false;
            btnDenegate.Click += btnDenegate_Click;
            // 
            // txtReclamo
            // 
            txtReclamo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtReclamo.Location = new Point(521, 59);
            txtReclamo.Multiline = true;
            txtReclamo.Name = "txtReclamo";
            txtReclamo.Size = new Size(479, 252);
            txtReclamo.TabIndex = 51;
            // 
            // FormAdminEstadoTramite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 394);
            Controls.Add(txtReclamo);
            Controls.Add(btnDenegate);
            Controls.Add(btnAprobe);
            Controls.Add(btnBajaTarjeta);
            Controls.Add(cmbTarifa);
            Controls.Add(txtCredito);
            Controls.Add(txtMail);
            Controls.Add(txtApellido);
            Controls.Add(txtNumTarjeta);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(lblBalance);
            Controls.Add(lblTarifaSocial);
            Controls.Add(lblTarjeta);
            Controls.Add(lblUsuario);
            Controls.Add(lblNumTarjeta);
            Controls.Add(lblMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAdminEstadoTramite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificar Tramite";
            FormClosed += FormAdminEstadoTramite_FormClosed;
            Load += FormAdminEstadoTramite_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAprobe;
        private Button btnBajaTarjeta;
        private ComboBox cmbTarifa;
        private TextBox txtCredito;
        private TextBox txtMail;
        private TextBox txtApellido;
        private TextBox txtNumTarjeta;
        private TextBox txtNombre;
        private Label label1;
        private Label lblBalance;
        private Label lblTarifaSocial;
        private Label lblTarjeta;
        private Label lblUsuario;
        private Label lblNumTarjeta;
        private Label lblMail;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDatos;
        private Button btnDenegate;
        private TextBox txtReclamo;
    }
}