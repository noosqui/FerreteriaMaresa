using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Presentacion
{
    public partial class Graficos : Form
    {
        SqlConnection Conectarbd = new SqlConnection("server=DESKTOP-LHRSL72\\SQLEXPRESS;DataBase=Ferreteria_Maresa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            GraficosFerreteriaMaresa();
            GraficosCategorias();
            ProductosPreferidos();
        }

        ArrayList  Categoria = new ArrayList();
        ArrayList CantidadProductos = new ArrayList();
        ArrayList Producto = new ArrayList();
        ArrayList CantidadPeriodo = new ArrayList();

        private void GraficosCategorias()
        {
            cmd = new SqlCommand("CantidadProductosCategoria", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            Conectarbd.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria.Add(dr.GetString(1));
                CantidadProductos.Add(dr.GetInt32(2));
            }
            chartProductos_Categoria.Series[0].Points.DataBindXY(Categoria, CantidadProductos);
            dr.Close();
            Conectarbd.Close();
        }

        private void ProductosPreferidos()
        {
            cmd = new SqlCommand("TopProductosPreferidos", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            Conectarbd.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto.Add(dr.GetString(1));
                CantidadPeriodo.Add(dr.GetInt32(2));
            }
            chartProductos_Preferidos.Series[0].Points.DataBindXY(Producto, CantidadPeriodo);
            dr.Close();
            Conectarbd.Close();
        }
        private void GraficosFerreteriaMaresa()
        {           
            cmd = new SqlCommand("GraficosFerreteriaMaresa", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@VentasTotal", 0);total.Direction = ParameterDirection.Output;
            SqlParameter totalC = new SqlParameter("@ComprasTotal", 0); totalC.Direction = ParameterDirection.Output;
            SqlParameter producto = new SqlParameter("@Productos", 0); producto.Direction = ParameterDirection.Output;
            SqlParameter categoria = new SqlParameter("@Categoria", 0); categoria.Direction = ParameterDirection.Output;
            SqlParameter marca = new SqlParameter("@Marcas", 0); marca.Direction = ParameterDirection.Output;
            SqlParameter empleado = new SqlParameter("@Empleados", 0); empleado.Direction = ParameterDirection.Output;
            SqlParameter proveedor = new SqlParameter("@Proveedores", 0); proveedor.Direction = ParameterDirection.Output;
            SqlParameter cliente = new SqlParameter("@Clientes", 0); cliente.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(totalC);
            cmd.Parameters.Add(producto);
            cmd.Parameters.Add(categoria);
            cmd.Parameters.Add(marca);
            cmd.Parameters.Add(empleado);
            cmd.Parameters.Add(proveedor);
            cmd.Parameters.Add(cliente);
            Conectarbd.Open();
            cmd.ExecuteNonQuery();

            lbltotalVentas.Text = cmd.Parameters["@VentasTotal"].Value.ToString();
            lblCompras.Text = cmd.Parameters["@ComprasTotal"].Value.ToString();
            lblproductos.Text = cmd.Parameters["@Productos"].Value.ToString();
            lblcategorias.Text = cmd.Parameters["@Categoria"].Value.ToString();
            lblmarcas.Text = cmd.Parameters["@Marcas"].Value.ToString();
            lblempleados.Text = cmd.Parameters["@Empleados"].Value.ToString();
            lblproveedores.Text = cmd.Parameters["@Proveedores"].Value.ToString();
            lblclientes.Text = cmd.Parameters["@Clientes"].Value.ToString();
            Conectarbd.Close();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void chartProductos_Categoria_Click(object sender, EventArgs e)
        {
            GraficosCategorias();
        }

        private void chartProductos_Preferidos_Click(object sender, EventArgs e)
        {
            ProductosPreferidos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartProductos_Categoria_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
