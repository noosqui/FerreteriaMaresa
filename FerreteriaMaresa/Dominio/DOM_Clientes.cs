using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Dominio


{
    public class DOM_Clientes

    {
        private int idCliente;
        private string nombrecliente;
        private string apellidocliente;
        private string RTN;
        private string telefono;
        private string direccion;
        private string ciudad;
        private string region;
        private string codigo_postal;
        private string pais;
        private CD_Clientes cli = new CD_Clientes();

<<<<<<< HEAD
        public DOM_Clientes() { 
        
        }

        public DOM_Clientes(string id_Cliente, string nombre, string apellido, string rtn, string direccion,
            string ciudad, string region, string codigo_postal, string pais, string telefono)
=======
        public DOM_Clientes(string Cliente, string nombre, string apellido)
>>>>>>> upstream/Beta
        {
            this.idCliente = int.Parse(Cliente);
            this.nombrecliente = nombre;
            this.apellidocliente = apellido;
<<<<<<< HEAD
            this.RTN = rtn;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.region = region;
            this.codigo_postal = codigo_postal;
            this.pais = pais;
            this.telefono = telefono;

=======
        }
        public DOM_Clientes ()
        {
>>>>>>> upstream/Beta

        }

        public int Id_empleado
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string Nombre
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        public string Apellido
        {
            get { return apellidocliente; }
            set { apellidocliente = value; }
        }
        public string Correo
        {
            get { return RTN; }
            set { RTN = value; }
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


<<<<<<< HEAD
        public void editar_Clientes(string idCliente, string nombrecliente, string apellidocliente, string RTN,
            string direccion, string ciudad, string region, string codigo_postal, string pais, string telefono)
=======
        public void editar_Clientes()
>>>>>>> upstream/Beta
        {
            cli.Editar_Cliente(idCliente, nombrecliente, apellidocliente, RTN, direccion, ciudad, region, codigo_postal, pais, telefono);
        }
<<<<<<< HEAD

        public void eliminar_empleado(string idCliente)
        {
            cli.Eliminar_Cliente(idCliente);
        }

        public void crear_Cliente(string idCliente, string nombrecliente, string apellidocliente,
            string RTN, string direccion, string ciudad, string region, 
            string codigo_postal, string pais, string telefono)
=======
        public void eliminar_empleado()
        {
            cli.Eliminar_Cliente(idCliente);
        }
        public void crear_Cliente()
>>>>>>> upstream/Beta
        {
            cli.insertar_Cliente(idCliente, nombrecliente, apellidocliente, 
                RTN, direccion, ciudad, region, codigo_postal, pais, telefono);
        }

        public DataTable Mostrar_Cliente()
        {
            return cli.Mostrar_Cliente();
        }
        public void Buscar_Cliente()
        {
            cli.buscar_Clientes(idCliente);
        }
    }
}