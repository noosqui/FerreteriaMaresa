﻿using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {
        private Clientes c = new Clientes();
        public RegistroClientes()
        {
            InitializeComponent();
        }

        public void Regristro_Cliente() 
        {
            c.Id = int.Parse(txtID.Text);
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = rtn.Text;
            c.Telefono = txtTelefono.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_postal = int.Parse(txtCodPost.Text);
            c.Pais = txtPais.Text;
            c.crear_Cliente();
            MessageBox.Show("Cliente registrado con exito");
            dgvClientes.Refresh();
        }

        public void Editar_Cliente() {

            c.Id = int.Parse(txtID.Text);
            c.Nombre = nombre.Text;
            c.Apellido = Apellido.Text;
            c.Rtn = rtn.Text;
            c.Telefono = txtTelefono.Text;
            c.Direccion = txtDireccion.Text;
            c.Ciudad = txtCiudad.Text;
            c.Region = txtRegion.Text;
            c.Codigo_postal = int.Parse(txtCodPost.Text);
            c.Pais = txtPais.Text;
            c.editar_Clientes();
            MessageBox.Show("Cliente editado con exito");
            dgvClientes.Refresh();

        }

        public void buscar_empleado() {
            c.Id = int.Parse(txtID.Text);
            c.Buscar_Cliente();
            dgvClientes.Refresh();
        }

        private void habilitar_Click_1(object sender, System.EventArgs e)
        {
            btnGuardar.Visible = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;
            dgvClientes.Enabled = true;

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

            Lim_ha apagar = new Lim_ha();
            apagar.Apagar(this);
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;

         
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            dgvClientes.Enabled = false;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;

            Lim_ha encender = new Lim_ha();
            encender.Encender(this);

            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);

        }

     
        private void RegistroClientes_Load(object sender, System.EventArgs e)
        {
            var fuente = new BindingSource();
            fuente.DataSource = c.Mostrar_Cliente();
            dgvClientes.DataSource = fuente;
            dgvClientes.Refresh();
            dgvClientes.Rows[1].Selected = true;

            dgvClientes.CurrentRow.Selected = true;
            nombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            rtn.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.CurrentRow.Selected = true;
            nombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            rtn.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtCiudad.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtRegion.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtCodPost.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtPais.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            c.Buscar_Cliente();
        }
    }
}
