using restauran.controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace restauran.models
{
    public class Factura
    {
        private int nFactura;
        private DateTime fecha;
        private string nombreCliente;
        private string identificacion;
        private string direccionCliente;
        private string atendidoPor;
        private string formadePago;
        private string impuestoConsumo;
        private string vlrPagar;

        //private List<Pedido> pedido;

        public Factura(DateTime fecha, string nombreCliente, string identificacion, 
            string direccionCliente, string atendidoPor, string formadePago, string impuesto, string vlrPagar)
        {
            this.NFactura = ObtenerNfactura();
            this.Fecha = fecha;
            this.NombreCliente = nombreCliente;
            this.Identificacion = identificacion;
            this.DireccionCliente = direccionCliente;
            this.AtendidoPor = atendidoPor;
            this.FormadePago = formadePago;
            this.impuestoConsumo = impuesto;
            this.vlrPagar = vlrPagar;
        }

        public int NFactura { get => nFactura; set => nFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
        public string AtendidoPor { get => atendidoPor; set => atendidoPor = value; }
        public string FormadePago { get => formadePago; set => formadePago = value; }
        public string ImpuestoConsumo { get => impuestoConsumo; set => impuestoConsumo = value; }
        public string VlrPagar { get => vlrPagar; set => vlrPagar = value; }
        //internal List<Pedido> Pedido { get => pedido; set => pedido = value; }

        private int ObtenerNfactura()
        {
            int nFactura = 0;
            string sql = "SELECT TOP 1 nFactura FROM facturacion ORDER BY nFactura DESC ";
            try
            {
                DataSet ds = DataAplication.Execute(sql);
                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    nFactura = Convert.ToInt32(rows["nFactura"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (nFactura < 100 || nFactura > 998)
            {
                nFactura = 100;
            }else
            {
                nFactura++;
            }
            return nFactura;
        }
    }
}
