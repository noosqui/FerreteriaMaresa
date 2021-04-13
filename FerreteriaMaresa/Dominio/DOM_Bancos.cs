using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Dominio
{
     public class DOM_Bancos
    {
        private CD_Bancos bancos = new CD_Bancos();
        public DOM_Bancos()
        {

        }


        public DataTable mostrarBancos()
        {
            return bancos.Mostrar_Bancos();
        }
    }
}
