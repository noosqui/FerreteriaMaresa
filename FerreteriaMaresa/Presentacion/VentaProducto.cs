using System;
using System.Windows.Forms;
using Dominio;
using System.Data;

namespace Presentacion
{
    public partial class VentaProducto : Form
    {
        DOM_Facturacion facturacion = new DOM_Facturacion();
        DOM_Inventario inventario = new DOM_Inventario();
        DOM_Empleados empleados = new DOM_Empleados();
        
        public VentaProducto()
        {
            InitializeComponent();
        }
        public VentaProducto(DOM_Empleados emp)
        {
            this.empleados = emp;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvListProduct.Rows.Add(dgvProductos.SelectedRows,txtCantidad.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            facturacion.InsertarFacturaVenta(empleados, txtSubtotal.Text, txtDescuento.Text);

            foreach (DataRow row in dgvListProduct.Rows)
            {
                inventario.Id_producto = row.Field<int>("id_producto");
                inventario.Id_marca = row.Field<int>("id_marca");
                inventario.Nom_producto = row.Field<string>("nom_producto");
                inventario.Cantidad_unidad = row.Field<string>("Cantidad_por_Unidad");
                inventario.Precio_actual = row.Field<double>("precio_actual");
                inventario.Id_categoria = row.Field<int>("id_categoria");
                facturacion.insertarDetalleVenta(row.Field<string>("cantidad"),inventario);
            }
        }
    }
}
