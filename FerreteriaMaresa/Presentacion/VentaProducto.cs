using System;
using System.Windows.Forms;
using Dominio;
using System.Data;

namespace Presentacion
{
    public partial class VentaProducto : Form
    {
        DOM_Facturacion facturacion = new DOM_Facturacion();
        DOM_Inventario inventario = new DOM_Inventario();
        DOM_Empleados empleados = new DOM_Empleados();
        DOM_Validacion letrasNum = new DOM_Validacion();

        public VentaProducto()
        {
            InitializeComponent();
        }
        public VentaProducto(DOM_Empleados emp)
        {
            this.empleados = emp;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          dgvProductList.Rows.Add(dgvProductos.SelectedRows,txtCantidad.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            facturacion.InsertarFacturaVenta(empleados, txtSubtotal.Text, txtDescuento.Text);

            foreach (DataRow row in dgvProductList.Rows)
            {
                inventario.Id_producto = row.Field<int>("id_producto");
                inventario.Id_marca = row.Field<int>("id_marca");
                inventario.Nom_producto = row.Field<string>("nom_producto");
                inventario.Cantidad_unidad = row.Field<string>("Cantidad_por_Unidad");
                inventario.Precio_actual = row.Field<double>("precio_actual");
                inventario.Id_categoria = row.Field<int>("id_categoria");
                facturacion.insertarDetalleVenta(row.Field<string>("cantidad"),inventario);
            }
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

        private void txtIdSrch_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvProductos.DataSource;
            var dt = (DataTable)bd.DataSource;
            if (txtIdSrch.Text != "")

                dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtIdSrch.Text));

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvProductos.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Codigo del Empleado",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNombreSrch_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvProductos.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre Producto] LIKE '%{0}%'", txtNombreSrch.Text);
            dgvProductos.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Nombre del Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIdSrch_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtNombreSrch_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }
    }
}
