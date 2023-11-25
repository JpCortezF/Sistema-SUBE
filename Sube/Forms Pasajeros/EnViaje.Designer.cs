namespace Sube.Forms_Pasajeros
{
    partial class EnViaje
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblViaje = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.busGif;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblViaje
            // 
            lblViaje.AutoSize = true;
            lblViaje.BackColor = Color.Black;
            lblViaje.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblViaje.ForeColor = Color.WhiteSmoke;
            lblViaje.ImageAlign = ContentAlignment.TopRight;
            lblViaje.Location = new Point(12, 9);
            lblViaje.Name = "lblViaje";
            lblViaje.Size = new Size(56, 18);
            lblViaje.TabIndex = 1;
            lblViaje.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // EnViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 287);
            ControlBox = false;
            Controls.Add(lblViaje);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnViaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnViaje";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblViaje;
        private System.Windows.Forms.Timer timer1;
    }
}