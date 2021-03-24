using System.Data;
using System.Windows.Forms;
using Dominio;
using System.Media;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {

        DOM_Validacion letrasNum = new DOM_Validacion();
        private DOM_Clientes c = new DOM_Clientes();

        public RegistroClientes()
        {
            InitializeComponent();
        }

        public void Regristro_Cliente()
        {
           /* c.Id = int.Parse(txtID.Text);
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = rtn.Text;
            c.Telefono = txtTelefono.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_postal = int.Parse(txtCodPost.Text);
            c.Pais = txtPais.Text;
            c.crear_Cliente();
            MessageBox.Show("Cliente registrado con exito");
            dgvClientes.Refresh();*/
        }

        public void Editar_Cliente() {
/*
            c.Id = int.Parse(txtID.Text);
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = rtn.Text;
            c.Telefono = txtTelefono.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_postal = int.Parse(txtCodPost.Text);
            c.Pais = txtPais.Text;
            c.editar_Clientes();
            MessageBox.Show("Cliente editado con exito");
            dgvClientes.Refresh();
*/
        }

    /*    public void buscar_empleado() {
            c.Id = int.Parse(txtID.Text);
            c.Buscar_Cliente();
            dgvClientes.Refresh();
        }*/

        private void habilitar_Click_1(object sender, System.EventArgs e)
        {
            btnGuardar.Visible = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;
            dgvClientes.Enabled = true;

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);
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
            dgvClientes.Enabled = false;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

        }


        private void RegistroClientes_Load(object sender, System.EventArgs e)
        {
            var fuente = new BindingSource();
            fuente.DataSource = c.Mostrar_Cliente();
            dgvClientes.DataSource = fuente;
            dgvClientes.Refresh();
            dgvClientes.Rows[1].Selected = true;

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
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtcodigocli, 0, 25, 3000);
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
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombrecli, 0, 25, 3000);
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
