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
        private string nombre;
        private string apellido;
        private string correo;
        private string telefono;
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
        public DOM_Empleados(string empleado, string nombre, string apellido)

        {
            this.id_empleado = int.Parse(empleado);
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public void editar_empleado()
        {
            /*objeto.editarempleado(id_empleado, nombre, apellido, correo, long.Parse(telefono), direccion);*/
        }
        public void eliminar_empleado()
        {
            /*objeto.eliminarempleado_(id_empleado);*/
        }
    }
}
