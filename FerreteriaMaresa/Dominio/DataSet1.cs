using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DataSet1
    {
        public string idCompra { get; set; }
        public string fecha { get; set; }
        public string idProveedor { get; set; }
        public string idEmpleado { get; set; }
        public string idTipoPago { get; set; }
        public string descuento { get; set; }
        public string subtotal { get; set; }

        public DataSet1() { }
    }
}
