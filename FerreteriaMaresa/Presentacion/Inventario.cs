using System.Windows.Forms;
using Dominio;
namespace Presentacion
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        public DOM_Inventario inventario = new DOM_Inventario();


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
        }

        private void Inventario_Load(object sender, System.EventArgs e)
        {
            var fuente = new BindingSource();
            fuente.DataSource = inventario.mostrar_inventario();
            dgvEmpleados.DataSource = fuente;
        }
    }
}
