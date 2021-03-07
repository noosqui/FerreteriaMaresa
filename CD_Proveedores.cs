﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Proveedores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comandoo = new SqlCommand();


        public DataTable Mostrar_Proveedor()
        {
           
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "Mostrar_Proveedor";
            comandoo.CommandType = CommandType.StoredProcedure;
            lee = comandoo.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public void insertar_Proveedor(string idProveedor, string nombreProveedor, string apellidoProveedor, long telProveedor, string correo, int direccion, string estado)
        {
            
            comando.Connection = conexion.abrir();
            comando.CommandText = "pro_insertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", idProveedor);
            comando.Parameters.AddWithValue("@nom_proveedor", nombreProveedor);
            comando.Parameters.AddWithValue("@apellido_proveedor", apellidoProveedor);
            comando.Parameters.AddWithValue("@telefono", telProveedor);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@Estado", estado);

            comando.ExecuteNonQuery();
            conexion.cerrar();
        }

        public void Editar_Proveedores(string idProveedor, string nombreProveedor, string apellidoProveedor, long telProveedor, string correo, int direccion, string estado)
        {
            
            comando.Connection = conexion.abrir();
            comando.CommandText = "modificar_Proveedrores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", idProveedor);
            comando.Parameters.AddWithValue("@nom_proveedor", nombreProveedor);
            comando.Parameters.AddWithValue("@apellido_proveedor", apellidoProveedor);
            comando.Parameters.AddWithValue("@telefono", telProveedor);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@Estado", estado);

            comando.ExecuteNonQuery();
            conexion.cerrar();
        }

        public void eliminarempleado(string idproveedor)
        {
            
            comando.Connection = conexion.abrir();
            comando.CommandText = "eliminar_proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_proveedor", idproveedor);
            comando.ExecuteNonQuery();
            conexion.cerrar();
        }

    }
}
