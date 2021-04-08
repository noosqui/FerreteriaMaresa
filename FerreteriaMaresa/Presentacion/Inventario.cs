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
  
            inventario.Nom_Proveedor = cbbProveedor.Text;
            inventario.Nom_producto = txtNomInventario.Text;
            inventario.Marca = cbbMarca.Text;
            inventario.Costo_producto = double.Parse(txtCompra.Text);
            inventario.Precio_actual = double.Parse(txtVenta.Text);
            inventario.Stock = int.Parse(cbbStock.Text);
            inventario.Estado = cbbEstado.Text;
            inventario.Categoria = cbbCategorias.Text;
            MessageBox.Show("Producto registrado con exito");

        }



        private void Inventario_Load(object sender, System.EventArgs e)
        {
            var fuente = new BindingSource();
            fuente.DataSource = inventario.mostrar_inventario();

            dgvInventario.DataSource = fuente;
            dgvInventario.Rows[1].Selected = true;
            
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventario.CurrentRow.Selected = true;
        }

        private void btnActivos_Click(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Activo");

        }
        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre Producto] LIKE '%{0}%'", txtnombre.Text);
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

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInactivos_Click(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Inactivo");
        }

        private void txtcodigo_TextChanged_1(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
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
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
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
            LetraNum.SoloNumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetraNum.SoloLetras(e);
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Marca] LIKE '%{0}%'", cmbMarca.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.cmbMarca, 0, 25, 3000);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Categoría] LIKE '%{0}%'", cmbCategoria.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.cmbCategoria, 0, 25, 3000);
            }
        }
   
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Estado1 == true)
            {
                try
                {
                    inventario.crear_inventario(txtid.Text, txtNomInventario.Text, cbbProveedor.Text, cbbMarca.Text, txtCompra.Text, txtVenta.Text, cbbStock.Text, cbbEstado.Text, cbbCategorias.Text);
                }
                catch
                {

                }
            }

            if (Estado2 == true)
            {
                try
                {
                    inventario.modificar_inventario(txtid.Text, txtNomInventario.Text, cbbProveedor.Text, cbbMarca.Text, txtCompra.Text, txtVenta.Text, cbbStock.Text, cbbEstado.Text, cbbCategorias.Text);
                }
                catch
                {

                }
            }

            if (Estado3 == true)
            {
                try
                {
                    inventario.eliminar_Producto(txtid.Text);
                }
                catch
                {

                }
            }

            Regristro_inventario();
            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);
            la.Visible = false;
            txtid.Enabled = false;
            txtid.Visible = false;
            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);

            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;
            btnGuardar.Visible = false;
            btnmodificar.Enabled = true;

            Estado1 = false;
            Estado2 = false;
            Estado3 = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Lim_ha encender = new Lim_ha();
            encender.Encender(this);
            Estado3 = true;
            la.Visible = true;
            txtid.Enabled = true;
            txtid.Visible = true;
            btnAgregar.Enabled = false;
            btnmodificar.Enabled = false;
            btnGuardar.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);
            Estado1 = true; 
            btnEliminar.Enabled = false;
            btnmodificar.Enabled = false;
            btnGuardar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = dgvAgregar.CurrentRow.Cells[0].Value.ToString();
            cbbProveedor.Text = dgvAgregar.CurrentRow.Cells[1].Value.ToString();
            cbbMarca.Text = dgvAgregar.CurrentRow.Cells[2].Value.ToString();
            txtCompra.Text = dgvAgregar.CurrentRow.Cells[3].Value.ToString();
            txtVenta.Text = dgvAgregar.CurrentRow.Cells[4].Value.ToString();
            cbbStock.Text = dgvAgregar.CurrentRow.Cells[5].Value.ToString();
            cbbEstado.Text = dgvAgregar.CurrentRow.Cells[6].Value.ToString();
            cbbCategorias.Text = dgvAgregar.CurrentRow.Cells[7].Value.ToString();
            dgvInventario.CurrentRow.Selected = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);
            Estado2 = true;
            la.Visible = true;
            txtid.Enabled = true;
            txtid.Visible = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
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
    }
}
