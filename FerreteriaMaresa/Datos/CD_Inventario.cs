using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
     public class CD_Inventario

    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader lee;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Inventario()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "SP_Inventario";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
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
        }

        public void Inventario_Activo(int idproducto)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Inventario_Activo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", idproducto);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }
        public DataTable Mostrar_Marcas()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Marcas";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
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
            return tabla;
        }

        public DataTable Mostrar_Categorias()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Categorias";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
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
            return tabla;
        }
    }
}
