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
            btnMostrar.Enabled = false;
            btnhabilitar.Enabled = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            correo.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnhabilitar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnhabilitar.Enabled = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            correo.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnMostrar.Enabled = false;
            btnhabilitar.Enabled = true;
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            btnhabilitar.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnMostrar.Enabled = true;
            btnEliminar.Enabled = true;

            nombre.Enabled = false;
            Apellido.Enabled = false;
            correo.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;

        }
    }
}
