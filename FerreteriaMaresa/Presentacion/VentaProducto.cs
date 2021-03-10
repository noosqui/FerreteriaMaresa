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

        private void VentaProducto_Load(object sender, EventArgs e)
        {

            dgvProductos.DataSource = inventario.mostrar_inventario() ;

        }
    }
}
