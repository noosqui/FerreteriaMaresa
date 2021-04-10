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
        private string idCliente;
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

        public DOM_Clientes() { 
        }

        public DOM_Clientes(string id_Cliente, string nombre, string apellido, string rtn, string direccion,
            string ciudad, string region, string codigo_postal, string pais, string telefono) {

            this.idCliente = id_Cliente;
            this.nombrecliente = nombre;
            this.apellidocliente = apellido;
            this.RTN = rtn;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.region = region;
            this.codigo_postal = codigo_postal;
            this.pais = pais;
            this.telefono = telefono;
        }

        public string Id_cliente
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

        public string Rtn 
        {
            get { return RTN; }
            set { RTN = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string Codigo_Postal
        {
            get { return codigo_postal; }
            set { codigo_postal = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        



        public void editar_Clientes(string idCliente, string nombrecliente, string apellidocliente, string RTN,
            string direccion, string ciudad, string region, string codigo_postal, string pais, string telefono)
        {
            cli.Editar_Cliente(idCliente, nombrecliente, apellidocliente, RTN, direccion, ciudad, region, codigo_postal, pais, telefono);
        }

        public void eliminar_empleado(string id_Cliente)
        {
            cli.Eliminar_Cliente(id_Cliente);
        }

        public void crear_Cliente(string idCliente, string nombrecliente, string apellidocliente,
            string RTN, string direccion, string ciudad, string region,
            string codigo_postal, string pais, string telefono)
        {
            cli.insertar_Cliente(idCliente, nombrecliente, apellidocliente, RTN, direccion, ciudad, region, codigo_postal, pais, telefono);
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