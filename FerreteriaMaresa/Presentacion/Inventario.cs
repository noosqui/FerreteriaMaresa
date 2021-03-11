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
    }
}
