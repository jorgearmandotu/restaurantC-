using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran.views
{
	public partial class Productos : Form
	{
		public Productos()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnNewCategoria_Click(object sender, EventArgs e)
		{
			Categoria cat = new Categoria();
			cat.ShowDialog();
		}

		private void btnNewIngrediente_Click(object sender, EventArgs e)
		{
			Insumos insumo = new Insumos();
			insumo.ShowDialog();
		}
	}
}
