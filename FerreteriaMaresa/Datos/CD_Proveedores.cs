using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Proveedores
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Proveedor()
        {
            tabla.Rows.Clear();
            comando.Connection = conexion.abrir();
            comando.CommandText = "Mostrar_Proveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.cerrar();
            leer.Close();
            return tabla;
        }



        public void insertar_Proveedor(string nombreProveedor, string telProveedor, string correo, string direccion, string ciudad, string region, string codigopostal, string pais, string estado)
        {

            comando.Connection = conexion.abrir();
            comando.CommandText = "pro_insertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nom_proveedor", nombreProveedor);
            comando.Parameters.AddWithValue("@telefono", telProveedor);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@codigo_postal", codigopostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@Estado", estado);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public void Editar_Proveedores(string idProveedor, string nombreProveedor, string telProveedor, string correo, string direccion, string ciudad, string region, string codigopostal, string pais, string estado)
        {

            comando.Connection = conexion.abrir();
            comando.CommandText = "modificar_Proveedrores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", idProveedor);
            comando.Parameters.AddWithValue("@nom_proveedor", nombreProveedor);
            comando.Parameters.AddWithValue("@telefono", telProveedor);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@codigo_postal", codigopostal);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@Estado", estado);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public void eliminarempleado(string idproveedor)
        {

            comando.Connection = conexion.abrir();
            comando.CommandText = "eliminar_proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", idproveedor);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public void Reactivar_proveedor(string idproveedor)
        {

            comando.Connection = conexion.abrir();
            comando.CommandText = "Reactivar_proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", idproveedor);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

    }
}
