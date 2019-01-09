using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
	class Recetas
	{
		private int idPlato;
		private int insumo;
		private int cantidad;

		public Recetas(int idPlato, int insumo, int cantidad)
		{
			this.IdPlato = idPlato;
			this.Insumo = insumo;
			this.Cantidad = cantidad;
		}

		public int IdPlato { get => idPlato; set => idPlato = value; }
		public int Insumo { get => insumo; set => insumo = value; }
		public int Cantidad {
			get => cantidad;
			set
			{
				if (value > 0)
				{
					cantidad = value;
				}
			}
		}
	}
}
