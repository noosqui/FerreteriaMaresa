using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Dominio;
namespace Presentacion
{
    public partial class RecoverPassword : Form
    {
        DOM_Empleados empl = new DOM_Empleados();
        public string to;
        public RecoverPassword(string correo)
        {
            InitializeComponent();
            this.to = correo;

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == txtconfirmpass.Text)
            {
                empl.Restablecer_Contrasenia(to, txtpassword.Text);
                MessageBox.Show("Contraseñana guardada");
                this.Dispose();
            }

        }

        private void RecoverPassword_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RecoverPassword_Load_1(object sender, EventArgs e)
        {

        }
    }
}
