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

		private void BtnIngresoInsumo_Click(object sender, EventArgs e)
		{
            string nombre = txtNameInsumo.Text.Trim().ToUpper();
            string unidad = txtUnidad.Text.Trim().ToUpper();
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    try
                    {
                        int stockInicial = Convert.ToInt32(txtStockInicial.Text.Trim());
                        int stockMinimo = Convert.ToInt32(txtStockMinimo.Text.Trim());
                        string sql = "INSERT INTO insumos (insumo, stock, unidad, stockMinimo) VALUES(@insumo, @stock, @unidad, @stockMinimo)";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(sql, con);
                        cmd.Parameters.Add("@insumo", OleDbType.Char).Value = nombre;
                        cmd.Parameters.Add("@stock", OleDbType.Integer).Value = stockInicial;
                        cmd.Parameters.Add("@unidad", OleDbType.Char).Value = unidad;
                        cmd.Parameters.Add("@stockMinimo", OleDbType.Integer).Value = stockMinimo;
                        cmd.ExecuteNonQuery();
                        //con.Close();
                        MessageBox.Show("Transacion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNameInsumo.Text = "";
                        txtStockInicial.Text = "";
                        txtStockMinimo.Text = "";
                        txtUnidad.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void ValidateNumbertxtStockInical(object sender, KeyPressEventArgs e)
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

        private void ValidateTxtStockMinimokeypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LeaveTxtStockInical(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtStockInicial.Text.Trim());
            }
            catch
            {
                txtStockInicial.Text = "";
            }
        }

        private void TxtStockMinimo_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtStockMinimo.Text.Trim());
            }
            catch
            {
                txtStockMinimo.Text = "";
            }
        }
    }
}
