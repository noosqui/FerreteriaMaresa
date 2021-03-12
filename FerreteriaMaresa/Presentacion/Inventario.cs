using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
                      
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigo.Text));
            dgvInventario.Refresh();

            //Para reiniciar dt.DefaultView.ROwFilter = null

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvInventario.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{1}%'", txtnombre.Text);
            dgvInventario.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
