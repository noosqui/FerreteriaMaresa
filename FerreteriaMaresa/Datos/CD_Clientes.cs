using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader lee;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar_Cliente()
        {
            SqlDataReader lee;
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Clientes";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            conexion.cerrar();
            return tabla;
        }

        public DataTable buscar_Clientes(int id_cliente)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "buscar_Clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", id_cliente);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public void insertar_Cliente(int idcliente, string nombrecliente, string apellidocliente, string RTN, string direccion, string ciudad, string region, string codigopostal, string pais, long telefono)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@nombrecliente", nombrecliente);
            comando.Parameters.AddWithValue("@apellidocliente", apellidocliente);
            comando.Parameters.AddWithValue("@RTN", RTN);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@codigo_postal", codigopostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@telefono", telefono);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public void Editar_Cliente(int idcliente, string nombrecliente, string apellidocliente, string RTN, string direccion, string ciudad, string region, string codigopostal, string pais, long telefono)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "editar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@nombrecliente", nombrecliente);
            comando.Parameters.AddWithValue("@apellidocliente", apellidocliente);
            comando.Parameters.AddWithValue("@RTN", RTN);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@codigo_postal", codigopostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@telefono", telefono);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public void Eliminar_Cliente(int idcliente)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Eliminar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }
    }
}
