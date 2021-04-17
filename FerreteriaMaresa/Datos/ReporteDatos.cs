using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ReporteDatos:CD_Conexion
    {
        public DataTable obtenerVentas(DateTime deFecha, DateTime paraFecha)
        {
            using (var cd = abrir())
            {
                cd.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cd;
                    cmd.CommandText = "@ObtenerVentas";
                    cmd.Parameters.AddWithValue("@deFecha", deFecha);
                    cmd.Parameters.AddWithValue("@paraFecha", paraFecha);
                    cmd.CommandType = CommandType.StoredProcedure;

                    var reader = cmd.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;

                }
            }
        }
    }
}
