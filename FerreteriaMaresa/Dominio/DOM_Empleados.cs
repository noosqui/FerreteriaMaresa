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
        private int tipo_emp;
        private int estado;

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
        public void crear_empleado()
        {
            /*objeto.crearempleado(id_empleado,_nombre,apellido,correo,telefono,direccion,contrasenia)*/
        }
        public Boolean autentificacion_empleado(string usuario, string contrasenia)
        {
            /*
             Datatable table = new Datatable()


             
             */
            //tabla = objeto.autentificar(usuario,contrasenia)
            /*
             * if (tabla.hasrows())
               {
                obtenerEmpleado();
                return true;
                }
            else 
            return false();
            */
            return false;
        }
        /*Public int tipoemp()
         * {
         * tabla = objeto.tipEmp(id_usuario);
         * this.tipo_emp = int.parse(tabla.column("tipo_empleado).row(1).toString());
         * }
         * 
        */
        /*
         * public obtenerEmpleado()
         * {
         *  this.id_empleado = int.Parse((tabla.column("id_empleado").row(1).toString()))
                this.nombre = tabla.column("nombre").row(1).toString();
                this.apellido = tabla.column("apellido").row(1).toString();
                this.correo = tabla.column("correo").row(1).toString();
                this.telefono = tabla.column("telefono").row(1).toString();
                this.direccion = tabla.column("direccion").row(1).toString();
                this.id_usuario = tabla.column("id_usuario").row(1).toString();
             this.tipo_emp = int.parse(tabla.column("tipo_empleado).row(1).toString());
         * }
         *          * */
        /*
         public DataTable obtenerEmpleados()
        {
        return objeto.buscarEmp()
        }
         */



    }
}
