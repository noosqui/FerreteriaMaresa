using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class Lim_ha
    {
        public void Limpiar(Control control)
        {

            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }

        }


        public void Encender(Control control)
        {

            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = true;
                }
            }

        }

        public void Apagar(Control control)
        {

            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = false;
                }
            }

        }

    }
}
