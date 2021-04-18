using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuAdmin : Form
    {
        //carpetas
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentForm;
        private string idEmpleado;
        private int puesto;
        public MenuAdmin(string Empleado, int puesto)
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.idEmpleado = Empleado;
            this.puesto = puesto;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            if (puesto != 2)
            {
                this.btnCompras.Visible = false;
                this.btnProveedor.Visible = false;
                this.btnGraf.Visible = false;
               // this.btnReport.Visible = false;
            }

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(53, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 68, 255);
            public static Color color6 = Color.FromArgb(24, 141, 253);
            public static Color color7 = Color.FromArgb(249, 118, 12);
            public static Color color8 = Color.FromArgb(95, 77, 45);
        }

        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 16, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Border izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildfo.IconChar = currentBtn.IconChar;
                iconCurrentChildfo.IconColor = color;
            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirForm(new RegistroEmpleado());
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Empleados";


        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirForm(new CompraProductos(this.idEmpleado));
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Compras";
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirForm(new Inventario(this.puesto));
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Inventario";
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirForm(new VentaProducto(this.idEmpleado));
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Ventas";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            Reset();
            TituloFormularioHijo.Text = "Home";
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //Icon Current Child Form
            iconCurrentChildfo.IconChar = IconChar.Home;
            iconCurrentChildfo.IconColor = Color.MediumPurple;
            TituloFormularioHijo.Text = "Home";
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }


        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirForm(Form Childform)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Childform);
            panelDesktop.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();

        }

        private void btCnCerrar_Click(object sender, EventArgs e)
        {

            LoginFerreteriaMaresa login = new LoginFerreteriaMaresa();
            login.Show();
            this.Hide();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirForm(new Inventario(this.puesto));
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Inventario";
        }


        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Reporte de Empleados";
        }

        private void ReporteInventario_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Reporte de Inventario";
        }

        private void ReporteVentas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Reporte de Ventas";
        }

        private void ReporteProveedor_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Reporte de Proveedores";
        }

        private void panelSubMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            TituloFormularioHijo.Text = "Reporte de Empleados";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            panelSubMenu.Visible = false;
            AbrirForm(new RegistroClientes());
            TituloFormularioHijo.Text = "Clientes";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            AbrirForm(new Graficos());
            TituloFormularioHijo.Text = "Dashboard";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            panelSubMenu.Visible = false;
            AbrirForm(new RegistroProveedores());
            TituloFormularioHijo.Text = "Proveedores";
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        private void TituloFormularioHijo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = true;
            TituloFormularioHijo.Text = "Reportes";
        }

        private void ReporteVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirForm(new frmReportesVentas());
            panelSubMenu.Visible = false;
        }

        private void ReporteInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirForm(new frmReporteInventario());
            panelSubMenu.Visible = false;
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirForm(new frmReporteCompras());
            panelSubMenu.Visible = false;
        }
    }
}
