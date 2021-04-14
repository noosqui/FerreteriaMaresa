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
        ToolTip tt = new ToolTip();
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
            txtconfirmarident.Clear();
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
            CargarDatos();
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
            var fuente = new BindingSource();
            dgvEmpleados.DataSource = fuente;

            CargarDatos();

            roles();
            cbcodrol.DropDownStyle = ComboBoxStyle.DropDownList;
            btnGuardar.Visible = false;
            btncancelar.Visible = false;
            txtbuscarid.Enabled = true;
            txtnombreemp.Enabled = true;
            dtfecha.MaxDate = DateTime.Today.AddYears(-18);

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
            DataGridViewColumn Column = dgvEmpleados.Columns[10];
            Column.Visible = false;
            dgvEmpleados.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblconfirmar.Visible = true;
            txtconfirmarident.Visible = true;
            txtbuscarid.Enabled = false;
            txtnombreemp.Enabled = false;
            txtconfirmarident.Enabled = true;
            rbactivo.Enabled = true;
            rbdespedido.Enabled = true;

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

            txtciudad.Text = "Tegucigalpa";
            txtpais.Text = "Honduras";
            txtcodpost.Text = "11101";
            txtregion.Text = "Francisco Morazan";

            txtciudad.Enabled = false;
            txtpais.Enabled = false;
            txtcodpost.Enabled = false;
            txtregion.Enabled = false;
            txtbuscarid.Enabled = true;
            txtnombreemp.Enabled = true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadobtna = false;
            estadobtnb = true;
            estadobtnc = false;
            txtbuscarid.Enabled = false;
            txtnombreemp.Enabled = false;
            btnAgregar.Visible = false;
            btnGuardar.Visible = true;
            btncancelar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            rbactivo.Enabled = true;
            rbdespedido.Enabled = true;
            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            txtidentidad.Enabled = false;
            txtciudad.Text = "Tegucigalpa";
            txtpais.Text = "Honduras";
            txtcodpost.Text = "11101";
            txtregion.Text = "Francisco Morazan";

            txtciudad.Enabled = false;
            txtpais.Enabled = false;
            txtcodpost.Enabled = false;
            txtregion.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
            btncancelar.Visible = true;
            btnEliminar.Visible = false;
            rbactivo.Enabled = true;
            rbdespedido.Enabled = true;

            estadobtna = false;
            estadobtnb = false;
            estadobtnc = true;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);
            btnGuardar.Text = "Despedir";
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            if (estadobtna == true)
                {
                    if (txtidentidad.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtdireccion.Text == "" ||
                        txttelefono.Text == "" || txtcorreo.Text == "" || cbcodrol.SelectedIndex.Equals(-1)
                        || txtidentidad.Text != txtconfirmarident.Text || txtconfirmarident.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los Campos y/o Verifique los Numeros de Identidad");
                    }
                    else if (txtidentidad.TextLength<13)
                    {
                        MessageBox.Show("La identidad debe tener al menos 13 numeros");
                    }
                    else if (txttelefono.TextLength < 8)
                    {
                        MessageBox.Show("Numero de Telefono incompleto, debe Ingresar 8 numeros");
                    }
                    
                    else
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
                            
                            emplea.agregar_empleado(txtidentidad.Text.ToString(), txtnombre.Text, txtapellido.Text, txtcorreo.Text,
                            txttelefono.Text, txtdireccion.Text, txtciudad.Text, txtregion.Text, txtcodpost.Text,
                            txtpais.Text, txtcodrol, dtfecha.Value.ToString("yyyy/MM/dd"), estado);

                            btnAgregar.Visible = true;
                            btnModificar.Visible = true;
                            btnEliminar.Visible = true;
                            btnGuardar.Visible = false;
                            btncancelar.Visible = false;
                            dgvEmpleados.Enabled = true;
                            lblconfirmar.Visible = false;
                            txtconfirmarident.Visible = false;
                            rbactivo.Enabled = false;
                            rbdespedido.Enabled = false;
                            limpiar();
                            dgvEmpleados.DataSource = emplea.CargarDGVEmpleados();
                            dgvEmpleados.Refresh();
                            Lim_ha apagar = new Lim_ha();
                            apagar.Apagar(this);
                    }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al Agregar Empleado/El numero de Identidad ya existe en la base de Datos");
                        }

                    }
                }

                if (estadobtnb == true)
                    {
                        if (txtidentidad.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtdireccion.Text == "" ||
                        txtciudad.Text == "" || txtregion.Text == "" || txtcodpost.Text == "" || txtpais.Text == "" ||
                        txttelefono.Text == "" || txtcorreo.Text == "" || cbcodrol.SelectedIndex.Equals(-1))
                        {
                            MessageBox.Show("Debe llenar todos los Campos");
                        }
                        else if (txttelefono.TextLength < 8)
                        {
                            MessageBox.Show("Numero de Telefono incompleto, debe Ingresar 8 numeros");
                        }
                        else
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

                                emplea.modificar_empleado(txtidentidad.Text, txtnombre.Text, txtapellido.Text, txtcorreo.Text, txttelefono.Text, 
                                    txtdireccion.Text, txtciudad.Text, txtregion.Text, txtcodpost.Text, txtpais.Text, txtcodrol,
                                    dtfecha.Value.ToString("dd/MM/yyyy"), estado);

                                btnAgregar.Visible = true;
                                btnModificar.Visible = true;
                                btnEliminar.Visible = true;
                                btnGuardar.Visible = false;
                                btncancelar.Visible = false;
                                dgvEmpleados.Enabled = true;
                                lblconfirmar.Visible = false;
                                txtconfirmarident.Visible = false;
                                rbactivo.Enabled = false;
                                rbdespedido.Enabled = false;
                                dgvEmpleados.DataSource = emplea.CargarDGVEmpleados();
                                dgvEmpleados.Refresh();
                                limpiar();
                                Lim_ha apagar = new Lim_ha();
                                apagar.Apagar(this);
                            }
                            catch (Exception ex)
                            {
                                    MessageBox.Show("Error de Modificacion"+ex);
                            }
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

                        btnAgregar.Visible = true;
                        btnModificar.Visible = true;
                        btnEliminar.Visible = true;
                        btnGuardar.Visible = false;
                        btncancelar.Visible = false;
                        dgvEmpleados.Enabled = true;
                        lblconfirmar.Visible = false;
                        txtconfirmarident.Visible = false;
                        rbactivo.Enabled = false;
                        rbdespedido.Enabled = false;
                        dgvEmpleados.DataSource = emplea.CargarDGVEmpleados();
                        dgvEmpleados.Refresh();
                        limpiar();
                        Lim_ha apagar = new Lim_ha();
                        apagar.Apagar(this);
                }
        }

        private void btnrecontratar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Text = "Guardar";
            btnGuardar.Visible = false;
            btncancelar.Visible = false;
            dgvEmpleados.Enabled = true;
            lblconfirmar.Visible = false;
            txtconfirmarident.Visible = false;
            rbactivo.Enabled = false;
            rbdespedido.Enabled = false;

            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);
            txtbuscarid.Enabled = true;
            txtnombreemp.Enabled = true;

        }

        private void txtbuscarid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgvEmpleados.DataSource;
                if (txtbuscarid.Text != "")
                    dt.DefaultView.RowFilter = string.Format("[Identidad] LIKE '%{0}%'", txtbuscarid.Text);

                else
                {
                    dt.DefaultView.RowFilter = null;
                }
                dgvEmpleados.Refresh();

                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.txtbuscarid, 0, 25, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex);
            }
        }

        private void cbcodrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcodrol.SelectedIndex == 0)
            {
                txtcodrol = "1";
            }
            else
            {
                txtcodrol = "2";
            }
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

        private void txtidentidad_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Numeros", this.txtidentidad, 0, 25, 2000);
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtnombre, 0, 25, 2000);
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtapellido, 0, 25, 2000);
        }

        private void txtdireccion_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras y/o Numeros", this.txtdireccion, 0, 25, 2000);
        }

        private void txtciudad_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtciudad, 0, 25, 2000);
        }

        private void txtregion_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtregion, 0, 25, 2000);
        }

        private void txtcodpost_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Numeros", this.txtcodpost, 0, 25, 2000);
        }

        private void txtpais_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtpais, 0, 25, 2000);
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras y/o Numeros", this.txtcorreo, 0, 25, 2000);
        }

        private void txttelefono_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Numeros", this.txttelefono, 0, 25, 2000);
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtregion_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtconfirmarident_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtpais_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtnombreemp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgvEmpleados.DataSource;
                dt.DefaultView.RowFilter = string.Format("[Nombres] LIKE '%{0}'", txtnombreemp.Text);
                dgvEmpleados.Refresh();

                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.txtnombreemp, 0, 25, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkdespedido_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chktodos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if(letrasNum.email(txtcorreo.Text) == false)
            {
                txtcorreo.Focus();
            }
        }

        private void rbfiltroactivos_CheckedChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvEmpleados.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Activo");

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                tt.Show("No se encontro parametros", this.rbfiltroactivos, 0, 25, 2000);
            }
        }

        private void rbfiltrodespedidos_CheckedChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvEmpleados.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Despedido");

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                tt.Show("No se encontro parametros", this.rbfiltrodespedidos, 0, 25, 2000);
            }
        }

        private void rbfiltrotodos_CheckedChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvEmpleados.DataSource;
            dt.DefaultView.RowFilter = null;

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                tt.Show("No se encontro parametros", this.rbfiltrotodos, 0, 25, 2000);
            }
        }

        private void txtnombreemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtbuscarid_TextChanged_1(object sender, EventArgs e)
        {
            
            try
            {
                var dt = (DataTable)dgvEmpleados.DataSource;
                if (txtbuscarid.Text != "")
                    dt.DefaultView.RowFilter = string.Format("[Identidad] LIKE '%{0}%'", txtbuscarid.Text);

                else
                {
                    dt.DefaultView.RowFilter = null;
                }
                dgvEmpleados.Refresh();

                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.txtbuscarid, 0, 25, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex);
            }
        }

        private void txtbuscarid_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }
    }
}
