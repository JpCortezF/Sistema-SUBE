namespace Sube
{
    partial class InicioPasajero
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
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            mISUBEToolStripMenuItem = new ToolStripMenuItem();
            subeToolStripMenuItem = new ToolStripMenuItem();
            viajesToolStripMenuItem = new ToolStripMenuItem();
            tarifaSocialToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, mISUBEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 37);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(103, 33);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // mISUBEToolStripMenuItem
            // 
            mISUBEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subeToolStripMenuItem, viajesToolStripMenuItem, tarifaSocialToolStripMenuItem });
            mISUBEToolStripMenuItem.Name = "mISUBEToolStripMenuItem";
            mISUBEToolStripMenuItem.Size = new Size(129, 33);
            mISUBEToolStripMenuItem.Text = "MI SUBE";
            // 
            // subeToolStripMenuItem
            // 
            subeToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            subeToolStripMenuItem.Name = "subeToolStripMenuItem";
            subeToolStripMenuItem.Size = new Size(169, 24);
            subeToolStripMenuItem.Text = "Sube";
            subeToolStripMenuItem.Click += subeToolStripMenuItem_Click;
            // 
            // viajesToolStripMenuItem
            // 
            viajesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            viajesToolStripMenuItem.Size = new Size(169, 24);
            viajesToolStripMenuItem.Text = "Viajes";
            // 
            // tarifaSocialToolStripMenuItem
            // 
            tarifaSocialToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tarifaSocialToolStripMenuItem.Name = "tarifaSocialToolStripMenuItem";
            tarifaSocialToolStripMenuItem.Size = new Size(169, 24);
            tarifaSocialToolStripMenuItem.Text = "Tarifa Social";
            // 
            // InicioPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.headerShortMiSube;
            ClientSize = new Size(934, 477);
            ControlBox = false;
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "InicioPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioPasajero";
            Load += InicioPasajero_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mISUBEToolStripMenuItem;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem viajesToolStripMenuItem;
        private ToolStripMenuItem tarifaSocialToolStripMenuItem;
        private ToolStripMenuItem subeToolStripMenuItem;
    }
}