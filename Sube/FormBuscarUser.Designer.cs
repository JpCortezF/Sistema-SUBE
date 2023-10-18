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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cmbBuscar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 136);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1015, 352);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // FormBuscarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1080, 518);
            Controls.Add(cmbBuscar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnIngresar);
            Controls.Add(txtDni);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBuscarUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDni;
        private Label label2;
        private Button btnIngresar;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox cmbBuscar;
    }
}