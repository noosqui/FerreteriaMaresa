using System;
using System.Collections.Generic;
using System.Data;

namespace Dominio
{
    public class ReporteFactura
    {
        //crear el listado de ventas

        public List<Factura> listaFactura { get; private set; }
        public double total { get; set; }
        public double descuento { get; set; }
        public double impuesto { get; set; }
        public DateTime fechaAct { get; set; }
        public string idEmpleado { get; set; }
        public string tipoFact { get; set; }
        public double subtotal { get; set; }


        public void crearFactura(DataTable Factura, string total, string descuento, string impuesto, string idEmpleado, string tipoFact, string subtotal)
        {
            listaFactura = new List<Factura>();
            var resultado = Factura;
            this.total = double.Parse(total);
            this.descuento = double.Parse(descuento);
            this.impuesto = double.Parse(impuesto);
            this.idEmpleado = idEmpleado;
            this.tipoFact = tipoFact;
            this.subtotal = Convert.ToDouble(subtotal);
            fechaAct = DateTime.Now;
            List<Factura> listtmp = new List<Factura>();
            foreach (DataRow rows in resultado.Rows)
            {
                Factura fact = new Factura();
                fact.Id = int.Parse(rows[0].ToString());
                fact.nomProd = rows[1].ToString();
                fact.price = double.Parse(rows[2].ToString());
                fact.Cantidad = int.Parse(rows[3].ToString());
                fact.CantxUnidad = rows[4].ToString();

                listaFactura.Add(fact);
            }
        }


    }
}
