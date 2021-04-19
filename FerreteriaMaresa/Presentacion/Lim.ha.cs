using System.Windows.Forms;

namespace Presentacion
{
    internal class Lim_ha
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

                if (txt is DateTimePicker)
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

                if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Enabled = false;
                }
            }

        }

    }
}
