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

        public DOM_Clientes(string Cliente, string nombre, string apellido)
        {
            this.idCliente = int.Parse(Cliente);
            this.nombrecliente = nombre;
            this.apellidocliente = apellido;
        }
        public DOM_Clientes ()
        {

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


        public void editar_Clientes()
        {
            cli.Editar_Cliente(idCliente, nombrecliente, apellidocliente, RTN, telefono, direccion, ciudad, region, codigo_postal, long.Parse(pais));
        }
        public void eliminar_empleado()
        {
            cli.Eliminar_Cliente(idCliente);
        }
        public void crear_Cliente()
        {
            cli.insertar_Cliente(idCliente, nombrecliente, apellidocliente, RTN, telefono, direccion, ciudad, region, codigo_postal, long.Parse(pais));
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