using restauran.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran.views
{
	public partial class Productos : Form
	{
		List<string> ingredientes = new List<string>();
		public Productos()
		{
			InitializeComponent();
			cargarInsumos();
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

		private void Productos_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'restaurantDataSet.insumos' Puede moverla o quitarla según sea necesario.
			
		}

		private void cargarInsumos()
		{
			using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
			{
				con.Open();
				OleDbCommand cmd = new OleDbCommand("Select * From insumos", con);
				OleDbDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					ingredientes.Add(Convert.ToString(dr["insumo"]));
				}
				con.Close();
			}
			foreach (string insumo in ingredientes)
			{
				listInsumos.Items.Add(insumo);
			}
		}
	}
}
