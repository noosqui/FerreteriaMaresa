using System;
using System.Data;
using System.Text;
using Dominio;
using System.Windows.Forms;
using System.Media;

namespace Presentacion

{
    public partial class Inventario : Form
    {

        DOM_Inventario inventario = new DOM_Inventario();
        DOM_Validacion letrasNum = new DOM_Validacion();

        public Inventario()
        {
            InitializeComponent();
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

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {

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
            letrasNum.SoloNumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

  
    }
}
