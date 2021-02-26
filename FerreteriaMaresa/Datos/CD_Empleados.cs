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
        SqlDataReader leer;

        DataTable tabla = new DataTable();

        public SqlDataReader verifica(string user, string pass)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "validarUsuario";
            comando.Parameters.AddWithValue("@userName", user);
            comando.Parameters.AddWithValue("@psw", pass);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            return leer;
        }

        public DataTable mostrarempleados()
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "Mostrar_Empleados";
            comandoo.CommandType = CommandType.StoredProcedure;
            lee = comandoo.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public void insertar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, long telEmpleado, int coddireccion, int idrol, DateTime fnacimiento, string estado, string contrasenia)
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
            comando.Parameters.AddWithValue("@cod_direccion", coddireccion);
            comando.Parameters.AddWithValue("@id_rol_empleado", idrol);
            comando.Parameters.AddWithValue("@fnacimiento_empleado", fnacimiento);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);

            comando.ExecuteNonQuery();
        }

        public void Editar_Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, string correoEmpleado, long telEmpleado, int cod_direccion, int idrol, DateTime fnacimiento, string estado, string contrasenia)
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
            comando.Parameters.AddWithValue("@cod_direccion", cod_direccion);
            comando.Parameters.AddWithValue("@id_rol_empleado", idrol);
            comando.Parameters.AddWithValue("@fnacimiento_empleado", fnacimiento);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);

            comando.ExecuteNonQuery();
        }

        public void eliminarempleado(string idempleado)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "eliminar_empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempleado", idempleado);
            comando.ExecuteNonQuery();
        }
    }
}
