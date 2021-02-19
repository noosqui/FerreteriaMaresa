using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class DMO_Empleados
    {
        private int id_empleado;
        private string nombre_empleado;
        private string nombre;
        private string correo;
        private int telefono;
        private string direccion;
        private int id_usuario;

        public DMO_Empleados()
        {

        }
        public DMO_Empleados(int empleado,string nombre_empleado)
        {
            this.id_empleado = empleado;
            this.nombre_empleado = nombre_empleado;

        }

    }
}
