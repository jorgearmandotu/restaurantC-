using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Pedido
    {
        private int id;//mesa
        private string name;//name producto
        private int cantidad;//cantidad
        private decimal precio;//precio
        private int idProduct;

        public Pedido(int id, string name, int cantidad, decimal precio)
        {
            this.id = id;
            this.name = name;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if(value > 0)
                {
                    precio = value;
                }
            }
        }

    }
}
