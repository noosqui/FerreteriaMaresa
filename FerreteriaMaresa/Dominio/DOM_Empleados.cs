using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{

     public class DOM_Empleados
    {
        private string idEmpleado;
        private string nombreEmpleado;
        private string apellidoEmpleado;
        private string correoEmpleado;
        private string telEmpleado;
        private string direccion;
        private string ciudad;
        private string region;
        private string codigopostal;
        private string pais;
        private int idrol;
        private string fnacimiento;
        private string estado;

        private int tipo_emp;
        private CD_Empleados emple = new CD_Empleados();


        public DOM_Empleados()
        {

        }
        public DOM_Empleados(string empleado, string nombre, string apellido)
        {

            this.idEmpleado = empleado;
            this.nombreEmpleado = nombre;
            this.apellidoEmpleado = apellido;
        }

        public string Id_empleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        public string Nombre
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }
        public string Apellido
        {
            get { return apellidoEmpleado; }
            set { apellidoEmpleado = value; }
        }
        public string Correo
        {
            get { return correoEmpleado; }
            set { correoEmpleado = value; }
        }
        public string Telefono
        {
            get { return telEmpleado; }
            set { telEmpleado = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public DataTable Mostrar_Empleados()
        {
            return emple.Mostrar_Empleados();
        }
        public int Tipoemp
        {
            get { return idrol; }
            set { idrol = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public void Editar_Empleado()

        {
            emple.Editar_Empleado(Id_empleado, nombreEmpleado, apellidoEmpleado, correoEmpleado, long.Parse(telEmpleado), direccion, ciudad, region, codigopostal, pais, idrol, DateTime.Parse(fnacimiento), estado);
        }
        public void eliminar_empleado()
        {
            emple.DespedirEmpleado(idEmpleado);
        }
        public void crear_empleado()
        {
            emple.insertar_Empleado(Id_empleado, nombreEmpleado, apellidoEmpleado, correoEmpleado, long.Parse(telEmpleado), direccion, ciudad, region, codigopostal, pais, idrol, DateTime.Parse(fnacimiento), estado);
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
