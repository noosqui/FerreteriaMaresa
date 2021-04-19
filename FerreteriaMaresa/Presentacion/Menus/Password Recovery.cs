using Dominio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Presentacion.Reporte;

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
            try
            {
                DOM_Validacion val = new DOM_Validacion();
                DOM_Empleados emp = new DOM_Empleados();
                var empleados = emp.CargarDGVEmpleados();

               
                if (txtcorreo.Text =="" || !val.email(txtcorreo.Text) )
                    throw new Exception("El Ingrese un correo electronico valido");
                if (empleados.Select("Correo = '" + txtcorreo.Text + "'").Length  < 1)
                {
                    throw new Exception("El correo no existe en la base de datos");
                }
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999).ToString());
                MailMessage message = new MailMessage();
                to = (txtcorreo.Text).ToString();
                from = "FerreteriaMaresa@gmail.com";
                pass = "FerreMaresa";
                messageBody = @"<table align='center'  cellpadding='0' cellspacing='0' width='600' >
    <tr> <!--Primera fila -->
        <td bgcolor='#2F235C' align='center' style='padding: 0px 0 0px 0; font-family: Arial, sans-serif;'>
             <img src='https://i.imgur.com/Mchtqgp.jpg' alt='Ferreteria Maresa S.A' width='300' height='230' style='display: block;' />
             <br>
             <p style='color:White;text-align: center'>
               Ferreteria Maresa S.A
             </p>
        </td>
    </tr>
    <tr>  <!--Segunda fila -->
        <td bgcolor='#4B3E7A' style='padding: 30px 30px 30px 30px; font-family: Arial, sans-serif; font-size: 14px;'>
          <table>  <!--Tabla principal de 2da fila -->
            <tr>     <!--Primera fila -->
              <td>
                <p style='margin: 0;'>Buenas tardes su codigo de verificacion es el siguiente:" + randomCode + @"</p>
                <br>
                <p>Pasos a seguir: </p>
                <br>
                </td>
              </tr>
              <tr>  <!--Segunda fila -->
                <td>
                  <table border='1' cellpadding='0' cellspacing='0' width='100%' style='border-collapse: collapse;'> <!--tabla dentro de la tabla 2 -->
                        <tr>
                          <td style='padding: 10px 10px; font-family: Arial, sans-serif; font-size: 11px;'>
                            <p style='margin: 0;'> Paso 1: Copie el codigo presentado anteriormente
                          </td>
                        </tr>
                        <tr>
                          <td style='padding: 10px 10px; font-family: Arial, sans-serif; font-size: 11px;'>
                            <p>
                              Paso 2: Dirigase al sistema de la empresa e ingrese el codigo.
                            </p>
                          </td>
                        </tr>
                        <tr>
                          <td style='padding: 10px 10px; font-family: Arial, sans-serif; font-size: 11px;'>
                            <p>
                               Paso 3: Una vez verificado cambie su contraseña y posteriormente ingrese sesion nuevamente
                            </p>
                          </td>
                        </tr>
                  </table>
                </td>
              </tr>


                </table>

        </td>
    </tr>
    <tr>  <!--Tercera fila -->
        <td bgcolor='#22174A' style='padding: 30px 30px;'>
            <table border='1' cellpadding='0' cellspacing='0' width='100%' style='border-collapse: collapse;'> <!--Tabla pie de pagina -->
                <tr>
                  <td>
                    <p>
                      Ferreteria Maresa S.A
                    </p>
                  </td>
                  <td align='Right'>
                    <table border='0' >
                      <tr>
                        <td>
                            Valle de Amarateca, Calle principal Tamara, Tegucigalpa, Honduras.
                        </td>
                      </tr>
                      <tr>
                        <td>
                          Telefono: +504 9971-8450
                        </td>
                      </tr>

                    </table>
                  </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password reseting code";
                message.IsBodyHtml = true;
                message.BodyEncoding = System.Text.Encoding.UTF8;
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar correo: " + ex);
            }
     
        }

        private void Password_Recovery_Load(object sender, EventArgs e)
        {

        }

        private void btCnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtcodverificacion.Text).ToString())
            {
                MessageBox.Show("Codigo de verificación correcto");
                RecoverPassword rec = new RecoverPassword(txtcorreo.Text);
                rec.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Codigo de verificación incorrecto");
            }

        }
    }
}
