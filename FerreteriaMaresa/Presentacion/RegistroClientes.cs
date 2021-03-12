﻿using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void habilitar_Click_1(object sender, System.EventArgs e)
        {
            btnhabilitar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnMostrar.Enabled = true;
            btnAgregar.Enabled = true;

            nombre.Enabled = false;
            Apellido.Enabled = false;
            rtn.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void button6_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnMostrar.Enabled = false;
            btnhabilitar.Enabled = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            rtn.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnhabilitar.Enabled = true;
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnhabilitar.Enabled = true;

            nombre.Enabled = true;
            Apellido.Enabled = true;
            rtn.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void txtcliente_TextChanged(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvClientes.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Id Producto] = {0}", int.Parse(txtcodigocli.Text));
            // dt.DefaultView.RowFilter = string.Format("[String] LIKE '%1%']", <txtnombre.Text>);
            dgvClientes.Refresh();


            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtnombrecli_TextChanged(object sender, System.EventArgs e)
        {
            var bd = (BindingSource)dgvClientes.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{1}%'", txtnombrecli.Text);
            dgvClientes.Refresh();

            if (dt.DefaultView.Count < 1)
            {
                MessageBox.Show("No se encontró Codigo/Nombre",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
