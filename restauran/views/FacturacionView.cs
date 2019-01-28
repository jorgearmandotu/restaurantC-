using Microsoft.Reporting.WinForms;
using restauran.controller;
using restauran.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran.views
{
    public partial class FacturacionView : Form
    {
        public FacturacionView(Factura factura, List<Pedido> pedido, Clientes cliente, string idFormaPago)
        {
            InitializeComponent();
            IngresarFactura(factura, cliente, pedido, idFormaPago);
        }

        private void IngresarFactura(Factura factura, Clientes cliente, List<Pedido> pedido, string idFormaPago)
        {
            //string sql = String.Format($"INSERT INTO facturacion (nFactura, cliente, pago, fecha, mesero, vlrFacturado) " +
            //      $"VAlUES (?,?,?,?,?,?)");
            string sql = String.Format($"INSERT INTO facturacion (nFactura, cliente, pago, fecha, mesero, vlrFacturado) " +
                    $"VAlUES ({factura.NFactura}, {cliente.Id}, {factura.FormadePago}, {factura.Fecha}, {factura.AtendidoPor}, {factura.VlrPagar})");

            //OleDbType.Date = factura.Fecha;
            string[] arr = { factura.NFactura.ToString(), cliente.Id.ToString(), factura.FormadePago,
                "#"+factura.Fecha.ToString()+"#", factura.AtendidoPor, factura.VlrPagar };
            //if (DataAplication.InsertData(sql, arr))
            MessageBox.Show(sql);
            if (DataAplication.InsertData(sql))
            {
                Thread th = new Thread(() => CargarSalidas(pedido, factura));
                th.Start();
                CargarReporte(factura, pedido);
            }
            else
            {
                MessageBox.Show("No se pudo generar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSalidas(List<Pedido> pedido, Factura factura)
        {
            DataSet ds = DataAplication.Execute("SELECT * FROM platos");
            DataTable dt = ds.Tables[0];
            foreach(Pedido p in pedido){
                int idPlato = 0;
                string sqlSalidas = $"INSERT INTO salidas (plato, cantidad, fecha, factura) VALUES( ?,?,?,? )";
                MessageBox.Show(sqlSalidas);
                foreach (DataRow plato in dt.Rows)
                {
                    if(plato["plato"].ToString() == p.Producto)
                    {
                        idPlato = Convert.ToInt32(plato["Id"]);
                        break;
                    }
                }
                string[] datos = {idPlato.ToString(), p.Cantidad.ToString(), factura.Fecha.ToString(), factura.NFactura.ToString()};
                DataAplication.InsertData(sqlSalidas, datos);
            }
            
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