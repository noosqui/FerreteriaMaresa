using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;
namespace Presentacion
{
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inventario());
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void btnReportesE_Click(object sender, EventArgs e)
        {
            if (SubMenuReportes.Visible == true)
                SubMenuReportes.Visible = false;
            else
                SubMenuReportes.Visible = true;
        }

        private void btnReporteIE_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void btnReporteVE_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void AbrirForm(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form f = formulario as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(f);
            this.panelContenedor.Tag = f;
            f.Show();
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
