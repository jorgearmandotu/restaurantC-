using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Ingresos
    {
        private int insumo;//id insumo
        private decimal vlrUnitario;
        private string recibo;
        private int cantidad;
        private int proveedor;//id proveedor
        private string observacion;
        private DateTime fecha;

        public Ingresos(int insumo, decimal vlrUnitario, string recibo, int cantidad, 
            int proveedor, string observacion, DateTime fecha)
        {
            this.Insumo = insumo;
            this.VlrUnitario = vlrUnitario;
            this.Recibo = recibo;
            this.Cantidad = cantidad;
            this.Proveedor = proveedor;
            this.Observacion = observacion;
            this.Fecha = fecha;
        }

        public int Insumo { get => insumo; set => insumo = value; }
        public decimal VlrUnitario { get => vlrUnitario; set => vlrUnitario = value; }
        public string Recibo { get => recibo; set => recibo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Proveedor { get => proveedor; set => proveedor = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
