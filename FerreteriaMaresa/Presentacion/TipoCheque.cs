using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class TipoCheque : Form
    {

        DOM_Bancos Bancos = new DOM_Bancos();
        DOM_Validacion validacion = new DOM_Validacion();
        DOM_Facturacion facturacion = new DOM_Facturacion();
    
        public string monto = "0";
        public TipoCheque( )
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
            validacion.SoloNumeros(e);
        }

        private void rtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                facturacion.Insertar_Cheque(txtNumeroCuenta.Text, dtfechan.Value, txtRuta.Text, txtNumeroCheque.Text, ((DataTable)cmbBancos.DataSource).Rows[cmbBancos.SelectedIndex][0].ToString(), txtMonto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La operacion no pudo ser realizada por " + ex);
            }
        }
    }
}
