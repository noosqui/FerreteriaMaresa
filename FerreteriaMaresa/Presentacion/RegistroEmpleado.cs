using System;
using System.Data;
using System.Windows.Forms;
using Dominio;
using System.Media;

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

        public void Registro_Empleado()
        {
            emplea.Id_empleado = txtidentidad.Text;
            emplea.Nombre = txtnombre.Text;
            emplea.Apellido = txtapellido.Text;
            emplea.Correo = txtcorreo.Text;
            emplea.Telefono = txttelefono.Text;
            emplea.Direccion = txtdireccion.Text;
            emplea.Ciudad = txtciudad.Text;
            emplea.Region = txtregion.Text;
            emplea.CodPostal = txtcodpost.Text;
            emplea.Pais = txtpais.Text;
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
            emplea.Nombre = txtnombre.Text;
            emplea.Apellido = txtapellido.Text;
            emplea.Correo = txtcorreo.Text;
            emplea.Telefono = txttelefono.Text;
            emplea.Direccion = txtdireccion.Text;
            emplea.Ciudad = txtciudad.Text;
            emplea.Region = txtregion.Text;
            emplea.CodPostal = txtcodpost.Text;
            emplea.Pais = txtpais.Text;
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

            dgvEmpleados.CurrentRow.Selected = true;
            txtidentidad.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtcorreo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtdireccion.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtciudad.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtregion.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtcodpost.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtpais.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
            txtcodrol.Text = dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
            dtfechan.Value = ((DateTime)dgvEmpleados.CurrentRow.Cells[12].Value);
            txtestado.Text = dgvEmpleados.CurrentRow.Cells[13].Value.ToString();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            dgvEmpleados.Enabled = false;
            dtfechan.Enabled = true;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);


        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;
            dtfechan.Enabled = true;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

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
            dgvEmpleados.Enabled = true;

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);

            Despedir_Empleado();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpleados.CurrentRow.Selected = true;
            txtidentidad.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtcorreo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtdireccion.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtciudad.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtregion.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtcodpost.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtpais.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
            txttelefono.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtcodrol.Text = dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
            dtfechan.Value = ((DateTime)dgvEmpleados.CurrentRow.Cells[12].Value);
            txtestado.Text = dgvEmpleados.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtbuscarid.Text == " " || txtnombreemp.Text == " ")
            {
                MessageBox.Show("Error al Agregar, no se pueden insertar Id de Productos iguales/duplicadas", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Buscar_Empleado();
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
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombreemp, 0, 25, 3000);
            }
        }


        private void txtnombreemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void btnrecontratar_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarid_TextChanged(object sender, EventArgs e)
        {
            var bd = (BindingSource)dgvEmpleados.DataSource;
            var dt = (DataTable)bd.DataSource;
            if (txtbuscarid.Text != "")

                dt.DefaultView.RowFilter = string.Format("[Identidad] LIKE '%{0}'", int.Parse(txtbuscarid.Text));

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvEmpleados.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombreemp, 0, 25, 3000);
            }
        }

        private void txtbuscarid_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }
    }
}
