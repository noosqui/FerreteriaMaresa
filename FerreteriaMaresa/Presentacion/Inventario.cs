using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            string searchValue = txtcodigo.Text;

            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                dgvInventario.ClearSelection();
                foreach (DataGridViewRow row in dgvInventario.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            break;
                        }
                        else
                        {
                            string searchValue1 = txtnombre.Text;
                            if (row.Cells[1].Value.ToString().Equals(searchValue1))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("No se encontro el Codigo "+exc);
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se encontro el Codigo " + exc);
            }
        }
    }
}
