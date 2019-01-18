using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private List<Pedido> pedido;

        public Factura(DateTime fecha, string nombreCliente, string identificacion, 
            string direccionCliente, string atendidoPor, string formadePago)
        {
            this.NFactura = ObtenerNfactura();
            this.Fecha = fecha;
            this.NombreCliente = nombreCliente;
            this.Identificacion = identificacion;
            this.DireccionCliente = direccionCliente;
            this.AtendidoPor = atendidoPor;
            this.FormadePago = formadePago;
        }

        public int NFactura { get => nFactura; set => nFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
        public string AtendidoPor { get => atendidoPor; set => atendidoPor = value; }
        public string FormadePago { get => formadePago; set => formadePago = value; }
        internal List<Pedido> Pedido { get => pedido; set => pedido = value; }

        private int ObtenerNfactura()
        {
            int nFactura = 0;
            return nFactura;
        }
    }
}
