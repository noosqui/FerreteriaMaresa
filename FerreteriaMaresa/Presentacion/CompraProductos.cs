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
        public CompraProductos(string idEmpleado)
        {
            InitializeComponent();
            subtotal = 0;
            empleados.Id_empleado = idEmpleado;
        }

        private void CompraProductos_Load(object sender, EventArgs e)
        {

            var product = productos.mostrar_inventario();
            var prov = proveedor.CargarDGVProveedores();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            product.DefaultView.RowFilter = "Estado = 'ACTIVO' ";
            prov.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Activo");
            dgvListaProductos.Rows.Clear();

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
                    foreach (DataGridViewRow row in dgvListaProductos.Rows)

                        if (row.Cells[0].Value.ToString() == txtId.Text)
                        {
                            txtCantidad.Text = int.Parse(txtCantidad.Text) + int.Parse(row.Cells[3].Value.ToString()) + "";
                            dgvListaProductos.Rows.Remove(row);
                            txtSubtotal.Text = double.Parse(txtSubtotal.Text) - (double.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString())) + "";

                        }
                    suma = double.Parse(txtCosto.Text) * int.Parse(txtCantidad.Text);
                        suma += double.Parse(txtSubtotal.Text);
                        dgvListaProductos.Rows.Add(txtId.Text, txtnombre.Text,
                        txtCosto.Text, txtCantidad.Text, dgvProducto.SelectedRows[0].Cells[2].Value.ToString());
                        txtSubtotal.Text = "" + suma;
                    btnSiguiente.Visible = true;
                    txtTotal.Text = "" + ((suma * 0.15) + (suma));
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
                subtotal =double.Parse(txtSubtotal.Text)- int.Parse(dgvListaProductos.SelectedRows[0].Cells[3].Value.ToString()) * double.Parse(dgvListaProductos.SelectedRows[0].Cells[2].Value.ToString());
                dgvListaProductos.Rows.RemoveAt(dgvListaProductos.SelectedRows[0].Index);
                txtSubtotal.Text = "" + subtotal;
               
                txtTotal.Text = "" + ((subtotal * 0.15) + (subtotal));
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
                if (dgvListaProductos.Rows.Count > 0)
                {
                    TipoDePago tipoDePago = new TipoDePago();
                    DialogResult dr = DialogResult.Cancel;
                    facturacion.proveedor = proveedor;
                    dgvListaProductos.Enabled = false;
                    while (dr == DialogResult.Cancel)
                    {
                        dr = tipoDePago.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            TipoCheque cheque = new TipoCheque();
                            cheque.monto = "" + (suma * 0.15 + suma);
                            dr = cheque.ShowDialog();
                            if (dr == DialogResult.Yes)
                                facturacion.InsertarFacturaCompra("0", txtSubtotal.Text, "1", empleados.Id_empleado, ((DataTable)cmbProveedor.DataSource).Rows[cmbProveedor.SelectedIndex][0].ToString(),"0.15");

                        }
                    }
                    if (dr == DialogResult.No)
                        facturacion.InsertarFacturaCompra("0", txtSubtotal.Text, "2", empleados.Id_empleado, ((DataTable)cmbProveedor.DataSource).Rows[cmbProveedor.SelectedIndex][0].ToString(),"0.15");

                    if (dr != DialogResult.None && dr != DialogResult.Abort)
                    {
                        foreach (DataGridViewRow row in dgvListaProductos.Rows)
                        {

                            productos.Id_producto = int.Parse(row.Cells[0].Value.ToString());
                            productos.Precio_actual = double.Parse(row.Cells[2].Value.ToString());
                            facturacion.insertarDetalleCompra(row.Cells[3].Value.ToString(), productos);
                        }
                        
                    }
                    if (dr != DialogResult.Abort)
                    {
                        dgvListaProductos.Enabled = true;
                        CompraProductos_Load(null, null);
                    }
                }
                else throw new Exception("Producto no ingresado a la lista");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Agregue toda la informacion necesaria antes de continuar "+ ex);

            }
           
        }
        private void txtnombrepor_TextChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvProducto.DataSource;
            if (txtnombreprod.Text != "")
                dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '{0}*' and [Estado] like 'ACTIVO'  and [Nombre Proveedor] like '%"+ cmbProveedor.Text + "%' ", txtnombreprod.Text);
            else
                dt.DefaultView.RowFilter = string.Format("[Nombre Proveedor] LIKE '%{0}%' and [Estado] LIKE 'ACTIVO' ", cmbProveedor.Text);
                dgvProducto.Refresh();

       
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
            var dt = (DataTable)dgvProducto.DataSource;
            dt.CaseSensitive = false;
            if (txtcodigoprod.Text != "")

            dt.DefaultView.RowFilter = string.Format("[Id Producto] = '{0}' and [Estado] like 'ACTIVO' and [Nombre Proveedor] like '%"+cmbProveedor.Text+"'", int.Parse(txtcodigoprod.Text));
            
            else
            {
                dt.DefaultView.RowFilter = string.Format("[Nombre Proveedor] LIKE '%{0}%' and [Estado] LIKE 'ACTIVO' ", cmbProveedor.Text);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigoprod_Enter(object sender, EventArgs e)
        {
            txtnombreprod.Text = "";
        }

        private void txtnombreprod_Enter(object sender, EventArgs e)
        {
            txtcodigoprod.Text = "";
        }
    }
}
