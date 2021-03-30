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
        string estado;
        string txtcodrol;
        bool estadobtna = false;
        bool estadobtnb = false;
        bool estadobtnc = false;

        private void roles()
        {
            cbcodrol.DataSource = emplea.roles_combobox();
            cbcodrol.DisplayMember = "descripcion";
            cbcodrol.ValueMember = "id_rol";
        }

        private void limpiar()
        {
            txtidentidad.Clear();
            cbcodrol.Text = "Seleccione";
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtciudad.Clear();
            txtregion.Clear();
            txtcodpost.Clear();
            txtpais.Clear();
            txttelefono.Clear();
            cbcodrol.SelectedIndex = 0;
            rbactivo.Checked = false;
            rbdespedido.Checked = false;
            dtfecha.ResetText();
        }

        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = emplea.CargarDGVEmpleados();
                dgvEmpleados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedieron cargar los Datos");
            }
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
            roles();
            cbcodrol.DropDownStyle = ComboBoxStyle.DropDownList;
            btnGuardar.Visible = false;
            btncancelar.Visible = false;
            txtbuscarid.Enabled = true;
            txtnombreemp.Enabled = true;
            dtfecha.MaxDate = DateTime.Today;
            cbcodrol.Text = "Seleccione";

            
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
            if (dgvEmpleados.CurrentRow.Cells[11].Value.ToString() == "Empleado")
            {
                cbcodrol.SelectedIndex = 0;
            }
            else
            {
                cbcodrol.SelectedIndex = 1;
            }
            dtfecha.Value = ((DateTime)dgvEmpleados.CurrentRow.Cells[12].Value);
            estado = dgvEmpleados.CurrentRow.Cells[13].Value.ToString();
            if (estado == "Activo")
            {
                rbactivo.Checked = true;
            }
            if (estado == "Despedido")
            {
                rbdespedido.Checked = true;
            }

            dgvEmpleados.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

            dgvEmpleados.Enabled = false;
            btnModificar.Visible=false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = true;
            btncancelar.Visible = true;

            estadobtna = true;
            estadobtnb = false;
            estadobtnc = false;

            cbcodrol.Text = "Seleccione";

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadobtna = false;
            estadobtnb = true;
            estadobtnc = false;

            btnAgregar.Visible = false;
            btnGuardar.Visible = true;
            btncancelar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            /*Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
            btncancelar.Visible = true;
            btnEliminar.Visible = false;
            
            estadobtna = false;
            estadobtnb = false;
            estadobtnc = true;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);
            btnGuardar.Text = "Borrar";
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            if (txtidentidad.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtdireccion.Text == "" ||
                txtciudad.Text == "" || txtregion.Text == "" || txtcodpost.Text == "" || txtpais.Text == "" ||
                txttelefono.Text == "" || txtcorreo.Text == "" || cbcodrol.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Dede llenar todos los Campos");
            }
            else
            {


                if (estadobtna == true)
                {

                    try
                    {


                        if (rbactivo.Checked)
                        {
                            estado = "Activo";
                        }
                        if (rbdespedido.Checked)
                        {
                            estado = "Despedido";
                        }

                        emplea.agregar_empleado(txtidentidad.Text, txtnombre.Text, txtapellido.Text, txtcorreo.Text,
                        txttelefono.Text,
                        txtdireccion.Text, txtciudad.Text, txtregion.Text, txtcodpost.Text, txtpais.Text, txtcodrol,
                        dtfecha.Value.ToString("dd/MM/yyyy"), estado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al Agregar Empleado");
                    }
                }
                if (estadobtnb == true)
                {
                    try
                    {
                        if (rbactivo.Checked)
                        {
                            estado = "Activo";
                        }
                        if (rbdespedido.Checked)
                        {
                            estado = "Despedido";
                        }

                        emplea.modificar_empleado(txtidentidad.Text, txtnombre.Text, txtapellido.Text, txtcorreo.Text,
                        txttelefono.Text,
                        txtdireccion.Text, txtciudad.Text, txtregion.Text, txtcodpost.Text, txtpais.Text, txtcodrol,
                        dtfecha.Value.ToString("dd/MM/yyyy"), estado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de Modificacion");
                    }
                }
                if (estadobtnc == true)
                {
                    
                    try
                    {
                        if (MessageBox.Show("¿Seguro que desea despedir el Empleado?", 
                            "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        emplea.eliminar_empleado(txtidentidad.Text);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al Eliminar el Empleado");
                    }
                }
                limpiar();
                btnAgregar.Visible = true;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                btnGuardar.Visible = false;
                btncancelar.Visible = false;
                dgvEmpleados.Enabled = true;
                dgvEmpleados.DataSource = emplea.CargarDGVEmpleados();
                dgvEmpleados.Refresh();

                Lim_ha apagar = new Lim_ha();
                apagar.Apagar(this);
            }
        }


        private void txtcodigoemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void btnrecontratar_Click(object sender, EventArgs e)
        {
            cbcodrol.Text = "Seleccione";
            limpiar();
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Text = "Guardar";
            btnGuardar.Visible = false;
            btncancelar.Visible = false;
            dgvEmpleados.Enabled = true;

            txtidentidad.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtcorreo.Enabled = false;
            txttelefono.Enabled = false;
            txtdireccion.Enabled = false;
            txtciudad.Enabled = false;
            txtregion.Enabled = false;
            txtcodpost.Enabled = false;
            txtpais.Enabled = false;
            cbcodrol.Enabled = false;
            dtfecha.Enabled = false;
            rbactivo.Enabled = false;
            rbdespedido.Enabled = false;

        }

        private void txtbuscarid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var bd = (BindingSource)dgvEmpleados.DataSource;
                var dt = (DataTable)bd.DataSource;
                if (txtbuscarid.Text != "")

                    dt.DefaultView.RowFilter = string.Format("[Identidad] LIKE '%{0}'", txtbuscarid.Text);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtidentidad.Text = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtapellido.Text = dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtcorreo.Text = dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString();
                txttelefono.Text = dgvEmpleados.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtdireccion.Text = dgvEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtciudad.Text = dgvEmpleados.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtregion.Text = dgvEmpleados.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtcodpost.Text = dgvEmpleados.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtpais.Text = dgvEmpleados.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (dgvEmpleados.CurrentRow.Cells[11].Value.ToString() == "Empleado")
                {
                    cbcodrol.SelectedIndex = 0;
                }
                else
                {
                    cbcodrol.SelectedIndex = 1;
                }
                dtfecha.Text = dgvEmpleados.Rows[e.RowIndex].Cells[12].Value.ToString();
                estado = dgvEmpleados.Rows[e.RowIndex].Cells[13].Value.ToString();
                if (estado == "Activo")
                {
                    rbactivo.Checked = true;
                }
                if (estado == "Despedido")
                {
                    rbdespedido.Checked = true;
                }
 
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error de Seleccion");
            }
        }

        private void cbcodrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcodrol = cbcodrol.SelectedValue.ToString();
        }

        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtcodpost_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }
    }
}
