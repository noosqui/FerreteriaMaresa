using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class DAT_Empleados
    {

        private DAT_Conexion conexion = new DAT_Conexion();
        SqlDataReader leer;

        DataTable tabla = new DataTable();

        public SqlDataReader VerificarUsuario(string usuario, string contrasenia)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "VerificarUsuario";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            return leer;
        }

        public DataTable Mostrar_Empleados_Activos()
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Empleados_Activos";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public DataTable Buscar_Empleado_Activo(string id_empleado)
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "buscar_Empleado_Activo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempleado", id_empleado);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public DataTable Mostrar_Empleados_Despedidos()
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Empleados_Despedidos";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public DataTable Buscar_Empleado_Despedido(string id_empleado)
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "buscar_Empleado_Despedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempleado", id_empleado);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }
        public void insertar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, long telEmpleado, string direccion, string ciudad, string region, string codigopostal, string pais, int idrol, DateTime fnacimiento, string estado, string contrasenia)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
            comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
            comando.Parameters.AddWithValue("@correoEmpleado", correoEmpleado);
            comando.Parameters.AddWithValue("@telEmpleado", telEmpleado);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@codigo_postal", codigopostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@id_rol_empleado", idrol);
            comando.Parameters.AddWithValue("@fnacimiento_empleado", fnacimiento);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);

            comando.ExecuteNonQuery();
        }

        public void Editar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, long telEmpleado, string direccion, string ciudad, string region, string codigopostal, string pais, int idrol, DateTime fnacimiento, string estado, string contrasenia)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "editar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
            comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
            comando.Parameters.AddWithValue("@correoEmpleado", correoEmpleado);
            comando.Parameters.AddWithValue("@telEmpleado", telEmpleado);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@codigo_postal", codigopostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@id_rol_empleado", idrol);
            comando.Parameters.AddWithValue("@fnacimiento_empleado", fnacimiento);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);

            comando.ExecuteNonQuery();
        }

        public void DespedirEmpleado(string idempleado)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Despedir_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempleado", idempleado);
            comando.ExecuteNonQuery();

        }
    }
}
