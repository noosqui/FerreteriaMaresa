using System;
using System.Windows.Forms;
using Dominio;
using System.Data;
using System.Media;
namespace Presentacion
{
    public partial class VentaProducto : Form
    {
        DOM_Facturacion facturacion = new DOM_Facturacion();
        DOM_Inventario inventario = new DOM_Inventario();
        DOM_Empleados empleados = new DOM_Empleados();
        DOM_Validacion letrasNum = new DOM_Validacion();
        double suma;
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
            suma = double.Parse(dgvProductos.SelectedRows[0].Cells[8].Value.ToString()) * int.Parse(txtCantidad.Text);
            suma += double.Parse(txtSubtotal.Text);
            dgvProductList.Rows.Add(dgvProductos.SelectedRows[0].Cells[0].Value, dgvProductos.SelectedRows[0].Cells[1].Value, dgvProductos.SelectedRows[0].Cells[8].Value, txtCantidad.Text, dgvProductos.SelectedRows[0].Cells[6].Value);
            txtSubtotal.Text = "" + suma;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            facturacion.InsertarFacturaVenta("0318199230254", "0312197866522", txtSubtotal.Text, txtDescuento.Text);


            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                inventario.Id_producto =(int) row.Cells[0].Value;
                inventario.Precio_actual = double.Parse(row.Cells[2].Value.ToString());
                facturacion.insertarDetalleVenta(row.Cells[3].Value.ToString(),inventario);
            }
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtStock.Enabled = true;
            txtprecio.Enabled = true;
            txtCantidad.Enabled = true;
        }


        private void VentaProducto_Load(object sender, EventArgs e)
        {
            var fuente = new BindingSource();
            fuente.DataSource = inventario.mostrar_inventario();
            dgvProductos.DataSource = fuente;
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

                dt.DefaultView.RowFilter = null;

            dgvProductos.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtIdSrch, 0, 25, 3000);
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
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtNombreSrch, 0, 25, 3000);
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

        private void button5_Click(object sender, EventArgs e)
        {
            suma -= double.Parse(dgvProductList.SelectedRows[0].Cells[2].Value.ToString()) * double.Parse(dgvProductList.SelectedRows[0].Cells[3].Value.ToString());
            dgvProductList.Rows.RemoveAt(dgvProductList.SelectedRows[0].Index);
            txtSubtotal.Text = "" + suma;
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductList.CurrentRow.Selected = false;
            dgvProductList.CurrentRow.Selected = true;


        }

    }
}
