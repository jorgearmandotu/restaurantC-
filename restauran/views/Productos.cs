using restauran.controller;
using restauran.models;
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
		List<InsumosModel> ingredientes = new List<InsumosModel>();
		List<Recetas> receta = new List<Recetas>();
		List<Platos> platos = new List<Platos>();
		public Productos()
		{
			InitializeComponent();
			cargarInsumos();
			cargarcmbPlatos();
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

		private void cargarInsumos()
		{
			using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
			{
				con.Open();
				OleDbCommand cmd = new OleDbCommand("Select * From insumos", con);
				OleDbDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					//ingredientes.Add(Convert.ToString(dr["insumo"]));
					int id = Convert.ToInt32(dr["id"]);
					string name = Convert.ToString(dr["insumo"]);
					int stock = Convert.ToInt32(dr["stock"]);
					string unidad = Convert.ToString(dr["unidad"]);
					int stockMinimo = Convert.ToInt32(dr["stockMinimo"]);
					ingredientes.Add(new InsumosModel(id, name, unidad, stock, stockMinimo));

				}
				con.Close();
			}
			foreach (InsumosModel insumo in ingredientes)
			{
				listInsumos.Items.Add(insumo.Insumo);
			}
		}

		private void cargarcmbPlatos()
		{
			using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
			{
				con.Open();
				OleDbCommand cmd = new OleDbCommand("Select * From platos", con);
				OleDbDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					//ingredientes.Add(Convert.ToString(dr["insumo"]));
					int id = Convert.ToInt32(dr["id"]);
					string plato = Convert.ToString(dr["plato"]);
					decimal precio = Convert.ToDecimal(dr["precio"]);
					string image = Convert.ToString(dr["image"]);
					int categoria = Convert.ToInt32(dr["categoria"]);
					platos.Add(new Platos(id, plato, precio, image, categoria));

				}
				con.Close();
			}
			foreach (Platos plato in platos)
			{
				cmbNamePlato.Items.Add(plato.Nombre.ToString());
			}
		}

		private void btnAddIngrediente_Click(object sender, EventArgs e)
		{
			if(listInsumos.SelectedItem != null && txtCantidadIngrediente.TextLength > 0)
			{
				//busco ingrediente para obtener su id
				InsumosModel ingredienteEncontrado = ingredientes.Find(x => x.Insumo == listInsumos.SelectedItem.ToString());
				if(ingredienteEncontrado != null)
				{
					int idPlato = -1;
					//verifico q sea un nuevo plato o  modificacion de un existente
					if (cmbNamePlato.SelectedIndex >= 0)
					{
						//busco plato seleccionado y consigo su id
						Platos platoEncontrado = platos.Find(x => x.Nombre == cmbNamePlato.SelectedItem.ToString());
						if(platoEncontrado != null)
						{
							idPlato = platoEncontrado.Id;
						}
						else
						{
							MessageBox.Show("Ocurrio un error verifique seleecion de plato");
						}
					}
					//verifico si hay items en listado receta
					if (receta.Count > 0)
					{
						//busco si ya existe el ingrediente
						Recetas ingrediente = receta.Find(x => x.Insumo == ingredienteEncontrado.Id);
						if(ingrediente == null)
						{
							//agrego el nuevo ingrediente a la receta
							receta.Add(new Recetas(idPlato, ingredienteEncontrado.Id, Convert.ToInt32(txtCantidadIngrediente.Text)));
							cargarReceta();
						}
						else
						{
							//modifico el ingrediente existente a la receta
							ingrediente.IdPlato = idPlato;
							ingrediente.Insumo = ingredienteEncontrado.Id;
							ingrediente.Cantidad = Convert.ToInt32(txtCantidadIngrediente.Text);
							cargarReceta();
						}
					}
					else
					{
						//agrego ingrediente a receta
						receta.Add(new Recetas(idPlato, ingredienteEncontrado.Id, Convert.ToInt32(txtCantidadIngrediente.Text)));
						cargarReceta();
					}
					txtCantidadIngrediente.Text = "";
				}
			}

		}

		private void cargarReceta()
		{
			listViewReceta.Items.Clear();
			if (cmbNamePlato.SelectedIndex < 0)
			{
				foreach (Recetas insumo in receta)
				{
					if(insumo.IdPlato == -1)
					{
						//busco el insumo para obtener su nombre
						InsumosModel ingrediente = ingredientes.Find(x => x.Id == insumo.Insumo);
						if (ingrediente != null)
						{
							string[] row = { ingrediente.Insumo, insumo.Cantidad.ToString() };
							var listViewItem = new ListViewItem(row);
							listViewReceta.Items.Add(listViewItem);
						}
					}
				}
			}
			else
			{
				Platos platoEncontrado = platos.Find(x => x.Nombre == cmbNamePlato.SelectedItem.ToString());
				if (platoEncontrado != null)
				{
					int idPlato = platoEncontrado.Id;
					foreach (Recetas insumo in receta)
					{
						if (insumo.IdPlato == idPlato)
						{
							//busco el insumo para obtener su nombre
							InsumosModel ingrediente = ingredientes.Find(x => x.Id == insumo.Insumo);
							if (ingrediente != null)
							{
								string[] row = { ingrediente.Insumo, insumo.Cantidad.ToString() };
								var listViewItem = new ListViewItem(row);
								listViewReceta.Items.Add(listViewItem);
							}
						}
					}
				}
			}
			
		}
	}
}
