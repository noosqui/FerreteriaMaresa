using System;
using System.Data;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class CompraProductos : Form
    {

        DOM_Empleados empleados = new DOM_Empleados();
        DOM_Facturacion facturacion = new DOM_Facturacion();
        private DOM_Inventario inventario = new DOM_Inventario();
        DOM_Validacion LetraNum = new DOM_Validacion();


        public CompraProductos()
        {
            InitializeComponent();
        }

        private void CompraProductos_Load(object sender, EventArgs e)
        {

         var tab = new BindingSource();
         tab.DataSource = inventario.mostrar_inventario();
         dgvProducto.DataSource = tab;
            dgvProducto.Refresh();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnSiguiente.Visible = true;

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
            btnSiguiente.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnSiguiente.Visible = true;
        }


        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducto.CurrentRow.Selected = true;
            txtnombre.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
            txtCosto.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            txtCantidad.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();

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
            dt.DefaultView.RowFilter = string.Format("[Nombre Producto] LIKE '%{0}%'", txtnombreprod.Text);
            dgvProducto.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Nombre del Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcodigopro_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvProducto.DataSource;
            var dt = (DataTable)bd.DataSource;
            if (txtcodigoprod.Text != "")

                dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigoprod.Text));

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvProducto.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Codigo del Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcodigoprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void txtnombreprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }
    }
}
