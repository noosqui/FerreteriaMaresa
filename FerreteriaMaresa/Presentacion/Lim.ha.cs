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
                
                if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }

                if (txt is RadioButton)
                {
                    ((RadioButton)txt).Checked = false;
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

                if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = true;
                }

                if (txt is RadioButton)
                {
                    ((RadioButton)txt).Enabled = true;
                }

                if(txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Enabled = true;
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

                if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = false;
                }

                if (txt is RadioButton)
                {
                    ((RadioButton)txt).Enabled = false;
                }

                if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Enabled = false;
                }

            }

        }

    }
}
