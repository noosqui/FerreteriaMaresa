using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmUsuarioContra : Form
    {

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);


        public frmUsuarioContra()
        {
            InitializeComponent();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidentidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
