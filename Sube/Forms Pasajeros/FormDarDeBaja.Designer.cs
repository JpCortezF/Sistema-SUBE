namespace Sube
{
    partial class FormDarDeBaja
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
            txtClaim = new TextBox();
            button1 = new Button();
            btnTramite = new Button();
            groupBox1 = new GroupBox();
            rdbPerdida = new RadioButton();
            rdbRobo = new RadioButton();
            rdbRotura = new RadioButton();
            lblMotivos = new Label();
            lblAdvertencia = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtClaim
            // 
            txtClaim.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaim.Location = new Point(599, 102);
            txtClaim.MaxLength = 140;
            txtClaim.Multiline = true;
            txtClaim.Name = "txtClaim";
            txtClaim.Size = new Size(260, 114);
            txtClaim.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(870, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 26);
            button1.TabIndex = 18;
            button1.Text = " x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // btnTramite
            // 
            btnTramite.BackColor = Color.ForestGreen;
            btnTramite.Cursor = Cursors.Hand;
            btnTramite.FlatStyle = FlatStyle.Flat;
            btnTramite.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTramite.ForeColor = SystemColors.Control;
            btnTramite.Location = new Point(717, 263);
            btnTramite.Name = "btnTramite";
            btnTramite.Size = new Size(144, 35);
            btnTramite.TabIndex = 17;
            btnTramite.Text = "Iniciar trámite";
            btnTramite.UseVisualStyleBackColor = false;
            btnTramite.Click += btnTramite_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPerdida);
            groupBox1.Controls.Add(rdbRobo);
            groupBox1.Controls.Add(rdbRotura);
            groupBox1.Location = new Point(367, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 114);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // rdbPerdida
            // 
            rdbPerdida.AutoSize = true;
            rdbPerdida.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPerdida.Location = new Point(6, 51);
            rdbPerdida.Name = "rdbPerdida";
            rdbPerdida.Size = new Size(71, 19);
            rdbPerdida.TabIndex = 14;
            rdbPerdida.TabStop = true;
            rdbPerdida.Text = "Perdida";
            rdbPerdida.UseVisualStyleBackColor = true;
            // 
            // rdbRobo
            // 
            rdbRobo.AutoSize = true;
            rdbRobo.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbRobo.Location = new Point(6, 13);
            rdbRobo.Name = "rdbRobo";
            rdbRobo.Size = new Size(60, 19);
            rdbRobo.TabIndex = 11;
            rdbRobo.TabStop = true;
            rdbRobo.Text = "Robo";
            rdbRobo.UseVisualStyleBackColor = true;
            // 
            // rdbRotura
            // 
            rdbRotura.AutoSize = true;
            rdbRotura.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbRotura.Location = new Point(6, 92);
            rdbRotura.Name = "rdbRotura";
            rdbRotura.Size = new Size(68, 19);
            rdbRotura.TabIndex = 13;
            rdbRotura.TabStop = true;
            rdbRotura.Text = "Rotura";
            rdbRotura.UseVisualStyleBackColor = true;
            // 
            // lblMotivos
            // 
            lblMotivos.AutoSize = true;
            lblMotivos.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMotivos.Location = new Point(12, 29);
            lblMotivos.Name = "lblMotivos";
            lblMotivos.Size = new Size(76, 18);
            lblMotivos.TabIndex = 21;
            lblMotivos.Text = "Motivos";
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvertencia.Location = new Point(12, 119);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(82, 15);
            lblAdvertencia.TabIndex = 22;
            lblAdvertencia.Text = "Advertencia";
            // 
            // FormDarDeBaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 310);
            ControlBox = false;
            Controls.Add(lblAdvertencia);
            Controls.Add(lblMotivos);
            Controls.Add(groupBox1);
            Controls.Add(txtClaim);
            Controls.Add(button1);
            Controls.Add(btnTramite);
            Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDarDeBaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDarDeBaja";
            FormClosed += FormDarDeBaja_FormClosed;
            Load += FormDarDeBaja_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClaim;
        private Button button1;
        private Button btnTramite;
        private GroupBox groupBox1;
        private RadioButton rdbPerdida;
        private RadioButton rdbRobo;
        private RadioButton rdbRotura;
        private Label lblMotivos;
        private Label lblAdvertencia;
    }
}