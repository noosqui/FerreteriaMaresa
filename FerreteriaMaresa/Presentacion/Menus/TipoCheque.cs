using Dominio;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class TipoCheque : Form
    {
        private DOM_Bancos Bancos = new DOM_Bancos();
        private DOM_Validacion validacion = new DOM_Validacion();
        private DOM_Facturacion facturacion = new DOM_Facturacion();

        public string monto = "0";

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        public TipoCheque()
        {
            InitializeComponent();

        }

        private void TipoCheque_Load(object sender, EventArgs e)
        {
            txtMonto.Text = "" + monto;
            dtfechan.MinDate = DateTime.Now;
            dtfechan.MaxDate = DateTime.Now.AddDays(7);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (DataRow row in Bancos.mostrarBancos().Rows)
            {
                coleccion.Add(row["Nombre"].ToString());
            }
            cmbBancos.DisplayMember = "Nombre";
            cmbBancos.ValueMember = "Nombre";
            cmbBancos.DataSource = Bancos.mostrarBancos();
            cmbBancos.AutoCompleteCustomSource = coleccion;
            cmbBancos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBancos.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }



        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumerosDec(e);
        }

        private void rtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumerosEnt(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumerosEnt(e);
        }



        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumerosEnt(e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctr in this.panel1.Controls)
                {
                    if (ctr is TextBox && ctr.Text.Trim().Length < 1)
                    {
                        throw new Exception("No debe dejar campos vacios");
                    }
                }

                facturacion.Insertar_Cheque(txtNumeroCuenta.Text, dtfechan.Value, txtRuta.Text, txtNumeroCheque.Text, ((DataTable)cmbBancos.DataSource).Rows[cmbBancos.SelectedIndex][0].ToString(), txtMonto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La operacion no pudo ser realizada por " + ex);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
