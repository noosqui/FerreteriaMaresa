using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Empleados
    {

        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader lee;
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();


        public DataTable VerificarUsuario(string usuario, string contrasenia)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "VerificarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable Mostrar_Empleados()
        {
            tabla.Rows.Clear();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Empleados";
            comando.CommandType = CommandType.StoredProcedure;
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

        public void insertar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, string telEmpleado, string direccion, string ciudad, string region, string codigopostal, string pais, int idrol, string fnacimiento, string estado,string contrasenia)
        {

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
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }

        public void Editar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, string telEmpleado, string direccion, string ciudad, string region, string codigopostal, string pais, int idrol, string fnacimiento, string estado)
        {
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
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();

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

        public void Restablecer_Contrasenia(string correo, string contrasenia)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Restablecer_Contrasenia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
            comando.Parameters.Clear();
        }
    }
}
