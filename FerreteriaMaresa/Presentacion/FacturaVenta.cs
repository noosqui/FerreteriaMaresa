using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FacturaVenta : Form
    {
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public FacturaVenta()
        {
            InitializeComponent();


        }

        private void FacturaVenta_Load(object sender, EventArgs e)
        {


        }

        private void encabezadoventa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
