using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Empleados
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader lee;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable VerificarUsuario(string usuario, string contrasenia)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "VerificarUsuario";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable Mostrar_Empleados()
        {
            tabla.Rows.Clear();
            comando.Connection = conexion.abrir();
            comando.CommandText = "execute Mostrar_Empleados";
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            conexion.cerrar();
            return tabla;
        }

        public DataTable Buscar_Empleado(string id_empleado)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "buscar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempleado", id_empleado);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public void insertar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, string telEmpleado, string direccion, string ciudad, string region, string codigopostal, string pais, int idrol, string fnacimiento, string estado)
        {
            string query = "execute [insertar_Empleado] @idEmpleado, @nombreEmpleado,@apellidoEmpleado,@correoEmpleado," +
                "@telEmpleado,@direccion,@ciudad,@region,@codigo_postal,@pais,@id_rol_empleado," +
                "@fnacimiento_empleado,@estado";
            conexion.abrir();
            SqlCommand c = new SqlCommand(query, conexion.abrir());
            c.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            c.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
            c.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
            c.Parameters.AddWithValue("@correoEmpleado", correoEmpleado);
            c.Parameters.AddWithValue("@telEmpleado", telEmpleado);
            c.Parameters.AddWithValue("@direccion", direccion);
            c.Parameters.AddWithValue("@ciudad", ciudad);
            c.Parameters.AddWithValue("@region", region);
            c.Parameters.AddWithValue("@codigo_postal", codigopostal);
            c.Parameters.AddWithValue("@pais", pais);
            c.Parameters.AddWithValue("@id_rol_empleado", idrol);
            c.Parameters.AddWithValue("@fnacimiento_empleado", fnacimiento);
            c.Parameters.AddWithValue("@estado", estado);

            c.ExecuteNonQuery();
            c.Connection = conexion.cerrar();
        }

        public void Editar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, string telEmpleado, string direccion, string ciudad, string region, string codigopostal, string pais, int idrol, string fnacimiento, string estado)
        {
            string query = "execute [editar_Empleado] @idEmpleado, @nombreEmpleado,@apellidoEmpleado,@correoEmpleado," +
                "@telEmpleado,@direccion,@ciudad,@region,@codigo_postal,@pais,@id_rol_empleado," +
                "@fnacimiento_empleado,@estado";
            conexion.abrir();
            SqlCommand c = new SqlCommand(query,conexion.abrir());
            c.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            c.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
            c.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
            c.Parameters.AddWithValue("@correoEmpleado", correoEmpleado);
            c.Parameters.AddWithValue("@telEmpleado", telEmpleado);
            c.Parameters.AddWithValue("@direccion", direccion);
            c.Parameters.AddWithValue("@ciudad", ciudad);
            c.Parameters.AddWithValue("@region", region);
            c.Parameters.AddWithValue("@codigo_postal", codigopostal);
            c.Parameters.AddWithValue("@pais", pais);
            c.Parameters.AddWithValue("@id_rol_empleado", idrol);
            c.Parameters.AddWithValue("@fnacimiento_empleado", fnacimiento);
            c.Parameters.AddWithValue("@estado", estado);

            c.ExecuteNonQuery();
            c.Connection = conexion.cerrar();
        }

        public void DespedirEmpleado(string idempleado)
        {
            string query = "execute [Despedir_Empleado] @idEmpleado";
            conexion.abrir();
            SqlCommand c = new SqlCommand(query, conexion.abrir());
            c.Parameters.AddWithValue("@idempleado", idempleado);
            c.ExecuteNonQuery();
            c.Connection = conexion.cerrar();
        }

        public void ReContratarEmpleado(string idempleado)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "ReContratar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempleado", idempleado);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public DataTable cargar_roles()
        {
            DataTable t = new DataTable();
            string query = "select * from [roles]";
            SqlCommand co = new SqlCommand(query, conexion.abrir());
            lee = co.ExecuteReader();
            t.Load(lee);
            conexion.cerrar();
            return t;
        }
    }
}
