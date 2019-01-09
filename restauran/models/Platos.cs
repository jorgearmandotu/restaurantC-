using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Platos
    {
        private int id;
        private string nombre;
        private decimal precio;
		private string image;
		private int categoria;

        public Platos(int id, string nombre, decimal precio, string image, int categoria)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.Id = id;
			this.Image = image;
			this.Categoria = categoria;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
		public string Image { get => image; set => image = value; }
		public int Categoria { get => categoria; set => categoria = value; }
		public int Id { get => id; set => id = value; }
		//public int Id { get => id; set => id = value; }

	}
}
