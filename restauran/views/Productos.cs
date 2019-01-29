﻿using restauran.controller;
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
		List<InsumosModel> listIngredientes = new List<InsumosModel>();
		List<Recetas> listReceta = new List<Recetas>();
		List<Platos> listPlatos = new List<Platos>();
		public Productos()
		{
			InitializeComponent();
			CargarInsumos();
			CargarcmbPlatos();
            cargarCmbCategorias();
		}

        private void cargarCmbCategorias()
        {
            string sql = "SELECT categoria FROM categorias";
            DataSet ds = DataAplication.Execute(sql);
            if(ds.Tables.Count > 0)
            {
                cmbCategoria.Items.Add(ds.Tables[0].Rows[0]["categoria"]);
                cmbCategoria.Items.Add(ds.Tables[0].Rows[1]["categoria"]);
                cmbCategoria.Items.Add(ds.Tables[0].Rows[2]["categoria"]);
                cmbCategoria.Items.Add(ds.Tables[0].Rows[3]["categoria"]);
            }
        }

		private void BtnNewCategoria_Click(object sender, EventArgs e)
		{
			Categoria cat = new Categoria();
			cat.ShowDialog();
		}

		private void BtnNewIngrediente_Click(object sender, EventArgs e)
		{
			Insumos insumo = new Insumos();
			insumo.ShowDialog();
			CargarInsumos();
		}

		private void CargarInsumos()
		{
			listInsumos.Items.Clear();
			listIngredientes.Clear();
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
					listIngredientes.Add(new InsumosModel(id, name, unidad, stock, stockMinimo));

				}
				//con.Close();
			}
			foreach (InsumosModel insumo in listIngredientes)
			{
				listInsumos.Items.Add(insumo.Insumo);
			}
		}

		private void CargarcmbPlatos()
		{
			listPlatos.Clear();
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
					listPlatos.Add(new Platos(id, plato, precio, image, categoria));

				}
				//con.Close();
			}
			foreach (Platos plato in listPlatos)
			{
				cmbNamePlato.Items.Add(plato.Nombre.ToString());
			}
		}

		private void BtnAddIngrediente_Click(object sender, EventArgs e)
		{
			if(listInsumos.SelectedItem != null && txtCantidadIngrediente.TextLength > 0)
			{
				//busco ingrediente para obtener su id
				InsumosModel ingredienteEncontrado = listIngredientes.Find(x => x.Insumo == listInsumos.SelectedItem.ToString());
				if(ingredienteEncontrado != null)
				{
					//verifico q sea un nuevo plato o  modificacion de un existente
					int idPlato = ObtenerIdPlato(cmbNamePlato.SelectedIndex, cmbNamePlato.Text);
					//verifico si hay items en listado receta
					if (listReceta.Count > 0)
					{
						//busco si ya existe el ingrediente
						Recetas ingrediente = listReceta.Find(x => x.Insumo == ingredienteEncontrado.Id);
						if(ingrediente == null)
						{
							//agrego el nuevo ingrediente a la receta
							listReceta.Add(new Recetas(idPlato, ingredienteEncontrado.Id, Convert.ToInt32(txtCantidadIngrediente.Text)));
							CargarReceta();
						}
						else
						{
							//modifico el ingrediente existente a la receta
							ingrediente.IdPlato = idPlato;
							ingrediente.Insumo = ingredienteEncontrado.Id;
							ingrediente.Cantidad = Convert.ToInt32(txtCantidadIngrediente.Text);
							CargarReceta();
						}
					}
					else
					{
						//agrego ingrediente a receta
						listReceta.Add(new Recetas(idPlato, ingredienteEncontrado.Id, Convert.ToInt32(txtCantidadIngrediente.Text)));
						CargarReceta();
					}
					txtCantidadIngrediente.Text = "";
				}
			}

		}

		private void CargarReceta()
		{
			listViewReceta.Items.Clear();
			//receta.Clear();
			if (cmbNamePlato.SelectedIndex < 0)
			{
				foreach (Recetas insumo in listReceta)
				{
					if(insumo.IdPlato == -10)
					{
						//busco el insumo para obtener su nombre
						InsumosModel ingrediente = listIngredientes.Find(x => x.Id == insumo.Insumo);
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
				//busco plato
				Platos platoEncontrado = listPlatos.Find(x => x.Nombre == cmbNamePlato.SelectedItem.ToString());
				if (platoEncontrado != null)
				{
					int idPlato = platoEncontrado.Id;
					foreach (Recetas insumo in listReceta)
					{
						if (insumo.IdPlato == idPlato)
						{
							//busco el insumo para obtener su nombre
							InsumosModel ingrediente = listIngredientes.Find(x => x.Id == insumo.Insumo);
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

		private void CmbNamePlato_SelectedIndexChanged(object sender, EventArgs e)
		{
			listViewReceta.Items.Clear();
            if (cmbNamePlato.SelectedIndex > -1)
            {
                //obtengo datos de plato
                Platos plato = listPlatos.Find(x => x.Nombre == cmbNamePlato.Text);
                cmbCategoria.SelectedIndex = plato.Categoria - 1;
                txtPrecio.Text = plato.Precio.ToString();
                txtImage.Text = plato.Image;
            }
			LoadDataRecetas();
			CargarReceta();
		}

		private void BtnSaveReceta_Click(object sender, EventArgs e)
		{
			//valido q todos los datos esten completos
			if (cmbCategoria.SelectedIndex >-1 && cmbNamePlato.Text.Length >0 && txtPrecio.TextLength > 0)
			{
				AddReceta();
			}
		}

		private int ObtenerIdPlato(int id, string name)
		{
			int idPlato = -10;
			//verifico q sea un nuevo plato o  modificacion de un existente
			if (id >= 0)
			{
				//busco plato seleccionado y consigo su id
				Platos platoEncontrado = listPlatos.Find(x => x.Nombre == name);
				if (platoEncontrado != null)
				{
					idPlato = platoEncontrado.Id;
				}
				else
				{
					MessageBox.Show("Ocurrio un error verifique seleecion de plato");
				}
			}
			return idPlato;
		}

		private void AddReceta()
		{
            //obtengo id de plato o creo un nuevo
            //int idPlato = -10; //ObtenerIdPlato(cmbNamePlato.SelectedIndex, cmbNamePlato.Text);
            //obtengo plato si existe
            Platos platoExistente = listPlatos.Find(x => x.Nombre == cmbNamePlato.Text);
			if (platoExistente != null)
			{
                //plato existente a actualizar
                platoExistente.Categoria = cmbCategoria.SelectedIndex + 1;
                platoExistente.Precio = Convert.ToDecimal(txtPrecio.Text);
                platoExistente.Image = txtImage.Text;

                string sql = $"UPDATE PLATOS SET categoria = @categoria, " +
                    $"precio = @precio, [image] = @image WHERE id = @idPlato; ";
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    OleDbCommand cmd = new OleDbCommand()
                    {
                        Connection = con
                    };
                    //cmd.Connection = con;
                    try
                    {
                        con.Open();
                        cmd.CommandText = sql;
                        cmd.Parameters.Add("@categoria", OleDbType.Char).Value = platoExistente.Categoria;
                        cmd.Parameters.Add("@precio", OleDbType.Decimal).Value = platoExistente.Precio;
                        cmd.Parameters.Add("@image", OleDbType.Char).Value = platoExistente.Image;
                        cmd.Parameters.Add("@idPlato", OleDbType.Integer).Value = platoExistente.Id;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            string sqldelReceta = $"DELETE FROM recetas WHERE plato = @platoId";
                            OleDbTransaction transaction = null;
                            cmd.Connection = con;
                            
                            
                            try
                            {
                                con.Open();
                                transaction = con.BeginTransaction();
                                cmd.Connection = con;
                                cmd.Transaction = transaction;
                                cmd.CommandText = sqldelReceta;//primera sentencia sql
                                cmd.Parameters.Add("@platoId", OleDbType.Integer).Value = platoExistente.Id;
                                cmd.ExecuteNonQuery();

                                //ingreso receta
                                foreach (Recetas ingrediente in listReceta)
                                {
                                    cmd.CommandText = string.Format($"INSERT INTO recetas (plato, insumo, cantidad) " +
                                        $"VALUES ({platoExistente.Id}, {ingrediente.Insumo}, {ingrediente.Cantidad});");
                                    cmd.ExecuteNonQuery();
                                }
                                transaction.Commit();
                                MessageBox.Show("Transaccion exitosa", "operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCantidadIngrediente.Text = "";
                                txtImage.Text = "";
                                txtPrecio.Text = "";
                                cmbNamePlato.Text = "";
                                cmbCategoria.SelectedIndex = -1;
                                listViewReceta.Items.Clear();
                            }
                            catch(Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("no de puedo realizar la operacion "+ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error al iniciar operacion "+ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
			}
			else
			{
                //creo plato nuevo con id -
                int idPlato = -10;
                Platos plato = new Platos(idPlato, cmbNamePlato.Text.ToUpper().Trim(),
					Convert.ToDecimal(txtPrecio.Text), txtImage.Text, (cmbCategoria.SelectedIndex + 1));

				string sql = $"INSERT INTO platos (plato, precio, [image], categoria)" +
					$" VALUES(@plato, @precio, @image, @categoria);";

				using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
				{
					OleDbCommand cmd = new OleDbCommand()
                    {
                        Connection = con
                    };
					//cmd.Connection = con;
					try
					{
						con.Open();
						cmd.Connection = con;
						cmd.CommandText = sql;
                        cmd.Parameters.Add("@plato", OleDbType.Char).Value = plato.Nombre;
                        cmd.Parameters.Add("@precio", OleDbType.Decimal).Value = plato.Precio;
                        cmd.Parameters.Add("@image", OleDbType.Char).Value = plato.Image;
                        cmd.Parameters.Add("@categoria", OleDbType.Integer).Value = plato.Categoria;
						if (cmd.ExecuteNonQuery() > 0)
						{
							//obtengo id de plato y recorro listado de ingredientes
							con.Close();
							try
							{
								con.Open();
								cmd.Connection = con;
								//recargo el cmb platos y refresco la list
								CargarcmbPlatos();
								int idPlatoInsertar = ObtenerIdPlato(1, plato.Nombre);
								foreach (Recetas ingrediente in listReceta)
								{
									cmd.CommandText = string.Format($"INSERT INTO recetas (plato, insumo, cantidad) " +
										$"VALUES ({idPlatoInsertar}, {ingrediente.Insumo}, {ingrediente.Cantidad});");
									cmd.ExecuteNonQuery();
								}
								txtCantidadIngrediente.Text = "";
								txtImage.Text = "";
								txtPrecio.Text = "";
								cmbNamePlato.Text = "";
								cmbCategoria.SelectedIndex = -1;
								listViewReceta.Items.Clear();
							}
							catch (Exception ex)
							{
								MessageBox.Show("ocurrio un error al ingresar los ingredientes: " + ex.Message);
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("no se pudo ingresar el plato: " + ex.Message);
					}
					//no es necesario al salir del bloque using se cierra la coneccion
					//con.Close();
				}

			}
		}

		private void LoadDataRecetas()
		{
			string sql = "SELECT plato, insumo, cantidad FROM recetas;";
			using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
			{
				OleDbCommand cmd = new OleDbCommand()
                {
                    Connection = con
                };
				//cmd.Connection = con;
				try
				{
					con.Open();
					cmd.CommandText = sql;
					OleDbDataReader dr = cmd.ExecuteReader();
					listReceta.Clear();
					while (dr.Read())
					{
						int plato = Convert.ToInt32(dr["plato"]);
						int insumo = Convert.ToInt32(dr["insumo"]);
						int cantidad = Convert.ToInt32(dr["cantidad"]);
						Recetas recetaPlato = new Recetas(plato, insumo, cantidad);
						listReceta.Add(recetaPlato);
					}
					//con.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				foreach (Recetas rec in listReceta)
				{
					string NamePlato = ObtenerNamePlato(rec.IdPlato);
					string[] row = { NamePlato, rec.Cantidad.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewReceta.Items.Add(listViewItem);
				}
			}
		}

		private string ObtenerNamePlato(int id)
		{
			string name = "";
			Platos plato = listPlatos.Find(x => x.Id == id);
			if(plato != null)
			{
				name = plato.Nombre;
			}
			return name;
		}

        private void BtnAddImg_Click(object sender, EventArgs e)
        {
            //abro cuadro de dialogo
            selectImage.ShowDialog();
        }

        private void NumberTxt_Leave(object sender, EventArgs e)
        {
            string text = txtPrecio.Text.Trim();
            try
            {
                decimal number = Convert.ToDecimal(text);
            }
            catch
            {
                txtPrecio.Text = "";
            }
        }

        private void ValidateInt(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtCantidadIngrediente_Leave(object sender, EventArgs e)
        {
            try
            {
                int cant = Convert.ToInt32(txtCantidadIngrediente.Text.Trim());
            }
            catch {
                txtCantidadIngrediente.Text = "";
            }
        }

        private void ListViewReceta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewReceta.SelectedItems != null)
            {
                int idPlato = ObtenerIdPlato(cmbNamePlato.SelectedIndex, cmbNamePlato.Text);
                string nameInsumo = listViewReceta.SelectedItems[0].Text;
                InsumosModel insumo = listIngredientes.Find(x => x.Insumo == nameInsumo);
                int idInsumo = insumo.Id;
                int cantidad = Convert.ToInt32(listViewReceta.SelectedItems[0].SubItems[1].Text);

                Recetas recetaEncontrada = listReceta.Find(x => x.IdPlato == idPlato && x.Insumo == idInsumo);
                if(recetaEncontrada != null)
                {
                    listReceta.Remove(recetaEncontrada);
                    CargarReceta();
                }
            }
        }
    }
}
