using Dominio;
using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Presentacion

{
    public partial class Inventario : Form
    {
        private DOM_Inventario inventario = new DOM_Inventario();
        private DOM_Validacion LetraNum = new DOM_Validacion();
        private bool Estado1 = false;
        private bool Estado2 = false;
        private bool Estado3 = false;
        private int puesto;

        public Inventario(int puesto)
        {
            InitializeComponent();
            this.puesto = puesto;
            if (puesto == 1)
            {
                tabControl.Appearance = TabAppearance.FlatButtons;
                tabControl.ItemSize = new Size(0, 1);
                tabControl.SizeMode = TabSizeMode.Fixed;
            }
            tabControl.Enabled = false;
        }




        private void Inventario_Load(object sender, System.EventArgs e)
        {
            var agregar = inventario.mostrar_inventario();
            dgvAgregar.DataSource = agregar;
            dgvAgregar.Columns["Id Marca"].Visible = false;
            dgvAgregar.Columns["Id Categoría"].Visible = false;
            dgvAgregar.Columns["Id Proveedor"].Visible = false;
            dgvAgregar.Refresh();
            dgvAgregar.Rows[0].Selected = true;

            var Marca = inventario.mostrar_marca();
            dgvMarca.DataSource = Marca;
            dgvMarca.Refresh();
            dgvMarca.Rows[0].Selected = true;

            var Categoria = inventario.mostrar_categoria();
            dgvCategoria.DataSource = Categoria;
            dgvCategoria.Refresh();
            dgvCategoria.Rows[0].Selected = true;





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



            cmbMarcaAg.DataSource = marca;
            cmbMarcaAg.DisplayMember = "Marca";
            cmbMarcaAg.ValueMember = "Marca";
            cmbMarcaAg.AutoCompleteCustomSource = mar;
            cmbMarcaAg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMarcaAg.AutoCompleteSource = AutoCompleteSource.CustomSource;



            cmbCategoriaAg.DataSource = categoria;
            cmbCategoriaAg.DisplayMember = "Marca";
            cmbCategoriaAg.ValueMember = "Marca";
            cmbCategoriaAg.AutoCompleteCustomSource = cat;
            cmbCategoriaAg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategoriaAg.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmbProveedorAg.DataSource = proveedor;
            cmbProveedorAg.DisplayMember = "Nombre";
            cmbProveedorAg.ValueMember = "Nombre";
            cmbProveedorAg.AutoCompleteCustomSource = nom;
            cmbProveedorAg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProveedorAg.AutoCompleteSource = AutoCompleteSource.CustomSource;


            tabControl.Enabled = true;
            dgvAgregar_CellClick(null, null);
            dgvCategoria_CellClick(null, null);
            dgvMarca_CellClick(null, null);
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
            dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}%'", txtnombreInv.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombreInv, 0, 25, 3000);
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
            if (txtcodigoInv.Text != "")
            {
                dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigoInv.Text));
            }
            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtcodigoInv, 0, 25, 3000);
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
            LetraNum.SoloNumerosEnt(e);
            txtnombreInv.Visible = false;
            cmbMarcaInv.Visible = false;
            cmbCategoriaInv.Visible = false;
            lm.Visible = false;
            lc.Visible = false;
            ln.Visible = false;



        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            lm.Visible = false;
            lc.Visible = false;
            li.Visible = false;

            cmbMarcaInv.Visible = false;
            cmbCategoriaInv.Visible = false;
            txtcodigoInv.Visible = false;
            btncancelar.Visible = true;
            LetraNum.SoloLetras(e);
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var bd = (BindingSource)dgvInventario.DataSource;
            if (cmbMarcaInv.SelectedIndex != -1)
            {
                var dt = (DataTable)dgvInventario.DataSource;
                dt.DefaultView.RowFilter = string.Format("[Marca] LIKE '%{0}%'", cmbMarcaInv.Text);
                dgvInventario.Refresh();


                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.cmbMarcaInv, 0, 25, 3000);
                }

                lc.Visible = false;
                li.Visible = false;
                ln.Visible = false;
                txtnombreInv.Visible = false;

                cmbCategoriaInv.Visible = false;
                txtcodigoInv.Visible = false;
                btncancelar.Visible = true;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var bd = (BindingSource)dgvInventario.DataSource;
            if (cmbCategoriaInv.SelectedIndex != -1)
            {
                var dt = (DataTable)dgvInventario.DataSource;
                dt.DefaultView.RowFilter = string.Format("[Categoría] LIKE '%{0}%'", cmbCategoriaInv.Text);
                dgvInventario.Refresh();

                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.cmbCategoriaInv, 0, 25, 3000);
                }
                lm.Visible = false;

                li.Visible = false;
                ln.Visible = false;
                txtnombreInv.Visible = false;
                cmbMarcaInv.Visible = false;

                txtcodigoInv.Visible = false;
                btncancelar.Visible = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            dgvAgregar.Enabled = true;
            if (Estado1 == true)
            {

                try
                {
                    foreach (Control ctr in tabControl.TabPages[tabControl.SelectedIndex].Controls)
                    {
                        if (ctr is TextBox && ctr.Text.Trim() == "")
                        {
                            throw new Exception("No deje campos vacios");
                        }
                    }

                    if (txtStockAg.Text == "0" && txtStockAg.Text == "")
                    {

                    }
                    else if (txtStockAg.Text != "0" && txtStockAg.Text != "")
                    { MessageBox.Show("la cantidas debe ser 0"); txtStockAg.Text = ""; }

                    inventario.crear_inventario(((DataTable)cmbProveedorAg.DataSource).Rows[cmbProveedorAg.SelectedIndex][0].ToString(), txtNomInventarioAg.Text, ((DataTable)cmbMarcaAg.DataSource).Rows[cmbMarcaAg.SelectedIndex][0].ToString(), txtcantidad_unidadAg.Text, txtCompraAg.Text, txtVentaAg.Text, txtStockAg.Text, "Activo", ((DataTable)cmbCategoriaAg.DataSource).Rows[cmbCategoriaAg.SelectedIndex][0].ToString());


                    MessageBox.Show("Producto registrado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Producto no registra" + ex);
                    btnmodificarAg.Visible = true;
                    btnEliminarAg.Visible = true;
                    btnAgregarAg.Visible = true;
                }
            }

            if (Estado2 == true)
            {
                try
                {
                    foreach (Control ctr in tabControl.TabPages[tabControl.SelectedIndex].Controls)
                    {
                        if (ctr is TextBox && ctr.Text.Trim() == "")
                        {
                            throw new Exception("No deje campos vacios");
                        }
                    }

                    inventario.modificar_inventario(txtid.Text, ((DataTable)cmbProveedorAg.DataSource).Rows[cmbProveedorAg.SelectedIndex][0].ToString(), txtNomInventarioAg.Text, ((DataTable)cmbMarcaAg.DataSource).Rows[cmbMarcaAg.SelectedIndex][0].ToString(), txtcantidad_unidadAg.Text, txtCompraAg.Text, txtVentaAg.Text, txtStockAg.Text, "Activo", ((DataTable)cmbCategoriaAg.DataSource).Rows[cmbCategoriaAg.SelectedIndex][0].ToString());
                    MessageBox.Show("Producto modificado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Producto no modificado" + ex);
                    btnmodificarAg.Visible = true;
                    btnEliminarAg.Visible = true;
                    btnAgregarAg.Visible = true;
                }
            }

            if (Estado3 == true)
            {
                try
                {
                    inventario.eliminar_Producto(txtid.Text);

                    MessageBox.Show("Producto eliminado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Producto no eliminado" + ex);
                    btnmodificarAg.Visible = true;
                    btnEliminarAg.Visible = true;
                    btnAgregarAg.Visible = true;
                }
            }

            foreach (Control ctr in tabAgrega.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Enabled = false;
                }
            }

            btnmodificarAg.Visible = true;
            btnEliminarAg.Visible = true;
            btnAgregarAg.Visible = true;
            btnGuardarAg.Visible = false;
            btnCancelarAg.Visible = false;

            Estado1 = false;
            Estado2 = false;
            Estado3 = false;
            dgvAgregar.Rows[0].Selected = true;
            dgvAgregar_CellClick(null, null);
            Inventario_Load(null, null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtNomInventarioAg.Enabled = false;
            cmbProveedorAg.Enabled = false;
            cmbMarcaAg.Enabled = false;
            txtcantidad_unidadAg.Enabled = false;
            txtCompraAg.Enabled = false;
            txtVentaAg.Enabled = false;
            txtStockAg.Enabled = false;
            cmbEstadoAg.Enabled = false;
            cmbCategoriaAg.Enabled = false;


            Estado1 = false;
            Estado2 = false;
            Estado3 = true;

            la.Visible = true;
            dgvAgregar.Enabled = false;

            txtid.Visible = true;
            btnmodificarAg.Visible = false;
            btnAgregarAg.Visible = false;
            btnGuardarAg.Visible = true;
            btnCancelarAg.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            txtNomInventarioAg.Enabled = true;
            cmbProveedorAg.Enabled = true;
            cmbMarcaAg.Enabled = true;
            txtcantidad_unidadAg.Enabled = true;
            txtCompraAg.Enabled = true;
            txtVentaAg.Enabled = true;

            cmbEstadoAg.Enabled = true;
            cmbCategoriaAg.Enabled = true;

            txtNomInventarioAg.Clear();
            txtcantidad_unidadAg.Clear();
            txtCompraAg.Clear();
            txtVentaAg.Clear();
            txtStockAg.Clear();


            dgvAgregar.Enabled = false;


            Estado1 = true;
            Estado2 = false;
            Estado3 = false;
            btnmodificarAg.Visible = false;
            btnEliminarAg.Visible = false;

            btnGuardarAg.Visible = true;
            btnCancelarAg.Visible = true;
            txtStockAg.Text = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgregar.Rows.Count > 0)
            {
                txtid.Text = dgvAgregar.SelectedRows[0].Cells[0].Value.ToString();
                txtNomInventarioAg.Text = dgvAgregar.SelectedRows[0].Cells[1].Value.ToString();
                cmbProveedorAg.Text = dgvAgregar.SelectedRows[0].Cells[11].Value.ToString();
                cmbMarcaAg.Text = dgvAgregar.SelectedRows[0].Cells[7].Value.ToString();
                txtcantidad_unidadAg.Text = dgvAgregar.SelectedRows[0].Cells[2].Value.ToString();
                txtCompraAg.Text = dgvAgregar.SelectedRows[0].Cells[3].Value.ToString();
                txtVentaAg.Text = dgvAgregar.SelectedRows[0].Cells[4].Value.ToString();
                txtStockAg.Text = dgvAgregar.SelectedRows[0].Cells[5].Value.ToString();
                cmbEstadoAg.Text = dgvAgregar.SelectedRows[0].Cells[12].Value.ToString();
                cmbCategoriaAg.Text = dgvAgregar.SelectedRows[0].Cells[9].Value.ToString();

            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtNomInventarioAg.Enabled = true;
            cmbProveedorAg.Enabled = true;
            cmbMarcaAg.Enabled = true;
            txtcantidad_unidadAg.Enabled = true;
            txtCompraAg.Enabled = true;
            txtVentaAg.Enabled = true;
            txtStockAg.Enabled = false;
            cmbEstadoAg.Enabled = true;
            cmbCategoriaAg.Enabled = true;


            txtid.Enabled = false;

            Estado1 = false;
            Estado2 = true;
            Estado3 = false;
            la.Visible = true;
            dgvAgregar.Enabled = false;

            txtid.Visible = true;

            btnEliminarAg.Visible = false;
            btnAgregarAg.Visible = false;
            btnGuardarAg.Visible = true;
            btnCancelarAg.Visible = true;
        }

        private void txtNomInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumerosDec(e);

        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumerosDec(e);
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

            LetraNum.SoloNumerosEnt(e);


        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {




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
            LetraNum.SoloNumerosEnt(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloNumerosEnt(e);
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIdCategoriaCat.Text = dgvCategoria.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreCat.Text = dgvCategoria.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMarcaMar.Text = dgvMarca.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreMarcaMar.Text = dgvMarca.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            txtNombreMarcaMar.Enabled = true;

            dgvMarca.Enabled = false;
            txtNombreMarcaMar.Clear();
            txtIdMarcaMar.Clear();
            Estado1 = true;
            Estado2 = false;
            Estado3 = false;
            btnModificarMar.Visible = false;
            btnGuardarMar.Visible = true;
            btnCancelarMar.Visible = true;
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            txtNombreCat.Enabled = true;

            dgvCategoria.Enabled = false;
            txtNombreCat.Clear();
            txtIdCategoriaCat.Clear();
            Estado1 = true;
            Estado2 = false;
            Estado3 = false;

            btnGuardarCat.Visible = true;
            btnCancelarCat.Visible = true;
            btnModificarCat.Visible = false;
            //btnEliminarCat.Visible = false;
        }

        private void btnModificarM_Click(object sender, EventArgs e)
        {
            txtNombreMarcaMar.Enabled = true;
            dgvMarca.Enabled = false;
            Estado2 = true;
            btnAgregarMar.Visible = false;
            btnGuardarMar.Visible = true;
            btnCancelarMar.Visible = true;
        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            txtNombreCat.Enabled = true;
            btnCancelarCat.Visible = true;
            btnGuardarCat.Visible = true;
            btnAgregarCat.Visible = false;
            dgvCategoria.Enabled = false;

            Estado1 = false;
            Estado2 = true;
            Estado3 = false;
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            if (txtNombreMarcaMar.Text == "")
            {
                MessageBox.Show("Dede llenar todos los Campos");
            }
            else
            {

                if (Estado1 == true)
                {
                    try
                    {
                        foreach (Control ctr in tabControl.TabPages[tabControl.SelectedIndex].Controls)
                        {
                            if (ctr is TextBox && ctr.Text.Trim() == "")
                            {
                                throw new Exception("No deje campos vacios");
                            }
                        }

                        inventario.crear_Marca(txtNombreMarcaMar.Text);
                        MessageBox.Show("Marca registrada con exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Marca no registrada" + ex);
                        btnModificarMar.Visible = true;
                        btnAgregarMar.Visible = true;
                    }
                }

                if (Estado2 == true)
                {
                    try
                    {
                        foreach (Control ctr in tabControl.TabPages[tabControl.SelectedIndex].Controls)
                        {
                            if (ctr is TextBox && ctr.Text.Trim() == "")
                            {
                                throw new Exception("No deje campos vacios");
                            }
                        }

                        inventario.modificarMarca(txtIdMarcaMar.Text, txtNombreMarcaMar.Text);

                        MessageBox.Show("Marca modificado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Marca no modificada" + ex);
                        btnModificarMar.Visible = true;
                        btnAgregarMar.Visible = true;
                    }
                }

            }
            txtNombreMarcaMar.Enabled = false;
            txtIdMarcaMar.Enabled = false;
            dgvMarca.Enabled = true;
            txtNombreMarcaMar.Clear();
            txtIdMarcaMar.Clear();

            btnModificarMar.Visible = true;
            btnAgregarMar.Visible = true;
            btnGuardarMar.Visible = false;
            Inventario_Load(null, null);




        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if (txtNombreCat.Text == "")
            {
                MessageBox.Show("Dede llenar todos los Campos");
            }
            else
            {


                if (Estado1 == true)
                {
                    try
                    {

                        inventario.crear_Categoria(txtNombreCat.Text);


                        MessageBox.Show("Categoria registrada con exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Categoria no registrada" + ex);
                        btnModificarCat.Visible = true;
                        btnAgregarCat.Visible = true;
                    }
                }

                if (Estado2 == true)
                {
                    try
                    {
                        inventario.modificarCategoria(txtIdCategoriaCat.Text, txtNombreCat.Text);
                        MessageBox.Show("Categoria modificado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Categoria no modificada" + ex);
                        btnModificarCat.Visible = true;
                        btnAgregarCat.Visible = true;
                    }
                }
                txtNombreCat.Enabled = false;
                txtIdCategoriaCat.Enabled = false;
                dgvCategoria.Enabled = true;
                txtNombreCat.Clear();
                txtIdCategoriaCat.Clear();

                btnModificarCat.Visible = true;
                btnAgregarCat.Visible = true;
                btnGuardarCat.Visible = false;
                Inventario_Load(null, null);




            }
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

            lc.Visible = false;
            li.Visible = false;
            ln.Visible = false;
            txtnombreInv.Visible = false;

            cmbCategoriaInv.Visible = false;
            txtcodigoInv.Visible = false;
            btncancelar.Visible = true;
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            lm.Visible = false;

            li.Visible = false;
            ln.Visible = false;
            txtnombreInv.Visible = false;
            cmbMarcaInv.Visible = false;

            txtcodigoInv.Visible = false;
            btncancelar.Visible = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            txtnombreInv.Visible = true;
            cmbMarcaInv.Visible = true;
            cmbCategoriaInv.Visible = true;
            txtcodigoInv.Visible = true;
            lm.Visible = true;
            lc.Visible = true;
            li.Visible = true;
            ln.Visible = true;
            btncancelar.Visible = false;
            cmbCategoriaInv.SelectedIndex = -1;
            cmbMarcaInv.SelectedIndex = -1;
            var dt = (DataTable)dgvInventario.DataSource;
            dt.DefaultView.RowFilter = null;

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estado1 = false;
            Estado2 = false;
            Estado3 = false;
            btncancelar_Click(null, null);
            btnCancelarAg_Click(null, null);
            btnCancelarMar_Click(null, null);

        }

        private void btnCancelarAg_Click(object sender, EventArgs e)
        {
            this.btnAgregarAg.Visible = true;
            this.btnmodificarAg.Visible = true;
            this.btnEliminarAg.Visible = true;
            this.btnCancelarAg.Visible = false;
            this.btnGuardarAg.Visible = false;
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Text == tabAgrega.Text)
                {
                    foreach (Control ctr in tabPage.Controls)
                    {
                        if (ctr is TextBox || ctr is ComboBox)
                        {
                            ctr.Enabled = false;
                        }
                    }
                }
            }

            Lim_ha limpiar = new Lim_ha();
            dgvAgregar.Rows[0].Selected = true;
            dgvAgregar_CellClick(null, null);
            dgvAgregar.Enabled = true;

            if (Estado1 || Estado2)
            {
                limpiar.Apagar(this.tabAgrega);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelarMar_Click(object sender, EventArgs e)
        {
            txtIdMarcaMar.Enabled = false;
            txtNombreMarcaMar.Enabled = false;
            btnGuardarMar.Visible = false;
            btnAgregarMar.Visible = true;
            btnModificarMar.Visible = true;
            //btnEliminarMar.Visible = true;
            btnCancelarMar.Visible = false;
            dgvMarca.Enabled = true;
        }

        private void btnEliminarMar_Click(object sender, EventArgs e)
        {
            btnCancelarMar.Visible = true;
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            Estado1 = false;
            Estado2 = false;
            Estado3 = false;
            txtNombreCat.Enabled = false;
            btnAgregarCat.Visible = true;
            btnModificarCat.Visible = true;
            btnGuardarCat.Visible = false;
            btnCancelarCat.Visible = false;
            //btnEliminarCat.Visible = true;
            dgvCategoria.Enabled = true;

        }
    }
}
