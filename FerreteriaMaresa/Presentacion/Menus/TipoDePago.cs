using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class TipoDePago : Form
    {

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        public TipoDePago()
        {
            InitializeComponent();
        }

        private void reegresar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
