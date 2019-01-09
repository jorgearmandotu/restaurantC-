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
	public partial class Insumos : Form
	{
		public Insumos()
		{
			InitializeComponent();
		}

		private void btnIngresoInsumo_Click(object sender, EventArgs e)
		{
			if(txtNameInsumo.TextLength > 0 && txtStockInicial.TextLength>0 
				&& txtStockMinimo.TextLength>0 && txtUnidad.TextLength > 0)
			{
				string name = txtNameInsumo.Text.ToUpper();
				int stockInical = Convert.ToInt32(txtStockInicial.Text);
				int stockMinimo = Convert.ToInt32(txtStockMinimo.Text);
				string unidad = txtUnidad.Text.ToUpper();

				InsumosModel insumo = new InsumosModel(1, name,unidad,stockInical, stockMinimo);
				string sql = $"INSERT INTO insumos (insumo, stock, unidad, stockMinimo)" +
					$" VALUES('{insumo.Insumo}', {insumo.Stock}, '{insumo.Unidad}', {stockMinimo})";

				using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
				{ 
					OleDbCommand cmd = new OleDbCommand();
					cmd.Connection = con;
				try
					{
						con.Open();
						//OleDbCommand cmd = new OleDbCommand(sql);
						//cmd.Connection = con;

						cmd.CommandText = sql;
						try
						{
							if (cmd.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("insumo agregado satisfactoriamente");
							}
						}catch(Exception ex)
						{
							MessageBox.Show("Ocurrio un error al insertar: "+ex.Message);
						}
						txtNameInsumo.Text = "";
						txtStockInicial.Text = "";
						txtStockMinimo.Text = "";
						txtUnidad.Text = "";
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}
	}
}
