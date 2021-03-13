using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
     public class CD_Bancos

    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader lee;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar_Bancos()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Bancos";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable buscar_Bancos(string Nombrebanco)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Buscar_Bancos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombrebanco", Nombrebanco);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

    }
}
