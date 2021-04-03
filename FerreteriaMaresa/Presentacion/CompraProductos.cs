using System;
using System.Data;
using System.Windows.Forms;
using Dominio;
using System.Media;

namespace Presentacion
{
    public partial class CompraProductos : Form
    {

        DOM_Empleados empleados = new DOM_Empleados();
        DOM_Facturacion facturacion = new DOM_Facturacion();
        DOM_Validacion LetraNum = new DOM_Validacion();
        private DOM_Inventario productos = new DOM_Inventario();
        DOM_proveedor proveedor = new DOM_proveedor();
        double suma;
        ToolTip tt = new ToolTip();
        double subtotal;
        public CompraProductos()
        {
            InitializeComponent();
            subtotal = 0;
        }

        private void CompraProductos_Load(object sender, EventArgs e)
        {

            var product = productos.mostrar_inventario();
            var prov = proveedor.mostrarProveedor();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            product.DefaultView.RowFilter = "Estado = 'ACTIVO' ";
            prov.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Activo");
            

            foreach (DataRow row in prov.Rows)   
                    coleccion.Add(row["Nombre"] + "");
               
       
            cmbProveedor.DataSource = prov;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Nombre";
            cmbProveedor.AutoCompleteCustomSource = coleccion;
            cmbProveedor.SelectedIndex = 0;
            dgvProducto.DataSource = product;
            dgvProducto.Rows[1].Selected = true;
            dgvProducto.CurrentRow.Selected = true;
            dgvProducto.Columns["Id Marca"].Visible = false;
            dgvProducto.Columns["Id Categoría"].Visible = false;
            dgvProducto.Columns["Id Proveedor"].Visible = false;
            dgvProducto_CellClick(null, null);
            cmbProveedor_SelectedIndexChanged(null, null);
            dgvProducto.Refresh();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {  
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                    if (cantidad > 0)
                    {
                        suma = double.Parse(txtCosto.Text) * int.Parse(txtCantidad.Text);
                        suma += double.Parse(txtSubtotal.Text);
                        dgvListaProductos.Rows.Add(txtId.Text, txtnombre.Text,
                        txtCosto.Text, txtCantidad.Text, dgvProducto.SelectedRows[0].Cells[2].Value.ToString());
                        txtSubtotal.Text = "" + suma;
                    btnSiguiente.Visible = true;
                     }
                    else
                    {
                        throw new Exception();
                    }
                btnSiguiente.Enabled = true;
                btnEliminar.Enabled = true;
                txtCantidad.Text = "0";
                cmbProveedor.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ingrese lo indicado en cantidad");
                txtCantidad.Focus();
            }

        }
    

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.SelectedRows.Count > 0)
            {
                btnAgregar.Enabled = false;
                //btnModificar.Enabled = false;
                btnSiguiente.Visible = true;
                dgvListaProductos.Rows.RemoveAt(dgvListaProductos.SelectedRows[0].Index);
                subtotal -= (int)dgvListaProductos.SelectedRows[0].Cells[3].Value * (double)dgvListaProductos.SelectedRows[0].Cells[2].Value;
                txtSubtotal.Text = "" + subtotal;
                if (dgvListaProductos.Rows.Count == 0)
                {
                    btnEliminar.Enabled = false;
                    btnSiguiente.Enabled = false;
                    cmbProveedor.Enabled = true;
                }
            }
            else
                MessageBox.Show(this, "Seleccione un producto a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducto.CurrentRow.Selected = true;
            txtId.Text = dgvProducto.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = dgvProducto.CurrentRow.Cells[7].Value.ToString();
            txtPrecio.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            txtCosto.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();

            btnAgregar.Enabled = true;
           // btnModificar.Enabled = true;
            btnEliminar.Enabled = true;


        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {


                facturacion.proveedor = proveedor;
                dgvListaProductos.Enabled = false;
                facturacion.InsertarFacturaCompra("0", txtSubtotal.Text, "1", "1804200703610", ((DataTable)cmbProveedor.DataSource).Rows[cmbProveedor.SelectedIndex][0].ToString());

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {

                    productos.Id_producto = int.Parse(row.Cells[0].Value.ToString());
                    productos.Precio_actual = double.Parse(row.Cells[2].Value.ToString());
                    facturacion.insertarDetalleCompra(row.Cells[3].Value.ToString(), productos);

                }
                dgvListaProductos.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Agregue toda la informacion necesaria antes de continuar");

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
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombreprod, 0, 25, 3000);
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
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtcodigoprod, 0, 25, 3000);
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


        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese numeros mayores a 0", txtCantidad);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((dgvProducto.DataSource as DataTable) != null)
            { 
                proveedor.Id_proveedor = ((DataTable)cmbProveedor.DataSource).Rows[cmbProveedor.SelectedIndex].Field<int>("Id Proveedor");
                (dgvProducto.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre Proveedor] LIKE '%{0}%' and [Estado] LIKE 'ACTIVO' ", cmbProveedor.Text);
            }
         
        }
    }
}
