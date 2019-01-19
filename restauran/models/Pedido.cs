using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    public class Pedido
    {
        private int id;//mesa
        private string producto;//name producto
        private int cantidad;//cantidad
        private decimal vlrUnit;//precio
        //private int idProduct;

        public Pedido(int id, string name, int cantidad, decimal precio)
        {
            this.id = id;
            this.producto = name;
            this.cantidad = cantidad;
            this.vlrUnit = precio;
        }

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Vlr_Unit
        {
            get
            {
                return vlrUnit;
            }
            set
            {
                if(value > 0)
                {
                    vlrUnit = value;
                }
            }
        }

    }
}
