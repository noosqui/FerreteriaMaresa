using System;
using System.Data;
using System.Text;
using Dominio;
using System.Windows.Forms;


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

        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre Producto] LIKE '%{0}%'", txtnombre.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Nombre del Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                MessageBox.Show("No se encontró el Codigo del Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
