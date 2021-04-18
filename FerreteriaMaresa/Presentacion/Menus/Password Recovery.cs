using Dominio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Password_Recovery : Form
    {
        public Password_Recovery()
        {
            InitializeComponent();
        }

        private Usermodel user = new Usermodel();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "")
            {
                MessageBox.Show("Por favor ingrese un correo.");
            }
            else if (ComprobarFormatoEmail(txtcorreo.Text) == false)
            {
                MessageBox.Show("Por favor ingrese un correo valido del sistema.");
            }
            else if (ComprobarFormatoEmail(txtcorreo.Text) == true && user.recoverPassword(txtcorreo.Text) != "La dirección no existe en el sistema.")
            {
                label3.Visible = true;
                label4.Visible = true;
                btCnCerrar.Visible = true;
                label1.Visible = false;
                txtcorreo.Visible = false;
                btnAcceder.Visible = false;
                button1.Visible = false;
                btCnCerrar.Visible = true;
            }
            else
            {
                MessageBox.Show("El correo electronico ingresado no esta en el sistema.");
            }
        }

        private void Password_Recovery_Load(object sender, EventArgs e)
        {

        }

        private void btCnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
