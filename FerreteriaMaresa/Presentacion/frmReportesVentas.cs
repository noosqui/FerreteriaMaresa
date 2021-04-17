using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class frmReportesVentas : Form
    {
        public frmReportesVentas()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void obtenerVentas(DateTime DeFecha, DateTime ParaFecha)
        {
            ReporteVentas modelo = new ReporteVentas();
            modelo.crearReportedVentas(DeFecha, ParaFecha);

            /* ReporteVentasBindingSource.DataSource = modelo;
               ListaVentasBindingSource.DataSource = modelo;
               VentasNetasPeriodoBindingSource.DataSource = modelo;

            this.reportViewer1.RefreshReport();*/

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var deFecha = DateTime.Today;
            var paraFecha = DateTime.Now;

            obtenerVentas(deFecha,paraFecha);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var deFecha = DateTime.Today.AddDays(-7);
            var paraFecha = DateTime.Now;

            obtenerVentas(deFecha, paraFecha);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var deFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var paraFecha = DateTime.Now;

            obtenerVentas(deFecha, paraFecha);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var deFecha = DateTime.Today.AddDays(-30);
            var paraFecha = DateTime.Now;

            obtenerVentas(deFecha, paraFecha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var deFecha = new DateTime(DateTime.Now.Year, 1, 1);
            var paraFecha = DateTime.Now;

            obtenerVentas(deFecha, paraFecha);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deFecha = dtpdeFecha.Value;
            var paraFecha = dtpparaFecha.Value;

            obtenerVentas(deFecha, new DateTime(paraFecha.Year,paraFecha.Month,paraFecha.Day,23,59,59));
        }
    }
}
