using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
     public class DOM_proveedor
    {


        private int id_proveedor;
        private string nom_proveedor;
        private string apellido_proveedor;
        private string correo;
        private string telefono;
        private string direccion;
        //arreglar direccion

        public DOM_proveedor()
        {
        }

        public DOM_proveedor(string empleado,string nombre,string apellido)
        {
            this.id_proveedor = int.Parse(empleado);
            this.nom_proveedor = nombre;
            this.apellido_proveedor = apellido;
        }

        public int Id_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }
        public string Nombre
        {
            get { return nom_proveedor; }
            set { nom_proveedor = value; }
        }
        public string Apellido
        {
            get { return apellido_proveedor; }
            set { apellido_proveedor = value; }
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


        public void editar_proveedor()
        {
            // objeto.editar_proveedor(id_proveedor, nom_proveedor, apellido_proveedor, correo, telefono, direccion);/
        }
        public void eliminar_empleado()
        {
            // objeto.eliminarproveedor(id_proveedor);/
        }
        public void crear_proveedor()
        {
            // objeto.crearproveedor(id_proveedor, nom_proveedor, apellido_proveedor, correo, telefono, direccion) /
        }



    }

}

