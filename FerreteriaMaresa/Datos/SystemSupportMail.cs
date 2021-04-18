namespace Datos
{
    internal class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "FerreteriaMaresa@gmail.com";
            password = "FerreMaresa";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
