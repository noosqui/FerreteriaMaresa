using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Dominio
{
    public class ReporteVentas
    {
        //Atributos
        public DateTime fechaReporte { get; private set; }
        public DateTime inicioFecha { get; private set; }
        public DateTime finalFecha { get; private set; }
        public List<ListaVentas> listaVentas { get; private set; }
        public List<VentasNetasPeriodo> ventasNetasPeriodo { get; private set; }
        public double totalVentas { get; private set; }


        //Metodos
        public void crearReportedVentas(DateTime deFecha, DateTime paraFecha)
        {
            //implementar fechas
            fechaReporte = DateTime.Now;
            inicioFecha = deFecha;
            finalFecha = paraFecha;
            //crear el listado de ventas
            var reportesDatos = new ReporteDatos();
            var resultado = reportesDatos.obtenerVentas(deFecha, paraFecha);

            listaVentas = new List<ListaVentas>();

            foreach (System.Data.DataRow rows in resultado.Rows)
            {
                var ModeloVentas = new ListaVentas()
                {
                    id_venta = Convert.ToInt32(rows[0]),
                    fecha = Convert.ToDateTime(rows[1]),
                    clientes = Convert.ToString(rows[2]),
                    productos = Convert.ToString(rows[3]),
                    total = Convert.ToDouble(rows[4])
                };
                listaVentas.Add(ModeloVentas);

                //calcular total ventas netas
                totalVentas += Convert.ToDouble(rows[4]);
            }

            //crear ventas netas por periodo
            //crear una lista temporal de cada dia
            var listaVentasPorFecha = (from ventas in listaVentas
                                       group ventas by ventas.fecha
                                       into listaVentas
                                       select new
                                       {
                                           fechas = listaVentas.Key,
                                           monto = listaVentas.Sum(item => item.total)
                                       }).AsEnumerable();
            //obtener el numero de dias
            int totalDias = Convert.ToInt32((paraFecha - deFecha).Days);
            //agrupar periodo por dias
            if (totalDias <= 7)
            {
                ventasNetasPeriodo = (from ventas in listaVentasPorFecha
                                      group ventas by ventas.fechas.ToString("dd.MMM.yyyy")
                                      into listaVentas
                                      select new VentasNetasPeriodo
                                      {
                                          periodo = listaVentas.Key,
                                          ventasNetas = listaVentas.Sum(item => item.monto)
                                      }).ToList();
            }
            //agrupar periodo por semana
            else if (totalDias <= 30)
            {
                ventasNetasPeriodo = (from ventas in listaVentasPorFecha
                                      group ventas by
                                      System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                          ventas.fechas, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                      into listaVentas
                                      select new VentasNetasPeriodo
                                      {
                                          periodo = "Week" + listaVentas.Key.ToString(),
                                          ventasNetas = listaVentas.Sum(item => item.monto)
                                      }).ToList();
            }
            //agrupar periodo por mes
            else if (totalDias <= 365)
            {
                ventasNetasPeriodo = (from ventas in listaVentasPorFecha
                                      group ventas by ventas.fechas.ToString("MMM.yyyy")
                                      into listaVentas
                                      select new VentasNetasPeriodo
                                      {
                                          periodo = listaVentas.Key,
                                          ventasNetas = listaVentas.Sum(item => item.monto)
                                      }).ToList();
            }
            //agrupar periodo por año
            else
            {
                ventasNetasPeriodo = (from ventas in listaVentasPorFecha
                                      group ventas by ventas.fechas.ToString("yyyy")
                                      into listaVentas
                                      select new VentasNetasPeriodo
                                      {
                                          periodo = listaVentas.Key,
                                          ventasNetas = listaVentas.Sum(item => item.monto)
                                      }).ToList();
            }
        }
    }
}
