using System;
using System.Data;
using System.Text;
using Dominio;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace Presentacion

{
    public partial class Inventario : Form
    {

        DOM_Inventario inventario = new DOM_Inventario();
        DOM_Validacion LetraNum = new DOM_Validacion();
        bool Estado1 = false;
        bool Estado2 = false;
        bool Estado3 = false;

        public Inventario()
        {
            InitializeComponent();
        }

        public void Regristro_inventario()
        {

            


        }



        private void Inventario_Load(object sender, System.EventArgs e)
        {
            var agregar = inventario.mostrar_inventario();
            dgvAgregar.DataSource = agregar;
            dgvAgregar.Columns["Id Marca"].Visible = false;
            dgvAgregar.Columns["Id Categoría"].Visible = false;
            dgvAgregar.Columns["Id Proveedor"].Visible = false;
            dgvAgregar.Refresh();
            dgvAgregar.Rows[1].Selected = true;

            var Marca = inventario.mostrar_marca();
            dgvMarca.DataSource = Marca;
            dgvMarca.Refresh();
            dgvMarca.Rows[1].Selected = true;

            var Categoria = inventario.mostrar_categoria();
            dgvCategoria.DataSource = Categoria;
            dgvCategoria.Refresh();
            dgvCategoria.Rows[1].Selected = true;





            var producto = inventario.mostrar_inventario();
            var marca = inventario.mostrar_marca();
            var categoria = inventario.mostrar_categoria();
            var proveedor = inventario.mostrar_proveedor();
            AutoCompleteStringCollection mar = new AutoCompleteStringCollection();
            AutoCompleteStringCollection nom = new AutoCompleteStringCollection();
            AutoCompleteStringCollection cat = new AutoCompleteStringCollection();
            dgvInventario.DataSource = producto;
            dgvInventario.Columns["Id Marca"].Visible = false;
            dgvInventario.Columns["Id Categoría"].Visible = false;
            dgvInventario.Columns["Id Proveedor"].Visible = false;
            dgvInventario.Refresh();
            dgvInventario.Rows[1].Selected = true;
            dgvInventario.CurrentRow.Selected = true;
            dgvInventario_CellClick(null, null);
            
            

             cbbMarca.DataSource = marca;
             cbbMarca.DisplayMember = "Marca";
             cbbMarca.ValueMember = "Marca";
             cbbMarca.AutoCompleteCustomSource = mar;
             cbbMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
             cbbMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;



             cbbCategorias.DataSource = categoria;
             cbbCategorias.DisplayMember = "Marca";
             cbbCategorias.ValueMember = "Marca";
             cbbCategorias.AutoCompleteCustomSource = cat;
             cbbCategorias.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
             cbbCategorias.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbbProveedor.DataSource = proveedor;
            cbbProveedor.DisplayMember = "Nombre";
            cbbProveedor.ValueMember = "Nombre";
            cbbProveedor.AutoCompleteCustomSource = nom;
            cbbProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
            


        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventario.CurrentRow.Selected = true;
        }

        private void btnActivos_Click(object sender, System.EventArgs e)
        {
            //var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '{0}'", "ACTIVO");

        }
        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {
            //var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}%'", txtnombre.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombre, 0, 25, 3000);
            }
        }

        private void btnActivos_StyleChanged(object sender, System.EventArgs e)
        {

        }

        private void btnInactivos_Click(object sender, System.EventArgs e)
        {
            //var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Inactivo");
        }

        private void txtcodigo_TextChanged_1(object sender, EventArgs e)
        {
            
            
            btncancelar.Visible = true;
            //var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            if(txtcodigo.Text != "")

            dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigo.Text));

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtcodigo, 0, 25, 3000);
            }
        }

        private void btnTodos_Click(object sender, System.EventArgs e)
        {
            //var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Activo", "Inactivo");
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", btnTodos, 0, btnTodos.Height, 3000);
            }
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            btncancelar.Visible = true;
            LetraNum.SoloNumeros(e);
            txtnombre.Visible = false;
            cmbMarca.Visible = false;
            cmbCategoria.Visible = false;
            lm.Visible = false;
            lc.Visible = false;
            ln.Visible = false;

            
            
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            lm.Visible = false;
            lc.Visible = false;
            li.Visible = false;
            
            cmbMarca.Visible = false;
            cmbCategoria.Visible = false;
            txtcodigo.Visible = false;
            btncancelar.Visible = true;
            LetraNum.SoloLetras(e);
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Marca] LIKE '%{0}%'", cmbMarca.Text);
            dgvInventario.Refresh();
            

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.cmbMarca, 0, 25, 3000);
            }

            lc.Visible = false;
            li.Visible = false;
            ln.Visible = false;
            txtnombre.Visible = false;

            cmbCategoria.Visible = false;
            txtcodigo.Visible = false;
            btncancelar.Visible = true;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Categoría] LIKE '%{0}%'", cmbCategoria.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.cmbCategoria, 0, 25, 3000);
            }
            lm.Visible = false;

            li.Visible = false;
            ln.Visible = false;
            txtnombre.Visible = false;
            cmbMarca.Visible = false;

            txtcodigo.Visible = false;
            btncancelar.Visible = true;
        }
   
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            dgvAgregar.Enabled = true;
            if (Estado1 == true)
            {
                try
                {

                    if (txtStock.Text == "0" && txtStock.Text == "")
                    {

                    }
                    else if (txtStock.Text != "0" && txtStock.Text != "")
                    { MessageBox.Show("la cantidas debe ser 0"); txtStock.Text = ""; }

                    inventario.crear_inventario(((DataTable)cbbProveedor.DataSource).Rows[cbbProveedor.SelectedIndex][0].ToString(), txtNomInventario.Text, ((DataTable)cbbMarca.DataSource).Rows[cbbMarca.SelectedIndex][0].ToString(), txtcantidad_unidad.Text, txtCompra.Text, txtVenta.Text, txtStock.Text, "Activo", ((DataTable)cbbCategorias.DataSource).Rows[cbbCategorias.SelectedIndex][0].ToString());

                 
                    MessageBox.Show("Producto registrado con exito");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Producto no registra" + ex);
                    btnmodificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnAgregar.Visible = true;
                }
            }

            if (Estado2 == true)
            {
                try
                {
                    if (txtStock.Text == "0" && txtStock.Text == "")
                    {

                    }
                    else if (txtStock.Text != "0" && txtStock.Text != "")
                    { MessageBox.Show("la cantidas debe ser 0"); txtStock.Text = ""; }

                    inventario.modificar_inventario(txtid.Text,((DataTable)cbbProveedor.DataSource).Rows[cbbProveedor.SelectedIndex][0].ToString(), txtNomInventario.Text, ((DataTable)cbbMarca.DataSource).Rows[cbbMarca.SelectedIndex][0].ToString(), txtcantidad_unidad.Text, txtCompra.Text, txtVenta.Text, txtStock.Text, "Activo", ((DataTable)cbbCategorias.DataSource).Rows[cbbCategorias.SelectedIndex][0].ToString());
                    MessageBox.Show("Producto modificado");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Producto no modificado" + ex);
                    btnmodificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnAgregar.Visible = true;
                }
            }

            if (Estado3 == true)
            {
                try
                {
                    inventario.eliminar_Producto(txtid.Text);
                    
                    MessageBox.Show("Producto eliminado con exito");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Producto no eliminado" + ex);
                    btnmodificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnAgregar.Visible = true;
                }
            }

            
            txtNomInventario.Enabled = true;
            cbbProveedor.Enabled = true;
            cbbMarca.Enabled = true;
            txtcantidad_unidad.Enabled = true;
            txtCompra.Enabled = true;
            txtVenta.Enabled = true;
            txtStock.Enabled = true;
            cbbEstado.Enabled = true;
            cbbCategorias.Enabled = true;

            txtNomInventario.Clear();
            txtcantidad_unidad.Clear();
            txtCompra.Clear();
            txtVenta.Clear();
            txtStock.Clear();

            la.Visible = false;
            txtid.Enabled = false;
            txtid.Visible = false;
            
            btnmodificar.Visible = true;
            btnEliminar.Visible = true;
            btnAgregar.Visible= true;
            btnGuardar.Visible = false;
            

            Estado1 = false;
            Estado2 = false;
            Estado3 = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtNomInventario.Enabled = false;
            cbbProveedor.Enabled = false;
            cbbMarca.Enabled = false;
            txtcantidad_unidad.Enabled = false;
            txtCompra.Enabled = false;
            txtVenta.Enabled = false;
            txtStock.Enabled = false;
            cbbEstado.Enabled = false;
            cbbCategorias.Enabled = false;


            Estado3 = true;
            la.Visible = true;
            dgvAgregar.Enabled = false;
            
            txtid.Visible = true;
            btnmodificar.Visible = false;
            btnAgregar.Visible = false;
            btnGuardar.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            txtNomInventario.Enabled = true;
            cbbProveedor.Enabled = true;
            cbbMarca.Enabled = true;
            txtcantidad_unidad.Enabled = true;
            txtCompra.Enabled = true;
            txtVenta.Enabled = true;
            txtStock.Enabled = true;
            cbbEstado.Enabled = true;
            cbbCategorias.Enabled = true;

            txtNomInventario.Clear();
            txtcantidad_unidad.Clear();
            txtCompra.Clear();
            txtVenta.Clear();
            txtStock.Clear();
            

            dgvAgregar.Enabled = false;
           
            
            Estado1 = true;
            btnmodificar.Visible = false;
            btnEliminar.Visible = false;
           
            btnGuardar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtid.Text = dgvAgregar.CurrentRow.Cells[0].Value.ToString();
            txtNomInventario.Text = dgvAgregar.CurrentRow.Cells[1].Value.ToString();
            cbbProveedor.Text = dgvAgregar.CurrentRow.Cells[11].Value.ToString();
            cbbMarca.Text = dgvAgregar.CurrentRow.Cells[7].Value.ToString();
            txtcantidad_unidad.Text = dgvAgregar.CurrentRow.Cells[2].Value.ToString();
            txtCompra.Text = dgvAgregar.CurrentRow.Cells[3].Value.ToString();
            txtVenta.Text = dgvAgregar.CurrentRow.Cells[4].Value.ToString();
            txtStock.Text = dgvAgregar.CurrentRow.Cells[5].Value.ToString();
            cbbEstado.Text = dgvAgregar.CurrentRow.Cells[12].Value.ToString();
            cbbCategorias.Text = dgvAgregar.CurrentRow.Cells[9].Value.ToString();
            dgvAgregar.CurrentRow.Selected = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtNomInventario.Enabled = true;
            cbbProveedor.Enabled = true;
            cbbMarca.Enabled = true;
            txtcantidad_unidad.Enabled = true;
            txtCompra.Enabled = true;
            txtVenta.Enabled = true;
            txtStock.Enabled = true;
            cbbEstado.Enabled = true;
            cbbCategorias.Enabled = true;

            
            txtid.Enabled = false;
           
            Estado2 = true;
            la.Visible = true;
            dgvAgregar.Enabled = false;
            
            txtid.Visible = true;
            
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void txtNomInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void cbbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventario.CurrentRow.Selected = true;
        }

       

        private void txtNomInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {

            LetraNum.SoloNumeros(e);
           
            
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            
            
                
            
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void txtcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }

        private void txtIdMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumeros(e);
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtIdCategoria.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            txtNombreC.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            
            dgvCategoria.CurrentRow.Selected = true;
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMarca.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString();
            txtNombreMarca.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();

            dgvMarca.CurrentRow.Selected = true;
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            txtNombreMarca.Enabled = true;
            
            dgvMarca.Enabled = false;
            txtNombreMarca.Clear();
            txtIdMarca.Clear();
            Estado1 = true;
            btnModificarM.Visible = false;
            btnGuardarM.Visible = true;
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            txtNombreC.Enabled = true;
            
            dgvCategoria.Enabled = false;
            txtNombreC.Clear();
            txtIdCategoria.Clear();
            Estado1 = true;
            btnModificarC.Visible = false;
            btnGuardarC.Visible = true;
        }

        private void btnModificarM_Click(object sender, EventArgs e)
        {
            txtNombreMarca.Enabled = true;
            
            dgvMarca.Enabled = false;

            Estado2 = true;
            btnAgregarM.Visible = false;
            btnGuardarM.Visible = true;
        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            txtNombreC.Enabled =true;
           
            dgvCategoria.Enabled = false;
            
            Estado2 = true;
            btnAgregarC.Visible = false;
            btnGuardarC.Visible = true;
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            if (txtNombreMarca.Text == "")
            {
                MessageBox.Show("Dede llenar todos los Campos");
            }
            else
            {

                if (Estado1 == true)
                {
                    try
                    {

                        inventario.crear_Marca(txtNombreMarca.Text);
                        MessageBox.Show("Marca registrada con exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Marca no registrada" + ex);
                        btnModificarM.Visible = true;
                        btnAgregarM.Visible = true;
                    }
                }

                if (Estado2 == true || txtIdMarca.Text == "")
                {
                    try
                    {
                        inventario.modificarMarca(txtIdMarca.Text, txtNombreMarca.Text);

                        MessageBox.Show("Marca modificado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Marca no modificada" + ex);
                        btnModificarM.Visible = true;
                        btnAgregarM.Visible = true;
                    }
                }

            }
            txtNombreMarca.Enabled =false;
            txtIdMarca.Enabled =false;
            dgvMarca.Enabled = true;
            txtNombreMarca.Clear();
            txtIdMarca.Clear();

            btnModificarM.Visible = true;
            btnAgregarM.Visible = true;
            btnGuardarM.Visible = false;


            


        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if (txtNombreC.Text == "")
            {
                MessageBox.Show("Dede llenar todos los Campos");
            }
            else
            {


                if (Estado1 == true)
            {
                try
                {
                     inventario.crear_Categoria(txtNombreC.Text);

                    
                    MessageBox.Show("Categoria registrada con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Categoria no registrada" + ex);
                    btnModificarC.Visible = true;
                    btnAgregarC.Visible = true;
                }
            }

                if (Estado2 == true || txtIdCategoria.Text == "")
                {
                    try
                    {
                        inventario.modificarCategoria(txtIdCategoria.Text, txtNombreC.Text);


                        MessageBox.Show("Categoria modificado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Categoria no modificada" + ex);
                        btnModificarC.Visible = true;
                        btnAgregarC.Visible = true;
                    }
                }
            txtNombreC.Enabled = false;
            txtIdCategoria.Enabled = false;
            dgvCategoria.Enabled = true;
            txtNombreC.Clear();
            txtIdCategoria.Clear();

            btnModificarC.Visible = true;
            btnAgregarC.Visible = true;
            btnGuardarC.Visible = false;



            
            }
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            lc.Visible = false;
            li.Visible = false;
            ln.Visible = false;
            txtnombre.Visible = false;
            
            cmbCategoria.Visible = false;
            txtcodigo.Visible = false;
            btncancelar.Visible = true;
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            lm.Visible = false;
            
            li.Visible = false;
            ln.Visible = false;
            txtnombre.Visible = false;
            cmbMarca.Visible = false;
            
            txtcodigo.Visible = false;
            btncancelar.Visible = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
            txtnombre.Visible = true;
            cmbMarca.Visible = true;
            cmbCategoria.Visible = true;
            txtcodigo.Visible = true;
            
            

            lm.Visible = true;
            lc.Visible = true;
            li.Visible = true;
            ln.Visible = true;
            txtnombre.Clear();
            
            txtcodigo.Clear();
            btncancelar.Visible = false;
        }
    }
}
