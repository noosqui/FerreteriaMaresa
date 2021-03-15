using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void AbrirForm(object formulario)
        {
            if (activeform != null)
                activeform.Close();


            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form f = formulario as Form;
            activeform = f;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(f);
            this.panelContenedor.Tag = f;
            f.Show();
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroEmpleado());


        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirForm(new CompraProductos());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inventario());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirForm(new VentaProducto());
        }

        private void btnReporteInventario_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            AbrirForm(new ReporteInventario());
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            AbrirForm(new ReporteVenta());
        }

        private void btnReporteEmpleados_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void btnReporteProveedor_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            else
                panelSubMenu.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
