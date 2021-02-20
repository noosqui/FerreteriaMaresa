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

        /* Cosas a seguir 
         * 1. Todos los metodos reciben strings ninguno recibe algo mas.
         * 2. Como todo recibe string hay que hacer las conversiones dentro de los metodos (mirar ejemplo de constructor)
         * 3. Los procesos hacen referencia a capas inexistentes y metodos inexistentes de la capa datos, esos dejarlos asi
         * 4. Las de capa datos sera DAT_nombre
         * */

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
