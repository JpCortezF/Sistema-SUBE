using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.Load += Loading_Load;
            this.Paint += Loading_Paint;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            LoadingGif();
        }

        private void LoadingGif()
        {
            DialogResult = DialogResult.OK;
        }

        private void Loading_Paint(object sender, PaintEventArgs e)
        {
            // Llamar al método para establecer la región del formulario como circular
            SetCircularRegion();
        }

        private void SetCircularRegion()
        {
            // Crear un gráfico para el formulario
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);

            // Establecer la región del formulario como elipse
            this.Region = new Region(path);
        }
    }
}
