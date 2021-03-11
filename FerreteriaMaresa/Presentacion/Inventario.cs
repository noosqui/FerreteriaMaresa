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

        private DOM_Inventario inventario;


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            inventario.buscar_inventario();

            var fuente = new BindingSource();
            fuente.DataSource = inventario.mostrar_inventario();
            dgvEmpleados.DataSource = fuente;

            
        }
    }
}
