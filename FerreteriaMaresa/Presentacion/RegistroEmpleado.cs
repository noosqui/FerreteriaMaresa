using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            correo.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtRegion.Enabled = true;
            txtCodPost.Enabled = true;
            txtPais.Enabled = true;
            txtTelefono.Enabled = true;

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            correo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            correo.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtRegion.Enabled = true;
            txtCodPost.Enabled = true;
            txtPais.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;

            nombre.Enabled = false;
            Apellido.Enabled = false;
            correo.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtRegion.Enabled = false;
            txtCodPost.Enabled = false;
            txtPais.Enabled = false;
            txtTelefono.Enabled = false;

        }
    }
}
