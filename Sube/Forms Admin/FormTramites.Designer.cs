namespace Sube
{
    partial class FormTramites
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
            dataGridView1 = new DataGridView();
            lblTramite = new Label();
            lblCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 83);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1008, 402);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblTramite
            // 
            lblTramite.AutoSize = true;
            lblTramite.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTramite.Location = new Point(37, 31);
            lblTramite.Name = "lblTramite";
            lblTramite.Size = new Size(263, 28);
            lblTramite.TabIndex = 5;
            lblTramite.Text = "* Tramites pendientes:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.Red;
            lblCount.Location = new Point(306, 31);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(26, 28);
            lblCount.TabIndex = 6;
            lblCount.Text = "0";
            // 
            // FormTramites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 518);
            Controls.Add(lblCount);
            Controls.Add(lblTramite);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTramites";
            StartPosition = FormStartPosition.Manual;
            Text = "FormTramites";
            FormClosed += FormTramites_FormClosed;
            Load += FormTramites_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTramite;
        private Label lblCount;
    }
}