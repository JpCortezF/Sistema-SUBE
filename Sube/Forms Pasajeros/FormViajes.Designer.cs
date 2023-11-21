namespace Sube
{
    partial class FormViajes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViajes));
            label1 = new Label();
            txtBusqueda = new TextBox();
            label2 = new Label();
            btnSalir = new Button();
            lblSaldo = new Label();
            btnBuscar = new Button();
            label3 = new Label();
            lblFiltro = new Label();
            dataGridViajes = new DataGridView();
            pictureBox1 = new PictureBox();
            lblViajes = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 1;
            label1.Text = "Movimientos";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(87, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Línea...";
            txtBusqueda.Size = new Size(197, 22);
            txtBusqueda.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 3;
            label2.Text = "Búsqueda";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(766, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(34, 27);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.SeaGreen;
            lblSaldo.Location = new Point(693, 109);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(65, 18);
            lblSaldo.TabIndex = 7;
            lblSaldo.Text = "$ Saldo";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.BackgroundImage = Properties.Resources.magnifying_glass;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(290, 106);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(708, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 9;
            label3.Text = "Saldo";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Cursor = Cursors.Hand;
            lblFiltro.FlatStyle = FlatStyle.Flat;
            lblFiltro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltro.Location = new Point(327, 111);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(62, 13);
            lblFiltro.TabIndex = 10;
            lblFiltro.Text = "Quitar filtros";
            lblFiltro.Visible = false;
            lblFiltro.Click += lblFiltro_Click;
            // 
            // dataGridViajes
            // 
            dataGridViajes.AllowUserToAddRows = false;
            dataGridViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViajes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViajes.Location = new Point(12, 149);
            dataGridViajes.Name = "dataGridViajes";
            dataGridViajes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViajes.RowHeadersVisible = false;
            dataGridViajes.RowTemplate.Height = 25;
            dataGridViajes.Size = new Size(777, 268);
            dataGridViajes.TabIndex = 0;
            dataGridViajes.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(777, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblViajes
            // 
            lblViajes.AutoSize = true;
            lblViajes.BackColor = Color.White;
            lblViajes.Cursor = Cursors.Hand;
            lblViajes.FlatStyle = FlatStyle.Flat;
            lblViajes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblViajes.Location = new Point(233, 384);
            lblViajes.Name = "lblViajes";
            lblViajes.Size = new Size(189, 20);
            lblViajes.TabIndex = 12;
            lblViajes.Text = "Todavia no hay viajes! ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel1.Location = new Point(413, 384);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Viaja con nosotros!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(801, 430);
            ControlBox = false;
            Controls.Add(linkLabel1);
            Controls.Add(lblViajes);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViajes);
            Controls.Add(lblFiltro);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(lblSaldo);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViajes";
            FormClosed += FormViajes_FormClosed;
            Load += FormViajes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBusqueda;
        private Label label2;
        private Button btnSalir;
        private Label lblSaldo;
        private Button btnBuscar;
        private Label label3;
        private Label lblFiltro;
        private DataGridView dataGridViajes;
        private PictureBox pictureBox1;
        private Label lblViajes;
        private LinkLabel linkLabel1;
    }
}