using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ReporteDatos : CD_Conexion
    {
        public DataTable obtenerVentas(DateTime deFecha, DateTime paraFecha)
        {
            using (var cd = abrir())
            {
                cd.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cd;
                    cmd.CommandText = "@ReporteFacturaVentas";
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
