using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;

namespace Datos
{
    public class CD_Inventario

    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader lee;
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();


        public DataTable Mostrar_Inventario()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "SP_Inventario";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            lee.Close();
            comando.Connection = conexion.cerrar();
            lee.Close();
            comando.Parameters.Clear();
            return tabla;
        }



        public DataTable Buscar_Inventario(string producto)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Buscar_Inventario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom_producto", producto);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            lee.Close();
            comando.Parameters.Clear();
            return tabla;
        }

        public void Inventario_NoDisponible(int idproducto)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Inventario_NoDisponible";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", idproducto);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void Inventario_Activo(int idproducto)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Inventario_Activo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", idproducto);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }
        public DataTable Mostrar_Marcas()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Marcas";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);

            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
            lee.Close();

            return tabla;
        }

        public DataTable Buscar_Marcas(string marca)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Buscar_Marcas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);

            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
            lee.Close();

            return tabla;
        }

        public DataTable Mostrar_Categorias()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Categorias";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);

            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
            lee.Close();

            return tabla;
        }


        public DataTable Mostrar_Proveedor()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Proveedores";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);

            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
            lee.Close();

            return tabla;
        }


        public DataTable Buscar_Categorias(string categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Buscar_Categorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);


            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
            lee.Close();

            return tabla;
        }


        public void insertar_Inventario(int id_proveedor, string nom_producto, int id_marca, string cantidad_unidad, double costo_producto,
            double precio_actual, int stock, string estado, int id_categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_Inventario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
            comando.Parameters.AddWithValue("@nom_producto", nom_producto);
            //comando.Parameters.AddWithValue("@nom_proveedor", nom_proveedor);
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            comando.Parameters.AddWithValue("@Cantidad_por_Unidad", cantidad_unidad);
            comando.Parameters.AddWithValue("@Costo_producto", costo_producto);
            comando.Parameters.AddWithValue("@precio_actual", precio_actual);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@id_categoria ", id_categoria);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void modificar_Inventario(int IdProducto, int id_proveedor, string nom_producto, int id_marca, string cantidad_unidad, double costo_producto,
            double precio_actual, int stock, string estado, int id_categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "editar_Inventario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", IdProducto);
            comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
            comando.Parameters.AddWithValue("@nom_producto", nom_producto);
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            comando.Parameters.AddWithValue("@Cantidad_por_Unidad", cantidad_unidad);
            comando.Parameters.AddWithValue("@Costo_producto", costo_producto);
            comando.Parameters.AddWithValue("@precio_actual", precio_actual);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@id_categoria ", id_categoria);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void Eliminar_Inventario(int idinventario)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "eliminar_inventario";
            comando.CommandType = CommandType.StoredProcedure;
            /*conexion.abrir();
            string query = "execute  eliminar_inventario @id_producto";
            SqlCommand c = new SqlCommand(query, conexion.abrir());*/
            comando.Parameters.AddWithValue("@id_producto", idinventario);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }






        public void insertar_categoria(string Categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_categoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", Categoria);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void modificar_categoria(int id_categoria, string Categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "editar_categoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_categoria", id_categoria);
            comando.Parameters.AddWithValue("@descripcion", Categoria);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void Eliminar_categoria(int id_categoria)
        {
            string query = "execute editar_categoria @id_categoria";
            conexion.abrir();
            SqlCommand c = new SqlCommand(query, conexion.abrir());
            c.Parameters.AddWithValue("@id_categoria", id_categoria);
            c.ExecuteNonQuery();
            c.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }


        public void insertar_Marca(string Categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_marca";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", Categoria);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void modificar_Marca(int id_marca, string Categoria)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "editar_marca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            comando.Parameters.AddWithValue("@descripcion", Categoria);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void Eliminar_marca(int id_marca)
        {
            string query = "execute eliminar_marca @id_categoria";
            conexion.abrir();
            SqlCommand c = new SqlCommand(query, conexion.abrir());
            c.Parameters.AddWithValue("@id_marca", id_marca);
            c.ExecuteNonQuery();
            c.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }








    }
}
