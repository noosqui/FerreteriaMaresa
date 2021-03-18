using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ReporteCompras : Form
    {
        public ReporteCompras()
        {
            InitializeComponent();
        }

        private void ReporteCompras_Load(object sender, EventArgs e)
        {

            this.rpvCompras.RefreshReport();
        //    this.reportViewer1.RefreshReport();
        }
    }
}
