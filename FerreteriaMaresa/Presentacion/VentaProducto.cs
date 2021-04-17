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
        private double suma;
        private double descuento;
        ToolTip tt = new ToolTip();
        public VentaProducto()
        {
            InitializeComponent();
            descuento = 0;
        }
        public VentaProducto(string idEmpleado)
        {
            this.empleados.Id_empleado = idEmpleado;
            InitializeComponent();
            descuento = 0;
            dgvProductList.DefaultCellStyle = dgvProductos.DefaultCellStyle;
            dgvProductList.RowHeadersDefaultCellStyle = dgvProductos.RowsDefaultCellStyle;
            dgvProductList.RowsDefaultCellStyle = dgvProductos.RowsDefaultCellStyle;
            dgvProductList.ColumnHeadersDefaultCellStyle = dgvProductos.ColumnHeadersDefaultCellStyle;
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
                        foreach (DataGridViewRow row in dgvProductList.Rows)
                        
                            if (row.Cells[0].Value.ToString() == txtId.Text)
                            {
                                txtCantidad.Text = int.Parse(txtCantidad.Text)+ int.Parse (row.Cells[3].Value.ToString())+ ""  ;
                                dgvProductList.Rows.Remove(row);
                                txtSubtotal.Text =double.Parse(txtSubtotal.Text) - (double.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString()))+"";

                            }
               
                        

                        suma = double.Parse(txtprecio.Text) * int.Parse(txtCantidad.Text);
                        suma += double.Parse(txtSubtotal.Text);
                        dgvProductList.Rows.Add(txtId.Text, txtNombre.Text, txtprecio.Text, txtCantidad.Text, dgvProductos.SelectedRows[0].Cells[2].Value);
                        txtSubtotal.Text = "" + suma;
                        btnCancelar.Enabled = true;
                        txtCantidad.Text = "" + 0;
                        txtDescuento.Text = suma * descuento+ "";
                        txtTotal.Text = suma + ((suma - (suma * descuento)) * 0.15)
                            -(suma * descuento)+ "";
                    }
                    else
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ingrese la cantidad correcta"+ ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                         

                            if (dr == DialogResult.Yes)
                            {
                                if (chkRTN.Checked && ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][3].ToString().Length > 0)
                                    facturacion.InsertarFacturaVenta(empleados.Id_empleado, ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                                    , txtSubtotal.Text, "1", "0.15",descuento+"", "1");
                                if (!chkRTN.Checked)
                                    facturacion.InsertarFacturaVenta(empleados.Id_empleado, ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                                       , txtSubtotal.Text, "0", "0.15", descuento + "", "1");
                                if (chkRTN.Checked && ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][3].ToString().Length <= 0)
                                    throw new Exception("Error el empleado no contiene rtn");
                            }
           

                        }
                    }
                    if (dr == DialogResult.No)
                        if (chkRTN.Checked && ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][3].ToString().Length > 0)
                            facturacion.InsertarFacturaVenta(empleados.Id_empleado, ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                                       , txtSubtotal.Text, "1", "0.15", descuento + "", "2");
                        else if (!chkRTN.Checked)
                            facturacion.InsertarFacturaVenta(empleados.Id_empleado, ((DataTable)cmbClientes.DataSource).Rows[cmbClientes.SelectedIndex][0].ToString()
                               , txtSubtotal.Text, "0", "0.15", descuento + "", "2");
                    else
                    throw new Exception("Error el empleado no contiene rtn");
                   


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

                    if (dr != DialogResult.Abort)
                    {
                        FacturaVenta fact = new FacturaVenta();
                        fact.ShowDialog();
                        VentaProducto_Load(null, null);
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
            dgvProductList.Rows.Clear();
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
             var dt = (DataTable)dgvProductos.DataSource;
            if (txtIdSrch.Text != "")
                dt.DefaultView.RowFilter = string.Format("[Id Producto] = '{0}' and [Estado] like 'ACTIVO'", int.Parse(txtIdSrch.Text));
            else
                dt.DefaultView.RowFilter = string.Format("[Estado] like 'Activo'");

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

            var dt = (DataTable)dgvProductos.DataSource;
            if (txtNombreSrch.Text != "")
                dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '{0}*' and [Estado] like 'Activo'", txtNombreSrch.Text);
            else
                dt.DefaultView.RowFilter = string.Format("[Estado] like 'Activo'");

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
            txtNombreSrch.Text = "";
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

        private void txtNombreSrch_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
            txtIdSrch.Text = "";
            if (txtNombreSrch.Text != "")
                (dgvProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}'", txtNombreSrch.Text);
            else
                (dgvProductos.DataSource as DataTable).DefaultView.RowFilter = null;

            dgvProductos.Refresh();
            if ((dgvProductos.DataSource as DataTable).DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtNombreSrch, 0, 25, 3000);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                suma =double.Parse(txtSubtotal.Text) - double.Parse(dgvProductList.SelectedRows[0].Cells[2].Value.ToString()) * double.Parse(dgvProductList.SelectedRows[0].Cells[3].Value.ToString());
                dgvProductList.Rows.RemoveAt(dgvProductList.SelectedRows[0].Index);
                txtSubtotal.Text = "" + suma;
                txtDescuento.Text = suma * descuento + "";
                txtTotal.Text = (suma - double.Parse(txtDescuento.Text)) * 0.15 + (suma - double.Parse(txtDescuento.Text)) + "";
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

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chkEdad_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEdad.Checked)
                descuento = 0.4;

                
            else
                descuento = 0;
            txtDescuento.Text = suma * descuento + "";
            txtTotal.Text = suma + ((suma - (suma * descuento)) * 0.15)
                - (suma * descuento) + "";
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreSrch_Enter(object sender, EventArgs e)
        {
            txtIdSrch.Text = "";
        }

        private void txtIdSrch_Enter(object sender, EventArgs e)
        {
            txtNombreSrch.Text = "";
        }
    }
}
