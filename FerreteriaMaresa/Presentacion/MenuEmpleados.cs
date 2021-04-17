using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class MenuEmpleados : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentForm;
        public MenuEmpleados()
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
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(2, 53, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 68, 255);
            public static Color color6 = Color.FromArgb(24, 141, 253);
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
        private void MenuEmpleados_Load(object sender, EventArgs e)
        {

        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirForm(new Inventario());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirForm(new VentaProducto());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            Reset();
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

        }


        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
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
            TituloFormularioHijo.Text = Childform.Text;
        }

        private void ReporteInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            
        }

        private void ReporteVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = false;
            
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
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = true;
            TituloFormularioHijo.Text = "Reportes";
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirForm(new Inventario());
            panelSubMenu.Visible = false;
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirForm(new VentaProducto());
            panelSubMenu.Visible = false;
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            currentForm.Close();
            Reset();
        }

        private void btnVentas_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirForm(new VentaProducto());
            panelSubMenu.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirForm(new Inventario());
            panelSubMenu.Visible = false;
        }

        private void btnReportes_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            panelSubMenu.Visible = true;
            TituloFormularioHijo.Text = "Reportes";
        }

        private void ReporteVentas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirForm(new frmReportesVentas());
            panelSubMenu.Visible = false;

        }

        private void ReporteInventario_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirForm(new ReporteInvetario());
            panelSubMenu.Visible = false;
        }

        private void tiempo2_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
