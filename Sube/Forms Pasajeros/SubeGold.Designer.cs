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
            lblMensaje = new Label();
            btnSuscripccion = new Button();
            button1 = new Button();
            lblCancel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(446, 49);
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
            btnSuscripccion.Location = new Point(410, 193);
            btnSuscripccion.Name = "btnSuscripccion";
            btnSuscripccion.Size = new Size(122, 35);
            btnSuscripccion.TabIndex = 7;
            btnSuscripccion.Text = "Suscribirse";
            btnSuscripccion.UseVisualStyleBackColor = false;
            btnSuscripccion.Click += btnSuscripccion_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(720, -1);
            button1.Name = "button1";
            button1.Size = new Size(30, 26);
            button1.TabIndex = 18;
            button1.Text = " x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.Cursor = Cursors.Hand;
            lblCancel.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCancel.ForeColor = Color.RosyBrown;
            lblCancel.Location = new Point(573, 203);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(127, 15);
            lblCancel.TabIndex = 19;
            lblCancel.Text = "Cancelar suscripción";
            lblCancel.Click += lblCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SubeGold;
            pictureBox1.Location = new Point(2, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(369, 84);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // SubeGold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 259);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblCancel);
            Controls.Add(button1);
            Controls.Add(btnSuscripccion);
            Controls.Add(lblMensaje);
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
        private Label lblMensaje;
        private Button btnSuscripccion;
        private Button button1;
        private Label lblCancel;
        private PictureBox pictureBox1;
        private Label label1;
    }
}