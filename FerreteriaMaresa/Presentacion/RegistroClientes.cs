using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {
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
<<<<<<< HEAD
=======
        }

        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnhabilitar.Enabled = true;
>>>>>>> upstream/Beta
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
<<<<<<< HEAD
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            rtn.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
=======
>>>>>>> upstream/Beta
        }
    }
}
