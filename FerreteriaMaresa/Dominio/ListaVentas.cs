using System;
namespace Dominio
{
    public class ListaVentas
    {
        public int id_venta { get; set; }
        public DateTime fecha { get; set; }
        public string clientes { get; set; }
        public string productos { get; set; }
        public double total { get; set; }

        
    }
}