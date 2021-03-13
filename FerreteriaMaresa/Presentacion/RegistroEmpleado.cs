using System;
using System.Data;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class RegistroEmpleado : Form
    {
        private DOM_Empleados emplea = new DOM_Empleados();
        DOM_Validacion letrasNum = new DOM_Validacion();
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            var tab = new BindingSource();
            tab.DataSource = emplea.Mostrar_Empleados();
            dgvEmpleados.DataSource = tab;
            dgvEmpleados.Refresh();
            dgvEmpleados.Rows[1].Selected = true;
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

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpleados.CurrentRow.Selected = true;
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

        private void txtcodigoemp_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvEmpleados.DataSource;
            var dt = (DataTable)bd.DataSource;
            if (txtcodigoemp.Text != "")

                dt.DefaultView.RowFilter = string.Format("[Identidad] LIKE '%{0}'", int.Parse(txtcodigoemp.Text));

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvEmpleados.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Codigo del Empleado",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtnombreemp_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvEmpleados.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombres] LIKE '%{0}%'", txtnombreemp.Text);
            dgvEmpleados.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró el Nombre del Empleado",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcodigoemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtnombreemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }
    }
}
