using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
    public class DOM_Facturacion 
        {
            public DOM_Inventario product = new DOM_Inventario();
            public CD_Facturacion facturacion = new CD_Facturacion();
            public DOM_Empleados empleados = new DOM_Empleados();
            public  DataTable tabla = new DataTable();
            public DOM_proveedor proveedor = new DOM_proveedor();
            

            //DOM_Cliente cliente = new DOM_Cliente();
            public DOM_Facturacion()
            {

            }

        public void InsertarFacturaVenta(/*DOM_Empleados emp*/string id_emplado, string idCliente, string subtotal, string rtn, string isv, string descuento, string tipopago)
        {
            //empleados = emp;
            facturacion.insertar_FacturaVenta(DateTime.Now, idCliente, id_emplado/* empleados.Id_empleado*/, int.Parse(tipopago), rtn, 0.15, double.Parse(descuento), double.Parse(subtotal));

        }



        public void InsertarFacturaCompra(string descuento, string subtotal, string tipoPago, string idEmpleado, string idProveedor, string isv)
        {
            facturacion.insertar_FacturaCompra(DateTime.Now, int.Parse(idProveedor),idEmpleado, int.Parse(tipoPago), 0.15, double.Parse(descuento), double.Parse(subtotal));
        }



        public void insertarDetalleVenta (string cantidad,DOM_Inventario inv)
            {
             product = inv;
             DataRow ultimaFila = facturacion.Mostrar_FacturaVenta().Rows[facturacion.Mostrar_FacturaVenta().Rows.Count -1];

             facturacion.insertar_DetalleVenta(inv.Id_producto, ultimaFila.Field<int>("id_venta"), inv.Precio_actual, int.Parse(cantidad));
            }
        public void insertarDetalleCompra(string cantidad,DOM_Inventario inv)
        {
         product = inv;
         DataRow ultimaFila = facturacion.Mostrar_FacturaCompras().Rows[facturacion.Mostrar_FacturaCompras().Rows.Count - 1];
         facturacion.insertar_DetalleCompra(inv.Id_producto, ultimaFila.Field<int>("Id Compra"), inv.Precio_actual, int.Parse(cantidad));
        }

        public DataTable MostrarFacturaVenta()
        {
         tabla= facturacion.Mostrar_FacturaVenta();
         return tabla;

        }
            public DataTable MostrarFacturaCompra()
             {
                tabla = facturacion.Mostrar_FacturaCompras();
                return tabla;
             }  
        public DataTable MostrarDetalleVenta()
        {
            tabla = facturacion.SP_Detalle_Venta();
            return tabla;
        }
        public DataTable MostrarDetalleCompra()
        {
            tabla = facturacion.SP_Detalle_Compra();
            return tabla;
        }

        public void Insertar_Cheque(string numcuenta, DateTime date, string RutaBancaria, string numeroCheque, string idBanco, string monto)
        {
            facturacion.Insertar_Cheque(numcuenta, date, RutaBancaria, numeroCheque, int.Parse(idBanco), float.Parse(monto));
        }
   
        }
}
