using System;
using System.Data;
using System.Text;
using Dominio;
using System.Windows.Forms;
using System.Media;

namespace Presentacion
{
    public partial class Compra : Form
    {
        DOM_Inventario inventario = new DOM_Inventario();
        DOM_Validacion letrasNum = new DOM_Validacion();

        public Compra()
        {
            InitializeComponent();
        }

        public void Regristro_inventario()
        {
             inventario.Id_producto = int.Parse(txtId.Text);
            inventario.Id_proveedor = int.Parse(txtId_Proveedor.Text);
            inventario.Nom_producto = txtNombre.Text;
            inventario.Id_marca = int.Parse(txtId_Marca.Text);
            inventario.Costo_producto = double.Parse(txtPrecio_Compra.Text);
            inventario.Precio_actual = double.Parse(txtPrecio_Venta.Text);
            inventario.Stock = int.Parse(txtstock.Text);
            inventario.Estado = txtxEstado.Text;
            inventario.Id_categoria = int.Parse(txtId_Categoria.Text);
            inventario.Cantidad_unidad = txtCantidad_Unidad.Text;
             MessageBox.Show("Producto registrado con exito");
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Regristro_inventario();
            Lim_ha Limpiar = new Lim_ha();
            Limpiar.Limpiar(this);
        }
    }
}
