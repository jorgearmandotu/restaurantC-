using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Pedido
    {
        private int id;
        private string name;
        private int cantidad;
        private float precio;
        private int idProduct;

        public Pedido(int id, string name, int cantidad, float precio)
        {
            this.id = id;
            this.name = name;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Cantidad { get; set; }
        public float Precio
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
