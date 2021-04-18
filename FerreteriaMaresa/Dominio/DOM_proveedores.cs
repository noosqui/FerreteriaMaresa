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
        private string region;
        private string ciudad;
        private string codPostal;
        private string pais;
        private string estado;

        private CD_Proveedores prov = new CD_Proveedores();
        public DOM_proveedor()
        {
        }

        public DOM_proveedor(string empleado, string nombre, string apellido)
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

        public string Nom_proveedor
        {
            get { return nom_proveedor; }
            set { nom_proveedor = value; }
        }
        public string Apellido_proveedor
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

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void editar_proveedor(string idProveedor, string nombreProveedor, string telProveedor, string correo, string direccion, string ciudad, string region, string codigopostal, string pais, string estado)
        {
            prov.Editar_Proveedores(idProveedor, nombreProveedor, telProveedor, correo, direccion, ciudad, region, codigopostal, pais, estado);
        }
        public void eliminar_empleado(string idProveedor)
        {
            prov.eliminarempleado(idProveedor);
        }
        public void crear_proveedor(string nombreProveedor, string telProveedor, string correo, string direccion, string ciudad, string region, string codigopostal, string pais, string estado)
        {
            prov.insertar_Proveedor(nombreProveedor, telProveedor, correo, direccion, ciudad, region, codigopostal, pais, estado);
        }
        public DataTable CargarDGVProveedores()
        {
            return prov.Mostrar_Proveedor();
        }

    }

}

