using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;



namespace Dominio
{
    public class DOM_Inventario
    {

        //Atributos 

        private int id_producto;
        private int id_proveedor;
        private string nom_producto;
        private string nom_proveedor;
        private string marca;
        private int id_marca;
        private string cantidad_unidad;
        private double costo;
        private double precio_actual;
        private int stock;
        private string estado;
        private int id_categoria;
        private string categoria;
        private CD_Inventario inventario = new CD_Inventario();
        

        public DOM_Inventario() { }

        public DOM_Inventario(string id_producto, string id_proveedor, string nom_producto, string nom_proveedor, string marca, string id_marca, string costo, 
            string precio_actual, string stock, string estado, string id_categoria, string cantidad_unidad)
        {
            this.id_producto = int.Parse(id_producto);
            this.id_proveedor = int.Parse(id_proveedor);
            this.nom_producto = nom_producto;
            this.nom_proveedor = nom_proveedor;
            this.id_marca = int.Parse(id_marca);
            this.marca = marca;
            this.costo = double.Parse(costo);
            this.precio_actual = double.Parse(precio_actual);
            this.stock = int.Parse(stock);
            this.estado = estado;
            this.id_categoria = int.Parse(id_categoria);
            this.cantidad_unidad = cantidad_unidad;
        }
        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }

        }

        public int Id_Proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }

        }

        public string Nom_Proveedor
        {
            get { return nom_proveedor; }
            set { nom_proveedor = value; }
        }

        public string Nom_producto
        {
            get { return nom_producto; }
            set { nom_producto = value; }
        }

        public int Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Cantidad_unidad
        {
            get { return cantidad_unidad; }
            set { cantidad_unidad = value; }
        }

        public double Costo_producto
        {
            get { return costo; }
            set { costo = value; }
        }

        public double Precio_actual
        {
            get { return precio_actual; }
            set { precio_actual = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }




        public DataTable buscar_inventario()
        {
            return inventario.Buscar_Inventario(Nom_producto);
        }

        public DataTable mostrar_inventario()
        {
            return inventario.Mostrar_Inventario();
        }

        public DataTable ListarCategoria() 
        {
            return inventario.Mostrar_Categorias();
        }

        public DataTable ListarMarcas() 
        {
            return inventario.Mostrar_Marcas();
        }


        public void crear_inventario(string IdProducto, string nom_producto, string nom_proveedor, string Marca, string costo_producto,
            string precio_actual, string stock, string estado, string Categoria)
        {
            inventario.insertar_Inventario(int.Parse(IdProducto), nom_producto, nom_proveedor, marca, double.Parse(costo_producto),
            double.Parse(precio_actual), int.Parse(stock), estado, categoria);
        }

        public void modificar_inventario(string IdProducto, string nom_producto, string nom_proveedor, string Marca, string costo_producto,
            string precio_actual, string stock, string estado, string Categoria)
        {
            inventario.modificar_Inventario(int.Parse(IdProducto), nom_producto, nom_proveedor, marca, double.Parse(costo_producto),
            double.Parse(precio_actual), int.Parse(stock), estado, categoria);
        }

        public void eliminar_Producto(string IdProducto)
        {
            inventario.EliminarInventario(IdProducto);
        }

    }
}
