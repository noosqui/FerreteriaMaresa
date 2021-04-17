using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace Datos
{
    public class UserDao: CD_Conexion
    {
        public string recoverPassword(string userRequesting)
        {
            using (var connection = Conectarbd)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec.Recoverpass @mail";
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userMail = reader.GetString(2);
                        string accountPassword = reader.GetString(0);
                        string name = reader.GetString(1);
                        var mailService = new SystemSupportMail();
                        mailService.sendMail(
                          subject: "Ferreteria Maresa: Recuperación de contraseña",
                          body: "Hola, " + name + "\n La contraseña de tu correo " + userMail +" es "+ accountPassword + ".",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + name + "\nLa contraseña de tu correo " + userMail + " es " + accountPassword + ".";
                    }
                    else
                        return "La dirección no existe en el sistema.";
                }
            }
        }
    }
}
