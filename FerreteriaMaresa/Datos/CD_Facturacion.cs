using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
     public class CD_Facturacion
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader lee;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void insertar_FacturaVenta(DateTime Fecha, string IdCliente, string IdEmpleado, int Tipopago, double Descuento, double Subtotal)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_FacturaVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            comando.Parameters.AddWithValue("@IdTipoPago", Tipopago);
            comando.Parameters.AddWithValue("@Descuento", Descuento);
            comando.Parameters.AddWithValue("@SubTotal", Subtotal);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public DataTable Mostrar_FacturaVenta()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "SP_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public void insertar_FacturaCompra(DateTime Fecha, int IdProveedor, string IdEmpleado, int Tipopago, double Descuento, double Subtotal)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_FacturaCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            comando.Parameters.AddWithValue("@IdTipoPago", Tipopago);
            comando.Parameters.AddWithValue("@Descuento", Descuento);
            comando.Parameters.AddWithValue("@SubTotal", Subtotal);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public DataTable Mostrar_FacturaCompras()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "SP_Compras";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public void insertar_DetalleCompra(int IdProducto, int IdCompra, double Precio, int Cantidad)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_DetalleCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", IdProducto);
            comando.Parameters.AddWithValue("@IdCompra", IdCompra);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public DataTable SP_Detalle_Compra()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "SP_Detalle_Compra";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public void insertar_DetalleVenta(int IdProducto, int IdVenta, double Precio, int Cantidad)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "insertar_DetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", IdProducto);
            comando.Parameters.AddWithValue("@IdVenta", IdVenta);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.cerrar();
        }

        public DataTable SP_Detalle_Venta()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "SP_Detalle_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable Reporte_Compras()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Reporte_Compras";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable Reporte_Ventas()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Reporte_Ventas";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable buscar_DetalleVenta(int id_venta)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Buscar_Detalle_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idventa", id_venta);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }

        public DataTable buscar_Detalle_Compra(int id_compra)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "Buscar_Detalle_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcompra", id_compra);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            comando.Connection = conexion.cerrar();
            return tabla;
        }
    }
}
