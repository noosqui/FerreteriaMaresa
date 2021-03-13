using System;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class RegistroEmpleado : Form
    {
        private DOM_Empleados emplea = new DOM_Empleados();
     
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        public void Registro_Empleado()
        {
            emplea.Id_empleado = txtidentidad.Text;
            emplea.Nombre = nombre.Text;
            emplea.Apellido = Apellido.Text;
            emplea.Correo = correo.Text;
            emplea.Telefono = txtTelefono.Text;
            emplea.Direccion = txtDireccion.Text;
            emplea.Ciudad = txtCiudad.Text;
            emplea.Region = txtRegion.Text;
            emplea.CodPostal = txtCodPost.Text;
            emplea.Pais = txtPais.Text;
            emplea.Idrol = txtcodrol.Text;
            emplea.Fnacimiento = dtfechan.Text;
            emplea.Estado = txtestado.Text;
            emplea.crear_empleado();
            MessageBox.Show("Empleado agregado con exito");
            dgvEmpleados.Refresh();
        }

        public void Editar_Empleado()
        {
            emplea.Id_empleado = txtidentidad.Text;
            emplea.Nombre = nombre.Text;
            emplea.Apellido = Apellido.Text;
            emplea.Correo = correo.Text;
            emplea.Telefono = txtTelefono.Text;
            emplea.Direccion = txtDireccion.Text;
            emplea.Ciudad = txtCiudad.Text;
            emplea.Region = txtRegion.Text;
            emplea.CodPostal = txtCodPost.Text;
            emplea.Pais = txtPais.Text;
            emplea.Idrol = txtcodrol.Text;
            emplea.Fnacimiento = dtfechan.Text;
            emplea.Estado = txtestado.Text;
            emplea.Editar_Empleado();
            MessageBox.Show("Registro Exitoso");
            dgvEmpleados.Refresh();
        }

        public void Buscar_Empleado()
        {
            emplea.Id_empleado = txtbuscarid.Text;
            emplea.buscar_Empleados();
            dgvEmpleados.Refresh();
        }

        public void Despedir_Empleado()
        {
            emplea.Id_empleado = txtidentidad.Text;
            emplea.eliminar_empleado();
        }

        public void Recontratar_Empleado()
        {
            emplea.Id_empleado = txtidentidad.Text;
            emplea.Recontratar_empleado();
            dgvEmpleados.Refresh();

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
            txtidentidad.Enabled = true;
            txtestado.Enabled = true;
            txtcodrol.Enabled = true;
            dtfechan.Enabled = true;

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
            txtidentidad.Enabled = true;
            txtestado.Enabled = true;
            txtcodrol.Enabled = true;
            dtfechan.Enabled = true;
          
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
            txtidentidad.Enabled = false;
            txtestado.Enabled = false;
            txtcodrol.Enabled = false;
            dtfechan.Enabled = false;

            Despedir_Empleado();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpleados.CurrentRow.Selected = true;
            txtidentidad.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            nombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            correo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtCiudad.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtRegion.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtCodPost.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtPais.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtcodrol.Text = dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
            dtfechan.Text = dgvEmpleados.CurrentRow.Cells[12].Value.ToString();
            txtestado.Text = dgvEmpleados.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Empleado();
        }
    }
}
