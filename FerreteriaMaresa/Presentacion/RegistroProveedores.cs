using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroProveedores : Form
    {
        DOM_proveedor proveedor = new DOM_proveedor();
        DOM_Validacion letrasNum = new DOM_Validacion();
        ToolTip tt = new ToolTip();
        bool estadobtna = false;
        bool estadobtnb = false;
        bool estadobtnc = false;
        string estado = "";

        public RegistroProveedores()
        {
            InitializeComponent();

        }

        private void limpiar()
        {
            txtnombre.Clear();
            txtTelefono.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtciudad.Clear();
            txtregion.Clear();
            txtCodPost.Clear();
            txtPais.Clear();
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }

        public void CargarDatos()
        {
            try
            {
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = proveedor.CargarDGVProveedores();
                dgvProveedores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedieron cargar los Datos");
            }
        }

        private void RegistroProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();

            txtcodigo.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            txtcorreo.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            txtdireccion.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
            txtciudad.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
            txtregion.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvProveedores.CurrentRow.Cells[8].Value.ToString();
            estado = dgvProveedores.CurrentRow.Cells[9].Value.ToString();
            if (estado == "Activo")
            {
                rbActivo.Checked = true;
            }
            if (estado == "Inactivo")
            {
                rbInactivo.Checked = true;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estadobtna = true;
            estadobtnb = false;
            estadobtnc = false;

            dgvProveedores.Enabled = false;
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;

            txtnombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtcorreo.Enabled = true;
            txtdireccion.Enabled = true;
            txtciudad.Enabled = true;
            txtregion.Enabled = true;
            txtCodPost.Enabled = true;
            txtPais.Enabled = true;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;
            limpiar();

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estadobtna == true)
            {
                if (txtnombre.Text == "" || txtTelefono.Text == "" || txtcorreo.Text == "" || txtdireccion.Text == "" ||
                        txtciudad.Text == "" || txtregion.Text == "" || txtCodPost.Text == "" || txtPais.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los Campos");
                }
                else if (txtCodPost.TextLength < 5)
                {
                    MessageBox.Show("Codigo Postal Incompleto/Ingrese 5 Numeros");
                }
                else if (txtTelefono.TextLength < 8)
                {
                    MessageBox.Show("Numero de Telefono incompleto, debe Ingresar 8 numeros");
                }
                else
                {
                    try
                    {
                        if (rbActivo.Checked)
                        {
                            estado = "Activo";
                        }
                        if (rbInactivo.Checked)
                        {
                            estado = "Inactivo";
                        }

                        proveedor.crear_proveedor(txtnombre.Text, txtTelefono.Text, txtcorreo.Text, txtdireccion.Text, txtciudad.Text,
                            txtregion.Text, txtCodPost.Text, txtPais.Text, estado);

                        btnAgregar.Visible = true;
                        btnModificar.Visible = true;
                        btnEliminar.Visible = true;
                        btnGuardar.Visible = false;
                        btnCancelar.Visible = false;
                        dgvProveedores.Enabled = true;
                        rbActivo.Enabled = false;
                        rbInactivo.Enabled = false;
                        limpiar();
                        var fuente = new BindingSource();
                        fuente.DataSource = proveedor.CargarDGVProveedores();
                        dgvProveedores.DataSource = fuente;
                        dgvProveedores.Refresh();
                        Lim_ha apagar = new Lim_ha();
                        apagar.Apagar(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al Agregar Proveedor" + ex);
                    }
                }
            }
                if (estadobtnb == true)
                {
                    if (txtnombre.Text == "" || txtTelefono.Text == "" || txtcorreo.Text == "" || txtdireccion.Text == "" ||
                        txtciudad.Text == "" || txtregion.Text == "" || txtCodPost.Text=="" ||  txtPais.Text=="")
                    {
                        MessageBox.Show("Debe llenar todos los Campos");
                    }
                    else if (txtCodPost.TextLength < 5)
                    {
                        MessageBox.Show("Codigo Postal Incompleto/Ingrese 5 Numeros");
                    }
                    else if (txtTelefono.TextLength < 8)
                    {
                        MessageBox.Show("Numero de Telefono incompleto, debe Ingresar 8 numeros");
                    }
                    else
                    {
                        try
                        {
                            if (rbActivo.Checked)
                            {
                                estado = "Activo";
                            }
                            if (rbInactivo.Checked)
                            {
                                estado = "Inactivo";
                            }

                            proveedor.editar_proveedor(txtcodigo.Text, txtnombre.Text, txtTelefono.Text, txtcorreo.Text, txtdireccion.Text, txtciudad.Text,
                                txtregion.Text, txtCodPost.Text, txtPais.Text, estado);
                            btnAgregar.Visible = true;
                            btnModificar.Visible = true;
                            btnEliminar.Visible = true;
                            btnGuardar.Visible = false;
                            btnCancelar.Visible = false;
                            dgvProveedores.Enabled = true;
                            rbActivo.Enabled = true;
                            rbInactivo.Enabled = true;
                            limpiar();
                            var fuente = new BindingSource();
                            fuente.DataSource = proveedor.CargarDGVProveedores();
                            dgvProveedores.DataSource = fuente;
                            dgvProveedores.Refresh();
                            Lim_ha apagar = new Lim_ha();
                            apagar.Apagar(this);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error de Modificacion" + ex);
                        }
                    }
                }
                if (estadobtnc == true)
                {
                    try
                    {
                        if (MessageBox.Show("¿Seguro que desea despedir el Empleado?",
                            "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            proveedor.eliminar_empleado(txtcodigo.Text);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al Eliminar el Empleado");
                    }

                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    dgvProveedores.Enabled = true;

                    rbActivo.Enabled = false;
                    rbInactivo.Enabled = false;
                    limpiar();
                    var fuente = new BindingSource();
                    fuente.DataSource = proveedor.CargarDGVProveedores();
                    dgvProveedores.DataSource = fuente;
                    dgvProveedores.Refresh();
                    Lim_ha apagar = new Lim_ha();
                    apagar.Apagar(this);
                }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                txtcorreo.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
                txtdireccion.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                txtciudad.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
                txtregion.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
                txtCodPost.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
                txtPais.Text = dgvProveedores.CurrentRow.Cells[8].Value.ToString();
                estado = dgvProveedores.CurrentRow.Cells[9].Value.ToString();
                if (estado == "Activo")
                {
                    rbActivo.Checked = true;
                }
                if (estado == "Despedido")
                {
                    rbInactivo.Checked = true;
                }
            }
            catch(Exception ex)
            {
                // MessageBox.Show("Error de Seleccion");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardar.Text = "Guardar";
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            dgvProveedores.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadobtna = false;
            estadobtnb = true;
            estadobtnc = false;
           
            btnAgregar.Visible = false;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;

            txtnombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtcorreo.Enabled = true;
            txtdireccion.Enabled = true;
            txtciudad.Enabled = true;
            txtregion.Enabled = true;
            txtCodPost.Enabled = true;
            txtPais.Enabled = true;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;

            estadobtna = false;
            estadobtnb = false;
            estadobtnc = true;


            txtnombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtcorreo.Enabled = true;
            txtdireccion.Enabled = true;
            txtciudad.Enabled = true;
            txtregion.Enabled = true;
            txtCodPost.Enabled = true;
            txtPais.Enabled = true;
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;
            btnGuardar.Text = "Despedir";
        }

        private void rbfiltroactivos_CheckedChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvProveedores.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Activo");


            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                tt.Show("No se encontro parametros", this.rbfiltroactivos, 0, 25, 2000);
            }
        }

        private void rbfiltroinactivo_CheckedChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvProveedores.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Estado] LIKE '%{0}%'", "Inactivo");


            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                tt.Show("No se encontro parametros", this.rbfiltroinactivo, 0, 25, 2000);
            }
        }

        private void rbfiltrotodos_CheckedChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dgvProveedores.DataSource;
            dt.DefaultView.RowFilter = null;

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                tt.Show("No se encontro parametros", this.rbfiltrotodos, 0, 25, 2000);
            }
        }

        private void txtbuscaridp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgvProveedores.DataSource;
                if (txtbuscaridp.Text != "")
                    dt.DefaultView.RowFilter = string.Format("[Id Proveedor] = {0}", txtbuscaridp.Text);

                else
                {
                    dt.DefaultView.RowFilter = null;
                }
                dgvProveedores.Refresh();

                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.txtbuscaridp, 0, 25, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (letrasNum.email(txtcorreo.Text) == false)
            {
                txtcorreo.Focus();
            }
        }

        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtregion_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtCodPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtbuscaridp_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtbuscarnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtnombre, 0, 25, 2000);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Numeros", this.txtTelefono, 0, 25, 2000);
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras y/o Numeros", this.txtcorreo, 0, 25, 2000);
        }

        private void txtdireccion_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras y/o Numeros", this.txtdireccion, 0, 25, 2000);
        }

        private void txtbuscaridp_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Numeros", this.txtbuscaridp, 0, 25, 2000);
        }

        private void txtbuscarnombre_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtbuscarnombre, 0, 25, 2000);
        }

        private void txtciudad_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtciudad, 0, 25, 2000);
        }

        private void txtregion_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtregion, 0, 25, 2000);
        }

        private void txtCodPost_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Numeros", this.txtCodPost, 0, 25, 2000);
        }

        private void txtPais_Enter(object sender, EventArgs e)
        {
            tt.Show("Ingrese Letras", this.txtPais, 0, 25, 2000);
        }

        private void txtbuscarnombre_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var dt = (DataTable)dgvProveedores.DataSource;
                dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}'", txtbuscarnombre.Text);
                dgvProveedores.Refresh();

                if (dt.DefaultView.Count < 1)
                {
                    SystemSounds.Exclamation.Play();
                    ToolTip tt = new ToolTip();
                    tt.Show("No se encontro parametros", this.txtbuscarnombre, 0, 25, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex);
            }
        }
    }
}

