namespace Sube
{
    partial class FormAdminVistaUsuario
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
            lblDatos = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblMail = new Label();
            lblNumTarjeta = new Label();
            lblUsuario = new Label();
            lblTarjeta = new Label();
            lblTarifaSocial = new Label();
            lblBalance = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtNumTarjeta = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            txtCredito = new TextBox();
            cmbTarifa = new ComboBox();
            dataGridView1 = new DataGridView();
            btnBajaTarjeta = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos.Location = new Point(12, 9);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(241, 33);
            lblDatos.TabIndex = 3;
            lblDatos.Text = "Datos completos:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(35, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 19);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "*Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(35, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 19);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "*Apellido:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(35, 258);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(53, 19);
            lblMail.TabIndex = 15;
            lblMail.Text = "*Mail:";
            // 
            // lblNumTarjeta
            // 
            lblNumTarjeta.AutoSize = true;
            lblNumTarjeta.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumTarjeta.Location = new Point(285, 94);
            lblNumTarjeta.Name = "lblNumTarjeta";
            lblNumTarjeta.Size = new Size(94, 19);
            lblNumTarjeta.TabIndex = 16;
            lblNumTarjeta.Text = "*N° Tarjeta:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(12, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(95, 25);
            lblUsuario.TabIndex = 17;
            lblUsuario.Text = "Usuario:";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarjeta.Location = new Point(262, 57);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(86, 25);
            lblTarjeta.TabIndex = 18;
            lblTarjeta.Text = "Tarjeta:";
            // 
            // lblTarifaSocial
            // 
            lblTarifaSocial.AutoSize = true;
            lblTarifaSocial.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarifaSocial.Location = new Point(285, 177);
            lblTarifaSocial.Name = "lblTarifaSocial";
            lblTarifaSocial.Size = new Size(112, 19);
            lblTarifaSocial.TabIndex = 19;
            lblTarifaSocial.Text = "*Tarifa Social:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(285, 258);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(74, 19);
            lblBalance.TabIndex = 20;
            lblBalance.Text = "*Credito:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(509, 17);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 21;
            label1.Text = "Ultimos viajes:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ControlLight;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(35, 116);
            txtNombre.MaxLength = 8;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 29);
            txtNombre.TabIndex = 22;
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.BackColor = SystemColors.ControlLight;
            txtNumTarjeta.Enabled = false;
            txtNumTarjeta.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumTarjeta.Location = new Point(285, 116);
            txtNumTarjeta.MaxLength = 8;
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(190, 29);
            txtNumTarjeta.TabIndex = 23;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.ControlLight;
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(35, 199);
            txtApellido.MaxLength = 8;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 29);
            txtApellido.TabIndex = 24;
            // 
            // txtMail
            // 
            txtMail.BackColor = SystemColors.ControlLight;
            txtMail.Enabled = false;
            txtMail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(35, 280);
            txtMail.MaxLength = 8;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(190, 29);
            txtMail.TabIndex = 25;
            // 
            // txtCredito
            // 
            txtCredito.BackColor = SystemColors.ControlLight;
            txtCredito.Enabled = false;
            txtCredito.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCredito.Location = new Point(285, 280);
            txtCredito.MaxLength = 8;
            txtCredito.Name = "txtCredito";
            txtCredito.Size = new Size(190, 29);
            txtCredito.TabIndex = 26;
            // 
            // cmbTarifa
            // 
            cmbTarifa.AutoCompleteMode = AutoCompleteMode.Append;
            cmbTarifa.Cursor = Cursors.Hand;
            cmbTarifa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTarifa.FormattingEnabled = true;
            cmbTarifa.Items.AddRange(new object[] { "DNI", "Nombre y Apellido", "N° de Tarjeta" });
            cmbTarifa.Location = new Point(285, 199);
            cmbTarifa.Name = "cmbTarifa";
            cmbTarifa.Size = new Size(117, 29);
            cmbTarifa.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(509, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(479, 252);
            dataGridView1.TabIndex = 28;
            // 
            // btnBajaTarjeta
            // 
            btnBajaTarjeta.BackColor = Color.Firebrick;
            btnBajaTarjeta.FlatStyle = FlatStyle.Flat;
            btnBajaTarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaTarjeta.ForeColor = SystemColors.Control;
            btnBajaTarjeta.Location = new Point(311, 336);
            btnBajaTarjeta.Name = "btnBajaTarjeta";
            btnBajaTarjeta.Size = new Size(134, 46);
            btnBajaTarjeta.TabIndex = 29;
            btnBajaTarjeta.Text = "Baja Tarjeta";
            btnBajaTarjeta.UseVisualStyleBackColor = false;
            btnBajaTarjeta.Click += btnBajaTarjeta_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(45, 336);
            button1.Name = "button1";
            button1.Size = new Size(157, 46);
            button1.TabIndex = 30;
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormAdminVistaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 394);
            Controls.Add(button1);
            Controls.Add(btnBajaTarjeta);
            Controls.Add(dataGridView1);
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
            Name = "FormAdminVistaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del Usuario";
            Load += FormAdminVistaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblMail;
        private Label lblNumTarjeta;
        private Label lblUsuario;
        private Label lblTarjeta;
        private Label lblTarifaSocial;
        private Label lblBalance;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtNumTarjeta;
        private TextBox txtApellido;
        private TextBox txtMail;
        private TextBox txtCredito;
        private ComboBox cmbTarifa;
        private DataGridView dataGridView1;
        private Button btnBajaTarjeta;
        private Button button1;
    }
}