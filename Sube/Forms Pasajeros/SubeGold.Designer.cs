namespace Sube.Forms_Pasajeros
{
    partial class SubeGold
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
            pictureBox1 = new PictureBox();
            lblMensaje = new Label();
            btnSuscripccion = new Button();
            txtClaim = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SubeGold;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(450, 18);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(44, 15);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "label1";
            // 
            // btnSuscripccion
            // 
            btnSuscripccion.BackColor = Color.DarkKhaki;
            btnSuscripccion.Cursor = Cursors.Hand;
            btnSuscripccion.FlatStyle = FlatStyle.Flat;
            btnSuscripccion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuscripccion.ForeColor = SystemColors.Control;
            btnSuscripccion.Location = new Point(529, 212);
            btnSuscripccion.Name = "btnSuscripccion";
            btnSuscripccion.Size = new Size(122, 35);
            btnSuscripccion.TabIndex = 7;
            btnSuscripccion.Text = "Suscribirse";
            btnSuscripccion.UseVisualStyleBackColor = false;
            // 
            // txtClaim
            // 
            txtClaim.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaim.Location = new Point(450, 67);
            txtClaim.MaxLength = 140;
            txtClaim.Multiline = true;
            txtClaim.Name = "txtClaim";
            txtClaim.Size = new Size(253, 117);
            txtClaim.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(721, -1);
            button1.Name = "button1";
            button1.Size = new Size(30, 26);
            button1.TabIndex = 18;
            button1.Text = " x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SubeGold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 259);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(txtClaim);
            Controls.Add(btnSuscripccion);
            Controls.Add(lblMensaje);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubeGold";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubeGold";
            FormClosed += SubeGold_FormClosed;
            Load += SubeGold_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMensaje;
        private Button btnSuscripccion;
        private TextBox txtClaim;
        private Button button1;
    }
}