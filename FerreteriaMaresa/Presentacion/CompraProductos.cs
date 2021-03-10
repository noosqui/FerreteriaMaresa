using System;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class CompraProductos : Form
    {
        public CompraProductos()
        {
            InitializeComponent();
        }

        private void CompraProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            habilitar.Enabled = true;

            txtnombre.Enabled = true;
            txtmarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            habilitar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            habilitar.Enabled = true;
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            txtnombre.Enabled = true;
            txtmarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
        }
    }
}
