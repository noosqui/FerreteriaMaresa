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
        private CD_Empleados emple = new CD_Empleados();
        private string idEmpleado;

        public DataTable CargarDGVEmpleados()
        {
            return emple.Mostrar_Empleados();
        }


        public DataTable autentificacion_empleado(string usuario, string contrasenia)
        {

            return emple.VerificarUsuario(usuario, contrasenia);

        }

        public String Id_empleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public void modificar_empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado, 
            string correoEmpleado, string telEmpleado, string direccion, string ciudad, string region, 
            string codigopostal, string pais, string idrol, string fnacimiento, string estado)
        {
            emple.Editar_Empleado(idEmpleado,nombreEmpleado,apellidoEmpleado,correoEmpleado,telEmpleado,direccion, 
                ciudad,region,codigopostal,pais, int.Parse(idrol), fnacimiento,estado);
        }

        public void agregar_empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado,
            string correoEmpleado, string telEmpleado, string direccion, string ciudad, string region,
            string codigopostal, string pais, string idrol, string fnacimiento, string estado)
        {
            emple.insertar_Empleado(idEmpleado, nombreEmpleado, apellidoEmpleado, correoEmpleado, telEmpleado, direccion,
                ciudad, region, codigopostal, pais, int.Parse(idrol), fnacimiento, estado);
        }

        public void eliminar_empleado(string idEmpleado)
        {
            emple.DespedirEmpleado(idEmpleado);
        }

        public DataTable roles_combobox()
        {
            return emple.cargar_roles();
        }

        public void Restablecer_Contrasenia(string correo, string contrasenia)
        {
            emple.Restablecer_Contrasenia(correo, contrasenia);
        }
    }
}
