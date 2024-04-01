namespace Sube
{
    partial class FormBuscarUser
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
            txtDni = new TextBox();
            label2 = new Label();
            btnIngresar = new Button();
            dataGridView = new DataGridView();
            label1 = new Label();
            cmbBuscar = new ComboBox();
            panel1 = new Panel();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(30, 92);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(316, 29);
            txtDni.TabIndex = 7;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(218, 19);
            label2.TabIndex = 8;
            label2.Text = "* N° de documento a buscar:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Control;
            btnIngresar.Location = new Point(352, 92);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 29);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Buscar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(995, 352);
            dataGridView.TabIndex = 11;
            dataGridView.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 12;
            label1.Text = "* Buscar por:";
            // 
            // cmbBuscar
            // 
            cmbBuscar.AutoCompleteMode = AutoCompleteMode.Append;
            cmbBuscar.Cursor = Cursors.Hand;
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Items.AddRange(new object[] { "DNI", "Nombre y Apellido", "N° de Tarjeta" });
            cmbBuscar.Location = new Point(141, 28);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(117, 23);
            cmbBuscar.TabIndex = 13;
            cmbBuscar.SelectedIndexChanged += cmbBuscar_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(30, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 350);
            panel1.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(30, 92);
            txtName.MaxLength = 8;
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 29);
            txtName.TabIndex = 15;
            txtName.Visible = false;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // FormBuscarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1080, 518);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Controls.Add(cmbBuscar);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(txtDni);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBuscarUser";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            FormClosed += FormBuscarUser_FormClosed;
            Load += FormBuscarUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDni;
        private Label label2;
        private Button btnIngresar;
        private DataGridView dataGridView;
        private Label label1;
        private ComboBox cmbBuscar;
        private Panel panel1;
        private TextBox txtName;
    }
}