using System.Data;
using System.Data.SqlClient;



namespace Datos
{
    public class CD_Conexion
    {
        public SqlConnection Conectarbd = new SqlConnection("server=(local);DataBase= Ferreteria_Maresa;Integrated Security=True");

        public SqlConnection abrir()
        {

            if (Conectarbd.State == ConnectionState.Closed)
            {
                Conectarbd.Open();
            }

            return Conectarbd;
        }

        public SqlConnection cerrar()
        {
            if (Conectarbd.State == ConnectionState.Open)
            {
                Conectarbd.Close();
            }

            return Conectarbd;


        }
    }
}
