using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class SystemSupportMail : MasterMailServer
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
