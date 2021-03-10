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

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            Nombre.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            Strock.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
            precio.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            Cantidad.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
