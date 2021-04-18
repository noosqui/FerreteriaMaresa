using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Dominio;
using Datos;


namespace Presentacion
{
    public partial class Password_Recovery : Form
    {
        string randomCode;
        public static string to;
        public Password_Recovery()
        {
            InitializeComponent();
        }
        Usermodel user = new Usermodel();
        
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

            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999).ToString());
            MailMessage message = new MailMessage();
            to = (txtcorreo.Text).ToString();
            from = "FerreteriaMaresa@gmail.com";
            pass = "FerreMaresa";
            messageBody = "Tu codigo de activación es " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {

                smtp.Send(message);
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtcodverificacion.Visible = true;
                btnsiguiente.Visible = true;
                btCnCerrar.Visible = true;
                label1.Visible = false;
                txtcorreo.Visible = false;
                btnAcceder.Visible = false;
                button1.Visible = false;
                btCnCerrar.Visible = true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*if (txtcorreo.Text == "")
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
            else {
                MessageBox.Show("El correo electronico ingresado no esta en el sistema.");
            }*/
        }

        private void Password_Recovery_Load(object sender, EventArgs e)
        {

        }

        private void btCnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtcodverificacion.Text).ToString())
            {
                MessageBox.Show("Codigo de verificación correcto");
                RecoverPassword rec = new RecoverPassword(txtcorreo.Text);
                rec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Codigo de verificación incorrecto");
            }

        }
    }
}
