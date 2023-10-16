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
            dataGridViajes = new DataGridView();
            label1 = new Label();
            txtBusqueda = new TextBox();
            label2 = new Label();
            btnSalir = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViajes
            // 
            dataGridViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViajes.Location = new Point(0, 0);
            dataGridViajes.Name = "dataGridViajes";
            dataGridViajes.RowTemplate.Height = 25;
            dataGridViajes.Size = new Size(776, 268);
            dataGridViajes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 1;
            label1.Text = "Movimientos";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(87, 103);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Línea...";
            txtBusqueda.Size = new Size(197, 26);
            txtBusqueda.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
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
            btnSalir.Location = new Point(752, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 42);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(334, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(dataGridViajes);
            panel1.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(12, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 268);
            panel1.TabIndex = 6;
            // 
            // FormViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViajes";
            Load += FormViajes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViajes;
        private Label label1;
        private TextBox txtBusqueda;
        private Label label2;
        private Button btnSalir;
        private ComboBox comboBox1;
        private Panel panel1;
    }
}