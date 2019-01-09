using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
	class InsumosModel
	{
		private int id;
		private string insumo;
		private string unidad;
		private int stock;
		private int stockMinimo;

		public InsumosModel(int id, string insumo, string unidad, int stock, int stockMinimo)
		{
			this.Id = id;
			this.Insumo = insumo;
			this.Unidad = unidad;
			this.Stock = stock;
			this.StockMinimo = stockMinimo;
		}

		public int Id { get => id; set => id = value; }
		public string Insumo { get => insumo; set => insumo = value; }
		public string Unidad { get => unidad; set => unidad = value; }
		public int Stock {
			get => stock;
			set
			{
				if(value >= 0)
				stock = value;
			}
		}
		public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
	}
}
