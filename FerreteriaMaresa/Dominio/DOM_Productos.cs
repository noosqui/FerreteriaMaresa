using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Dominio
{
    class DOM_Productos
    {
        //Atributos 

        private int id_producto;
        private string nom_producto;
        private int id_marca;
        private double cantidad_unidad;
        private double costo_producto;
        private double precio_actual;
        private int stock;
        private string estado;
        private int id_categoria;
        private CD_Inventario inventario = new CD_Inventario();
        public DOM_Productos(string id_producto, string nom_producto, string marca, string cantidad, string costo,
            string precio_actual, string stock, string estado, string categoria)
        {
            this.id_producto = int.Parse(id_producto);
            this.nom_producto = nom_producto;
            this.id_marca = int.Parse(marca);
            this.cantidad_unidad = double.Parse(cantidad);
            this.costo_producto = double.Parse(costo);
            this.precio_actual = double.Parse(precio_actual);
            this.stock = int.Parse(stock);
            this.estado = estado;
            this.id_categoria = int.Parse(categoria);
        }
        public DOM_Productos()
        {

        }


        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }

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

        public double Cantidad_unidad
        {
            get { return cantidad_unidad; }
            set { cantidad_unidad = value; }
        }

        public double Costo_producto
        {
            get { return costo_producto; }
            set { costo_producto = value; }
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


        //Metodos
        public void insertar_inventario()
        {
            // objeto.insertar(id_producto, nom_producto, id_marca, cantidad_unidad, costo_producto, precio_actual,
            //stock, estado, id_categoria) /
        }

        private System.Data.DataTable mostrar_inventario()
        {
            return inventario.Mostrar_Inventario();
        }

    }
}
