using System.Windows.Forms;
using Dominio;
using System.Media;
using System.Data;
namespace Presentacion

{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        public DOM_Inventario inventario = new DOM_Inventario();


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
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No se encontró el Producto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
