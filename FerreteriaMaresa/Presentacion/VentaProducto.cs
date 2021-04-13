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
        DOM_Clientes client = new DOM_Clientes();
        double suma;
        ToolTip tt = new ToolTip();
        public VentaProducto()
        {
            InitializeComponent();
        }
        public VentaProducto(DOM_Empleados emp)
        {
            this.empleados = emp;
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                int stock = int.Parse(txtStock.Text);
                try
                {
                    if (cantidad > 0 && cantidad <= stock)
                    {
                        suma = double.Parse(txtprecio.Text) * int.Parse(txtCantidad.Text);
                        suma += double.Parse(txtSubtotal.Text);
                        dgvProductList.Rows.Add(txtId.Text, txtNombre.Text, txtprecio.Text, txtCantidad.Text, dgvProductos.SelectedRows[0].Cells[2].Value);
                        txtSubtotal.Text = "" + suma;
                        btnCancelar.Enabled = true;
                        txtCantidad.Text = "" + 0;
                    }
                    else
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ingrese la cantidad correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Seleccione un producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductList.Rows.Count > 0)
                {
                    TipoDePago tipoDePago = new TipoDePago();
                    DialogResult dr = DialogResult.Cancel;

                    while (dr == DialogResult.Cancel)
                    {


                        dr = tipoDePago.ShowDialog();

                        if (dr == DialogResult.Yes)
                        {
                            TipoCheque cheque = new TipoCheque();
                            MessageBox.Show(suma + "");
                            cheque.monto = "" + (suma * 0.15 +suma);
                            dr = cheque.ShowDialog();
                            MessageBox.Show(((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][3].ToString());
                            if (dr == DialogResult.Yes)
                                if (chkRTN.Checked && ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][3].ToString().Length > 0)
                                    facturacion.InsertarFacturaVenta("0819200100077", ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                                    , txtSubtotal.Text, "1", "0.15", txtDescuento.Text, "1");
                                else
                                    throw new Exception("Error el empleado no contiene rtn");

                                if (!chkRTN.Checked)
                                facturacion.InsertarFacturaVenta("0819200100077", ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                                   , txtSubtotal.Text,"0", "0.15", txtDescuento.Text, "1");


                        }
                    }
                    if (dr == DialogResult.No)
                        if (chkRTN.Checked && ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][3].ToString().Length > 0)
                            facturacion.InsertarFacturaVenta("0819200100077", ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                                       , txtSubtotal.Text, "1", "0.15", txtDescuento.Text, "2");
                        else
                            throw new Exception("Error el empleado no contiene rtn");
                    if (!chkRTN.Checked)
                        facturacion.InsertarFacturaVenta("0819200100077", ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                           , txtSubtotal.Text, "0", "0.15", txtDescuento.Text, "2");


                    if (dr != DialogResult.None && dr != DialogResult.Abort)
                    {
                        foreach (DataGridViewRow row in dgvProductList.Rows)
                        {
                            inventario.Id_producto = int.Parse(row.Cells[0].Value.ToString());
                            inventario.Precio_actual = double.Parse(row.Cells[2].Value.ToString());
                            facturacion.insertarDetalleVenta(row.Cells[3].Value.ToString(), inventario);
                        }
                        txtId.Enabled = true;
                        txtNombre.Enabled = true;
                        txtStock.Enabled = true;
                        txtprecio.Enabled = true;
                        txtCantidad.Enabled = true;

                        //aqui se debe abrir el reporte
                    }


                }
                else throw new Exception("Producto no ingresado a la lista");
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error al insertar (Error) " + ex);
            }

        }
        

        private void VentaProducto_Load(object sender, EventArgs e)
        {
            var producto = inventario.mostrar_inventario();
            var Cliente = client.Mostrar_Cliente();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            producto.DefaultView.RowFilter = "Estado = 'ACTIVO' ";
            dgvProductos.DataSource = producto;
            dgvProductos.Columns["Id Marca"].Visible = false;
            dgvProductos.Columns["Id Categoría"].Visible = false;
            dgvProductos.Columns["Id Proveedor"].Visible = false;
            dgvProductos.Refresh();
            dgvProductos.Rows[1].Selected = true;
            dgvProductos.CurrentRow.Selected = true;
            dgvProductos_CellClick(null, null);
            Cliente.Columns.Add("Concat");
            foreach (DataRow row in Cliente.Rows)
            {
                        row["Concat"] = (row["Nombres"]+" "+ row["Apellidos"]);
                coleccion.Add(row["Concat"]+"");
            }

            cmbClientes.DataSource = Cliente;
            cmbClientes.DisplayMember = "Concat";
            cmbClientes.ValueMember = "Concat";
            cmbClientes.AutoCompleteCustomSource = coleccion;
            cmbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.CurrentRow.Selected = true;
            txtId.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            txtprecio.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
        }


        private void txtIdSrch_TextChanged(object sender, EventArgs e)
        {
          //  var bd = (BindingSource)dgvProductos.DataSource;
           // var dt = (DataTable)bd.DataSource;
            if (txtIdSrch.Text != "")
                (dgvProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtIdSrch.Text));
            else
                (dgvProductos.DataSource as DataTable).DefaultView.RowFilter = null;

            dgvProductos.Refresh();

            if ((dgvProductos.DataSource as DataTable).DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtIdSrch, 0, 25, 3000);
            }
        }

        private void txtNombreSrch_TextChanged(object sender, EventArgs e)
        {
           // var bd = (BindingSource)dgvProductos.DataSource;
           // var dt = (DataTable)bd.DataSource;
            (dgvProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}%'", txtNombreSrch.Text);
            dgvProductos.Refresh();
            if ((dgvProductos.DataSource as DataTable).DefaultView.Count < 1)
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
            try
            {
                suma -= double.Parse(dgvProductList.SelectedRows[0].Cells[2].Value.ToString()) * double.Parse(dgvProductList.SelectedRows[0].Cells[3].Value.ToString());
                dgvProductList.Rows.RemoveAt(dgvProductList.SelectedRows[0].Index);
                txtSubtotal.Text = "" + suma;
                if (dgvProductList.Rows.Count == 0)
                    btnCancelar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Seleccione un producto a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvProductList.CurrentRow.Selected = false;
                dgvProductList.CurrentRow.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No hay nada ingresado", "Error");
            }

        }

       
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese un numero que sea menor o igual que la cantidad en inventaro", txtCantidad, 5000);
        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);

        }
    }
}
