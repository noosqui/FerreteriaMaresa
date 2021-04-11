using System.Data;
using System.Windows.Forms;
using Dominio;
using System.Media;


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
            rtn.Clear();
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
            c.Rtn = rtn.Text;
            c.Telefono = txtTelefono1.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_Postal = txtCodPost.Text;
            c.Pais = txtPais.Text;
            c.crear_Cliente(txtCodigoCliente.Text, nombre.Text, Apellido.Text, rtn.Text, txtRegion.Text, txtCiudad.Text,
                txtDireccion.Text, txtPais.Text, txtCodPost.Text, txtTelefono1.Text);
            dgvClientes.Refresh();
        }

        public void Editar_Cliente() {

            dgvClientes.Refresh();
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = rtn.Text;
            c.Telefono = txtTelefono1.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_Postal = txtCodPost.Text;
            c.Pais = txtPais.Text;
            c.editar_Clientes(txtCodigoCliente.Text, nombre.Text,
                Apellido.Text, rtn.Text, 
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
            var fuente = new BindingSource();
            fuente.DataSource = c.Mostrar_Cliente();
            dgvClientes.DataSource = fuente;
            dgvClientes.Refresh();
            dgvClientes.Rows[1].Selected = true;

            dgvClientes.CurrentRow.Selected = true;
            txtCodigoCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            nombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            rtn.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtTelefono1.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.CurrentRow.Selected = true;
            txtCodigoCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            nombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            rtn.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
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
            btnGuardar1.Visible = false;
            bnAgregar.Visible = true;
            btnEliminar1.Visible = true;
            btnEliminar1.Enabled = true;
            btnModificar1.Enabled = true;
            bnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            dgvClientes.Enabled = true;

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);
            nombre.Enabled = false;
            Apellido.Enabled = false;
            rtn.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono1.Enabled = false;


            if (btna == true)
            {
                try
                {
                    c.crear_Cliente(txtCodigoCliente.Text, nombre.Text, Apellido.Text, rtn.Text, txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                     txtCodPost.Text, txtPais.Text, txtTelefono1.Text);

                    var fuente = new BindingSource();
                    fuente.DataSource = c.Mostrar_Cliente();
                    dgvClientes.DataSource = fuente;
                    dgvClientes.Refresh();


                }
                catch
                {
                    MessageBox.Show("Cliente agregado correctamente");
                }

            }

            if (btnb == true)
            {
                try
                {

                    c.editar_Clientes(txtCodigoCliente.Text, nombre.Text, Apellido.Text, rtn.Text, txtDireccion.Text, txtCiudad.Text, txtRegion.Text,
                     txtCodPost.Text, txtPais.Text, txtTelefono1.Text);
                    dgvClientes.Refresh();
                }
                catch
                {
                    MessageBox.Show("Cliente editado correctamente");
                }
            }

            if (btnc == true)
            {
                try
                {

                    c.eliminar_empleado(txtCodigoCliente.Text);
                    dgvClientes.Refresh();
                }
                catch
                {
                    MessageBox.Show("Cliente borrado correctamente");
                }
            }

            RegistroClientes_Load(null, null);

        }

        private void btnModificar1_Click(object sender, System.EventArgs e)
        {
            

            btna = false;
            btnb = true;
            btnc = false;

            bnAgregar.Enabled = false;
            bnAgregar.Visible = false;
            btnEliminar1.Enabled = false;
            btnEliminar1.Visible = false;
            btnGuardar1.Visible = true;
            btnGuardar1.Enabled = true;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;

            txtCodigoCliente.Enabled = true;
            nombre.Enabled = true;
            Apellido.Enabled = true;
            rtn.Enabled = true;
            txtTelefono1.Enabled = true;
            txtRegion.Enabled = true;
            txtPais.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtCodPost.Enabled = true;
            txtcodigocli.Enabled = true;
        }

        private void bnAgregar_Click(object sender, System.EventArgs e)
        {
            limpiar();

            btna = true;
            btnb = false;
            btnc = false;

            btnEliminar1.Enabled = false;
            btnEliminar1.Visible = false;
            btnModificar1.Enabled = true;
            btnModificar1.Visible = true;
            btnGuardar1.Visible = true;
            btnGuardar1.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;

            dgvClientes.Enabled = false;
            txtCodigoCliente.Enabled = true;
            nombre.Enabled = true;
            Apellido.Enabled = true;
            rtn.Enabled = true;
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
            btna = false;
            btnb = false;
            btnc = true;

            btnAgregar.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar1.Enabled = true;
            btnModificar1.Visible = true;
            btnGuardar1.Visible = true;
            btnGuardar1.Enabled = true;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;
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
            tt.SetToolTip(this.rtn, "Ingrese los 14 numeros correspondientes");
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
            btnCancelar.Visible = false;

            bnAgregar.Enabled = true;
            bnAgregar.Visible = true;

            btnEliminar1.Enabled = true;
            btnEliminar1.Visible = true;

            btnModificar1.Enabled = true;
            btnModificar1.Visible = true;

            btnGuardar1.Enabled = true;
            btnGuardar1.Visible = true;
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

            if (string.IsNullOrEmpty(rtn.Text))
            {
                e.Cancel = false;
            }

            else if (rtn.Text.Trim().Length < 14 || rtn.Text.Trim().Length > 14)
            {
                e.Cancel = true;
                MessageBox.Show("El campo debe contener 14 caracteres");
            }

        }

        private void rtn_Validated(object sender, System.EventArgs e)
        {
            error1.SetError(rtn, "");
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
    }
    
      
}
