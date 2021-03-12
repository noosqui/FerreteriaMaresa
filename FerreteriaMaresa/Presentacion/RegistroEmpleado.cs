using System;
using System.Data;
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
            direccion.Enabled = true;
            telefono.Enabled = true;

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
            direccion.Enabled = true;
            telefono.Enabled = true;
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
            direccion.Enabled = false;
            telefono.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvEmpleados.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigoemp.Text));
            dgvEmpleados.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtnombreemp_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvEmpleados.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{1}%'", txtnombreemp.Text);
            dgvEmpleados.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
