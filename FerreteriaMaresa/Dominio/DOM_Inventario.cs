using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class DOM_Inventario
    {

        //Atributos 

        private int id_producto;
        private string nom_producto;
        private int id_marca;
        private double cantidad_unidad;
        private double costo_producto;
        private double precio_actual;
        private int stock;
        private int id_categoria;

        //Procedure

        //string query =
        //    "INSERT INTO Inventario (nom_producto, id_marca, Cantidad_por_Unidad, Costo_producto, precio_actual, stock, id_categoria)" +
        //    "VALUES (@nom_producto, @id_marca, @Cantidad_por_Unidad, @Costo_producto, @precio_actual, @stock, @id_categoria)";
        //conexion.Open(); //Cuando tengamos conexion
        //SqlCommand comando = new SqlComand(Query, conexion);
        //comando.Parameters.AddWithValue("@nom_producto", txtNombre.text);
        //comando.Parameters.AddWithValue("@id_marca", txtMarca.text);
        //comando.Parameters.AddWithValue("@Cantidad_por_Unidad", txtCantidad.text);
        //comando.Parameters.AddWithValue("@Costo_producto", txtCosto.text);
        //comando.Parameters.AddWithValue("@precio_actual", txtPrecio.text);
        //comando.Parameters.AddWithValue("@stock", txtStock.text);
        //comando.Parameters.AddWithValue("@id_categoria", txtCategoria.text);
        //comando.ExecuteNonQuery();


        //Update

        //String query = ("UPDATE Inventario SET " +
        //    "nom_producto = @nom_producto" +
        //    "id_marca = @id_marca" +
        //    "Cantidad_por_Unidad = @Cantidad_por_Unidad" +
        //    "Costo_producto = @Costo_producto" +
        //    "precio_actual = @precio_actual" +
        //    "stock = @stock" +
        //    "id_categoria = @id_categoria" +
        //    "WHERE id_producto = @id_producto");
        //conexion.Open(); //Cuando tengamos conexion
        //SqlCommand comando = new SqlCommand(Query, conexion);
        //comando.Parameters.AddWithValue("@nom_producto", txtNombre.text);
        //comando.Parameters.AddWithValue("@id_marca", txtMarca.text);
        //comando.Parameters.AddWithValue("@Cantidad_por_Unidad", txtCantidad.text);
        //comando.Parameters.AddWithValue("@Costo_producto", txtCosto.text);
        //comando.Parameters.AddWithValue("@precio_actual", txtPrecio.text);
        //comando.Parameters.AddWithValue("@stock", txtStock.text);
        //comando.Parameters.AddWithValue("@id_categoria", txtCategoria.text);
        //conexion.Close();







    }
}
