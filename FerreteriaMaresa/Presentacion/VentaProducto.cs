using System;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class VentaProducto : Form
    {
        DOM_Inventario inventario = new DOM_Inventario();
        public VentaProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtStock.Enabled = true;
            txtprecio.Enabled = true;
            txtCantidad.Enabled = true;
        }


        private void VentaProducto_Load(object sender, EventArgs e)
        {

            dgvProductos.DataSource = inventario.mostrar_inventario();
            dgvProductos.Columns["Id Marca"].Visible = false;
            dgvProductos.Columns["Id Categoria"].Visible = false;
            dgvProductos.Refresh();
            dgvProductos.Rows[1].Selected = true;
            dgvProductos.CurrentRow.Selected = true;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.CurrentRow.Selected = false;
            dgvProductos.CurrentRow.Selected = true;
            txtId.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[9].Value.ToString();
            txtprecio.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();

        }
    }
}
