using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class DOM_Empleados
    {
        private int id_empleado;
        private string nombre_empleado;
        private string nombre;
        private string correo;
        private int telefono;
        private string direccion;
        private int id_usuario;

        public DOM_Empleados()
        {

        }
        public DOM_Empleados(string empleado, string nombre)

        {
            this.id_empleado = int.Parse(empleado);
            this.nombre = nombre;
        }



    }
}
