using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class CD_Inventario
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;

        DataTable tabla = new DataTable();
        //Este es el de Inventario
        public void SP_Consulta_In(int Id_Pro, String Nombre_Pro, int Id_Marca, int Cantidad, double Costo, double Precio, int Stock, String Estado, int Id_Categoria)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "SP_Consulta_In";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@id_producto", Id_Pro);
            comandoo.Parameters.AddWithValue("@nom_producto", Nombre_Pro);
            comandoo.Parameters.AddWithValue("@id_marca", Id_Marca);
            comandoo.Parameters.AddWithValue("@Cantidad_por_Unidad", Cantidad);
            comandoo.Parameters.AddWithValue("@Costo_producto", Costo);
            comandoo.Parameters.AddWithValue("@precio_actual", Precio);
            comandoo.Parameters.AddWithValue("@stock", Stock);
            comandoo.Parameters.AddWithValue("@Estado", Estado);
            comandoo.Parameters.AddWithValue("@id_categoria", Id_Categoria);
            comandoo.ExecuteNonQuery();

        }

        // Este es el de Compra
        public void SP_Consulta_Co(int Id_Com, DataSetDateTime Fecha, int Id_Prov, String Id_Emple, int Id_TipoPago, float Descuento, float SubTotal)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "SP_Consulta_Co";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@id_compra", Id_Com);
            comandoo.Parameters.AddWithValue("@fecha", DateTime.Now);
            comandoo.Parameters.AddWithValue("@id_proveedor", Id_Prov);
            comandoo.Parameters.AddWithValue("@id_empleado", Id_Emple);
            comandoo.Parameters.AddWithValue("@id_tipo_pago", Id_TipoPago);
            comandoo.Parameters.AddWithValue("@descuento", Descuento);
            comandoo.Parameters.AddWithValue("@subtotal", SubTotal);
            comandoo.ExecuteNonQuery();

        }

        //Este es el de Venta
        public void SP_Consulta_Co(int Id_Ven, DataSetDateTime Fecha, String Id_Cli, String Id_Emple, int Id_TipoPago, float Descuento, float SubTotal)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "SP_Consulta_Ve";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@id_venta", Id_Ven);
            comandoo.Parameters.AddWithValue("@fecha", DateTime.Now);
            comandoo.Parameters.AddWithValue("@id_cliente", Id_Cli);
            comandoo.Parameters.AddWithValue("@id_empleado", Id_Emple);
            comandoo.Parameters.AddWithValue("@id_tipo_pago", Id_TipoPago);
            comandoo.Parameters.AddWithValue("@descuento", Descuento);
            comandoo.Parameters.AddWithValue("@subtotal", SubTotal);
            comandoo.ExecuteNonQuery();

        }


        //Destalle de compra
        public void SP_Consulta_DC(int Id_DetalleC, int Id_Prod, double Precio, int Cantida, float ISV, int Id_Categorias)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "SP_Consulta_Ve";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@id_detalle_compra", Id_DetalleC);
            comandoo.Parameters.AddWithValue("@id_producto", Id_Prod);
            comandoo.Parameters.AddWithValue("@precio", Cantida);
            comandoo.Parameters.AddWithValue("@isv", ISV);
            comandoo.Parameters.AddWithValue("@id_categoria", Id_Categorias);
            comandoo.ExecuteNonQuery();

        }

        public void SP_disminuir_stock_DC(string codproduct, int cantidad)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "SP_Venta";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@CodProd", codproduct);
            comandoo.Parameters.AddWithValue("@Cantida", cantidad);
 
            comandoo.ExecuteNonQuery();

        }

        public void SP_Aumentar_stock_DC(string codproduct, int cantidad)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "SP_Compra";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@CodProd", codproduct);
            comandoo.Parameters.AddWithValue("@Cantida", cantidad);

            comandoo.ExecuteNonQuery();

        }
    }
}
