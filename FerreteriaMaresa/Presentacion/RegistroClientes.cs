using System.Data;
using System.Windows.Forms;
using Dominio;
using System.Media;
using System;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {

        DOM_Validacion letrasNum = new DOM_Validacion();
        DOM_Clientes c = new DOM_Clientes();
        ToolTip tt = new ToolTip();
        ErrorProvider error1 = new ErrorProvider();

        private string idCliente = null;
        private bool editar = false;
        
        bool btna = false;
        bool btnb = false;
        bool btnc = false;



        public RegistroClientes()
        {
            InitializeComponent();

        }

        private void limpiar() {
            txtCodigoCliente.Clear();
            nombre.Clear();
            Apellido.Clear();
            txtrtn.Clear();
            txtTelefono1.Clear();
            txtcodigocli.Clear();
            txtRegion.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtPais.Clear();
            txtCodPost.Clear();
            txtnombrecli.Clear();
        }


        public void Regristro_Cliente()
        {
            c.Id_cliente = txtCodigoCliente.Text;
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = txtrtn.Text;
            c.Telefono = txtTelefono1.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_Postal = txtCodPost.Text;
            c.Pais = txtPais.Text;
            c.crear_Cliente(txtCodigoCliente.Text, nombre.Text, Apellido.Text, txtrtn.Text, txtRegion.Text, txtCiudad.Text,
                txtDireccion.Text, txtPais.Text, txtCodPost.Text, txtTelefono1.Text);
            dgvClientes.Refresh();
        }

        public void Editar_Cliente() {

            dgvClientes.Refresh();
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = txtrtn.Text;
            c.Telefono = txtTelefono1.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_Postal = txtCodPost.Text;
            c.Pais = txtPais.Text;
            c.editar_Clientes(txtCodigoCliente.Text, nombre.Text,
                Apellido.Text, txtrtn.Text, 
                txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                txtCodPost.Text, txtPais.Text, txtTelefono1.Text);
            MessageBox.Show("Cliente editado con exito");
            dgvClientes.Refresh();
            
        }

        private void habilitar_Click_1(object sender, System.EventArgs e)
        {
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
        }


        private void RegistroClientes_Load(object sender, System.EventArgs e)
        {

            
            
            dgvClientes.DataSource = c.Mostrar_Cliente(); 
           
            dgvClientes.Rows[1].Selected = true;
            var dt = (DataTable)dgvClientes.DataSource;
            dt.DefaultView.RowFilter = "[Estado] LIKE 'Activo'";

            dgvClientes.Rows[0].Selected = true;
            dgvEmpleados_CellClick(null, null);
            dgvClientes.Columns[10].Visible = false;

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.CurrentRow.Selected = true;
            txtCodigoCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            nombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtrtn.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtTelefono1.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
        }


        private void txtcodigocli_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtnombrecli_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }


        private void label11_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcodigocli_TextChanged(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvClientes.DataSource;
            var dt = (DataTable)bd.DataSource;
            if (txtcodigocli.Text != "")

                dt.DefaultView.RowFilter = string.Format("[Id Cliente] LIKE '%{0}'", txtcodigocli.Text);

            else
            {
                dt.DefaultView.RowFilter = null;
            }
            dgvClientes.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtcodigocli, 0, 25, 3000);
            }

        }

        private void txtnombrecli_TextChanged_1(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvClientes.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombres] LIKE '%{0}%'", txtnombrecli.Text);
            dgvClientes.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                SystemSounds.Exclamation.Play();
                ToolTip tt = new ToolTip();
                tt.Show("No se encontro parametros", this.txtnombrecli, 0, 25, 3000);
            }
        }


        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar1_Click(object sender, System.EventArgs e)
        {
            btnGuardar.Visible = false;
            btnAgregar.Visible = true;
            btnEliminar.Visible = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            dgvClientes.Enabled = true;

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);
            nombre.Enabled = false;
            Apellido.Enabled = false;
            txtrtn.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono1.Enabled = false;


            if (btna == true)
            {
                try
                {
                    if (txtrtn.Text.Contains(txtCodigoCliente.Text))
                    {
                        c.crear_Cliente(txtCodigoCliente.Text, nombre.Text, Apellido.Text, txtrtn.Text, txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                         txtCodPost.Text, txtPais.Text, txtTelefono1.Text);

                        var fuente = new BindingSource();
                        fuente.DataSource = c.Mostrar_Cliente();
                        dgvClientes.DataSource = fuente;
                        dgvClientes.Refresh();
                        MessageBox.Show("Cliente agregado correctamente");
                    }
                    else if (txtrtn.Text.Length <= 0)
                    {
                        c.crear_Cliente(txtCodigoCliente.Text, nombre.Text, Apellido.Text, null, txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                         txtCodPost.Text, txtPais.Text, txtTelefono1.Text);
                        MessageBox.Show("Cliente agregado correctamente");
                    }
                    else
                        throw new Exception("El rtn no es el mismo que el numero de identidad");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar Cliente: " + ex);
                }
               /* catch (int )
                {

                }*/

            }

            if (btnb == true)
            {
                try
                {
                    if (txtrtn.Text.Contains(txtCodigoCliente.Text))
                    {
                        c.editar_Clientes(txtCodigoCliente.Text, nombre.Text, Apellido.Text, txtrtn.Text, txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                     txtCodPost.Text, txtPais.Text, txtTelefono1.Text);
                        dgvClientes.Refresh();
                        MessageBox.Show("Cliente editado correctamente");
                    }
                    else if (txtrtn.Text.Length <= 0)
                    {
                        c.editar_Clientes(txtCodigoCliente.Text, nombre.Text, Apellido.Text, null, txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                    txtCodPost.Text, txtPais.Text, txtTelefono1.Text);
                    }
                    else
                        throw new Exception("El rtn no es igual al numero de identidad");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar Cliente: " + ex);
                }
            }

            if (btnc == true)
            {
                try
                {
                    c.eliminar_cliente(txtCodigoCliente.Text);
                    dgvClientes.Refresh();
                    MessageBox.Show("Cliente borrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar Cliente: " + ex);
                }
            }

            RegistroClientes_Load(null, null);

        }

        private void btnModificar1_Click(object sender, System.EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count == 1)
            {
                btna = false;
                btnb = true;
                btnc = false;
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;
                btnGuardar.Visible = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnCancelar.Visible = true;

                
                nombre.Enabled = true;
                Apellido.Enabled = true;
                txtrtn.Enabled = true;
                txtTelefono1.Enabled = true;
                txtRegion.Enabled = true;
                txtPais.Enabled = true;
                txtDireccion.Enabled = true;
                txtCiudad.Enabled = true;
                txtCodPost.Enabled = true;
                txtcodigocli.Enabled = true;
                dgvClientes.Enabled = false;
            }
            else
                MessageBox.Show("Porfavor seleccione una fila antes de modificar");
        }

        private void bnAgregar_Click(object sender, System.EventArgs e)
        {
            limpiar();

            btna = true;
            btnb = false;
            btnc = false;
            btnAgregar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
            btnModificar.Enabled = false;
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;

            dgvClientes.Enabled = false;
            txtCodigoCliente.Enabled = true;
            nombre.Enabled = true;
            Apellido.Enabled = true;
            txtrtn.Enabled = true;
            txtTelefono1.Enabled = true;
            txtRegion.Enabled = true;
            txtPais.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtCodPost.Enabled = true;
            txtcodigocli.Enabled = true;
        }

        private void btnEliminar1_Click(object sender, System.EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count == 1)
            {
                btna = false;
                btnb = false;
                btnc = true;
                btnEliminar.Visible = false;
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                btnGuardar.Visible = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnCancelar.Visible = true;
                dgvClientes.Enabled = false;
            }
            else
                MessageBox.Show("Porfavor seleccione una fila antes de eliminar");

        }

        private void txtnombrecli_KeyPress_1(object sender, KeyPressEventArgs e)
        {        
            letrasNum.SoloLetras(e);
        }

        private void txtcodigocli_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtCodPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloLetras(e);
        }

        private void rtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            letrasNum.SoloNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodigoCliente_Enter(object sender, System.EventArgs e)
        {
            tt.SetToolTip(this.txtCodigoCliente, "Ingrese los 13 numeros correspondientes");
        }

        private void rtn_Enter(object sender, System.EventArgs e)
        {
            tt.SetToolTip(this.txtrtn, "Ingrese los 14 numeros correspondientes");
        }

        private void txtTelefono1_Enter(object sender, System.EventArgs e)
        {         
            tt.SetToolTip(this.txtTelefono1, "Ingrese los 8 numeros correspondientes");
        }

        private void txtCodPost_Enter(object sender, System.EventArgs e)
        {
            tt.SetToolTip(this.txtCodPost, "Ingrese los 5 numeros correspondientes");
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            limpiar();
            dgvClientes.Rows[0].Selected = true;
            dgvEmpleados_CellClick(null, null);
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;

            btnAgregar.Enabled = true;
            btnAgregar.Visible = true;

            btnEliminar.Enabled = true;
            btnEliminar.Visible = true;

            btnModificar.Enabled = true;
            btnModificar.Visible = true;

            btnGuardar.Enabled = false;
            btnGuardar.Visible = false;
            dgvClientes.Enabled = true;


            txtCodigoCliente.Enabled=false;
            nombre.Enabled = false;
            Apellido.Enabled = false;
            txtrtn.Enabled = false;
            txtTelefono1.Enabled = false;
            txtcodigocli.Enabled = false;
            txtRegion.Enabled = false;
            txtCiudad.Enabled = false;
            txtDireccion.Enabled = false;
            txtPais.Enabled = false;
            txtCodPost.Enabled = false;
            txtnombrecli.Enabled = false;
        }

        private void txtCodigoCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int i;

            if (string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                e.Cancel = false;
            }

                else if (txtCodigoCliente.Text.Trim().Length < 13 || txtCodigoCliente.Text.Trim().Length > 13)
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo debe contener 13 caracteres");
                }
            
        }

        private void txtCodigoCliente_Validated(object sender, System.EventArgs e)
        {
            error1.SetError(txtCodigoCliente, "");
        }

        private void rtn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int i;

            if (string.IsNullOrEmpty(txtrtn.Text))
            {
                e.Cancel = false;
            }

            else if (txtrtn.Text.Trim().Length < 14 || txtrtn.Text.Trim().Length > 14)
            {
                e.Cancel = true;
                MessageBox.Show("El campo debe contener 14 caracteres");
            }

        }

        private void rtn_Validated(object sender, System.EventArgs e)
        {
            error1.SetError(txtrtn, "");
        }

        private void txtCodPost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int i;

            if (string.IsNullOrEmpty(txtCodPost.Text))
            {
                e.Cancel = false;
            }

            else if (txtCodPost.Text.Trim().Length < 5 || txtCodPost.Text.Trim().Length > 5)
            {
                e.Cancel = true;
                MessageBox.Show("El campo debe contener 5 caracteres");
            }

        }

        private void txtCodPost_Validated(object sender, System.EventArgs e)
        {
            error1.SetError(txtCodPost, "");
        }

        private void txtTelefono1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int i;

            if (string.IsNullOrEmpty(txtTelefono1.Text))
            {
                e.Cancel = false;
            }

            else if (txtTelefono1.Text.Trim().Length < 8 || txtTelefono1.Text.Trim().Length > 8)
            {
                e.Cancel = true;
                MessageBox.Show("El campo debe contener 8 caracteres");
            }

        }

        private void txtTelefono1_Validated(object sender, System.EventArgs e)
        {
            error1.SetError(txtTelefono1, "");
        }

        private void txtCodigoCliente_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void Apellido_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void rtn_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtTelefono1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label10_Click(object sender, System.EventArgs e)
        {

        }

        private void label12_Click(object sender, System.EventArgs e)
        {

        }

        private void txtCodPost_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void label9_Click(object sender, System.EventArgs e)
        {

        }

        private void txtRegion_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigocli_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    
      
}
