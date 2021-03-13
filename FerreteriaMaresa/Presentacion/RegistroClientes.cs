using System.Data;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {
        private Clientes c = new Clientes();
        DOM_Validacion letrasNum = new DOM_Validacion();
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void habilitar_Click_1(object sender, System.EventArgs e)
        {
            btnGuardar.Visible = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;

            nombre.Enabled = false;
            Apellido.Enabled = false;
            rtn.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            rtn.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            rtn.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;

        }


        private void RegistroClientes_Load(object sender, System.EventArgs e)
        {
            var fuente = new BindingSource();
            fuente.DataSource = c.Mostrar_Cliente();
            dgvClientes.DataSource = fuente;
            dgvClientes.Rows[1].Selected = true;

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.CurrentRow.Selected = true;
            nombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            rtn.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
        }


        private void txtnombrecli_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void txtcodigocli_TextChanged(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvClientes.DataSource;
            var dt = (DataTable)bd.DataSource;
            if (txtcodigocli.Text != "")

                dt.DefaultView.RowFilter = string.Format("[Id Cliente] = {0}", int.Parse(txtcodigocli.Text));

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvClientes.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Codigo del Cliente",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtnombrecli_TextChanged_1(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvClientes.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre Cliente] LIKE '%{0}%'", txtnombrecli.Text);
            dgvClientes.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Nombre del Cliente",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcodigocli_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtnombrecli_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }
    }
}
