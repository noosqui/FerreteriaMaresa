using System;
using System.Windows.Forms;
using System.Data;
using Dominio;

namespace Presentacion
{
    public partial class CompraProductos : Form
    {

        DOM_Empleados empleados = new DOM_Empleados();
        DOM_Facturacion facturacion = new DOM_Facturacion();
        DOM_Inventario inventario = new DOM_Inventario();

        public CompraProductos()
        {
            InitializeComponent();
        }

        private void CompraProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            habilitar.Enabled = true;

            txtnombre.Enabled = true;
            txtmarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;

            dgvListaProductos.Rows.Add(dgvProducto.SelectedRows, txtCantidad.Text);



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            habilitar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            habilitar.Enabled = true;
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            txtnombre.Enabled = true;
            txtmarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facturacion.InsertarFacturaVenta(empleados, txtSubtotal.Text,"0");

            foreach (DataRow row in dgvListaProductos.Rows)
            {
                inventario.Id_producto = row.Field<int>("id_producto");
                inventario.Id_marca = row.Field<int>("id_marca");
                inventario.Nom_producto = row.Field<string>("nom_producto");
                inventario.Cantidad_unidad = row.Field<string>("Cantidad_por_Unidad");
                inventario.Precio_actual = row.Field<double>("precio_actual");
                inventario.Id_categoria = row.Field<int>("id_categoria");
                facturacion.insertarDetalleCompra(row.Field<string>("cantidad"), inventario);
            }
        }

        private void txtnombrepor_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvProducto.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{1}%'", txtnombreprod.Text);
            dgvProducto.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcodigopro_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvProducto.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigoprod.Text));
            dgvProducto.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
