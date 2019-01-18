using Microsoft.Reporting.WinForms;
using restauran.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran.views
{
    public partial class FacturacionView : Form
    {
        public FacturacionView(Factura factura, List<Pedido> pedido)
        {
            InitializeComponent();
            CargarReporte(factura, pedido);
        }

        private void CargarReporte( Factura factura, List<Pedido> pedido)
        {
            
            List<Factura> facturas = new List<Factura>();
            facturas.Add(factura);
            List<Pedido> pedidos = new List<Pedido>();
            pedidos = pedido;
            //Conexionsql AcederDatos = new Conexionsql();
            /*foreach (DataRow Lista in AcederDatos.Datos().Rows)
            {
                Agregar.Add(new Persona
                {
                    Nombre = Lista[0].ToString(),
                    ApellidoPat = Lista[1].ToString(),
                    ApellidMat = Lista[2].ToString(),
                    TipoDocument = Lista[3].ToString(),
                    Correo = Lista[4].ToString(),
                    Vigencia = Convert.ToBoolean(Lista[5])
                });
            }*/
            ///Mostrar datos en el reporte
            this.reportViewerFactura.LocalReport.ReportEmbeddedResource = "restauran.reportes.ReporteFactura.rdlc";
            ReportDataSource rds1 = new ReportDataSource("DataFactura", facturas);
            ReportDataSource rds2 = new ReportDataSource("DataPedido", pedido);
            this.reportViewerFactura.LocalReport.DataSources.Clear();
            this.reportViewerFactura.LocalReport.DataSources.Add(rds1);
            this.reportViewerFactura.LocalReport.DataSources.Add(rds2);
            this.reportViewerFactura.RefreshReport();
            
        }

    }
}