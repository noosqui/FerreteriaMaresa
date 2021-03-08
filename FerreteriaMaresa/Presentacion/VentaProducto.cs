using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentaProducto : Form
    {
        public VentaProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Id.Enabled = true;
            Nombre.Enabled = true;
            Strock.Enabled = true;
            precio.Enabled = true;
            Cantidad.Enabled = true;
        }
    }
}
