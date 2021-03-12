using System;
using System.Data;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data;
=======
>>>>>>> Beta
using Dominio;

namespace Presentacion
{
    public partial class CompraProductos : Form
    {

        DOM_Empleados empleados = new DOM_Empleados();
        DOM_Facturacion facturacion = new DOM_Facturacion();
        private DOM_Inventario productos = new DOM_Inventario();


        public CompraProductos()
        {
            InitializeComponent();
        }

        private void CompraProductos_Load(object sender, EventArgs e)
        {
  
         var tab = new BindingSource();
         tab.DataSource = productos.mostrar_inventario();
         dgvProducto.DataSource = tab;
            dgvProducto.Refresh();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnSiguiente.Visible = true;

            txtnombre.Enabled = true;
            txtmarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
            dgvListaProductos.Rows.Add(dgvProducto.SelectedRows, txtCantidad.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnSiguiente.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnSiguiente.Visible = true;
        }

  
        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducto.CurrentRow.Selected = true;
            txtnombre.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
            txtCosto.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            txtCantidad.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();

            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            txtnombre.Enabled = true;
            txtmarca.Enabled = true;
            txtPrecio.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facturacion.InsertarFacturaVenta(empleados, txtSubtotal.Text,"0");

            foreach (DataRow row in dgvListaProductos.Rows)
            {
                inventario.Id_producto = row.Field<int>("id_producto");
                inventario.Id_marca = row.Field<int>("id_marca");
                inventario.Nom_producto = row.Field<string>("nom_producto");
                inventario.Cantidad_unidad = row.Field<string>("Cantidad_por_Unidad");
                inventario.Precio_actual = row.Field<double>("precio_actual");
                inventario.Id_categoria = row.Field<int>("id_categoria");
                facturacion.insertarDetalleCompra(row.Field<string>("cantidad"), inventario);
            }
        }

    }
}
