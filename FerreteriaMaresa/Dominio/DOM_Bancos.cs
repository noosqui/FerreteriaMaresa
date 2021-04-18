using Datos;
using System.Data;

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
