using restauran.controller;
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
	public partial class Categoria : Form
	{
		public Categoria()
		{
			InitializeComponent();
            LoadData();
		}

        private void LoadData()
        {
            DataSet ds = DataAplication.Execute("SELECT * FROM categorias");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0)
            {
                txtNameCategoria1.Text = ds.Tables[0].Rows[0]["categoria"].ToString();
                txtDescriptionCategoria1.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                txtNameCategoria2.Text = ds.Tables[0].Rows[1]["categoria"].ToString();
                txtDescriptionCategoria2.Text = ds.Tables[0].Rows[1]["descripcion"].ToString();
                txtNameCategoria3.Text = ds.Tables[0].Rows[2]["categoria"].ToString();
                txtDescriptionCategoria3.Text = ds.Tables[0].Rows[2]["descripcion"].ToString();
                txtNameCategoria4.Text = ds.Tables[0].Rows[3]["categoria"].ToString();
                txtDescriptionCategoria4.Text = ds.Tables[0].Rows[3]["descripcion"].ToString();
            }
        }

        private void UpdateCategoria1(object sender, EventArgs e)
        {
            string nombre = txtNameCategoria1.Text.Trim().ToUpper();
            string description = txtDescriptionCategoria1.Text.Trim().ToUpper();
            int id = 1;
            string[] arr = { nombre, description};
            UpdateData(id, arr);
            //LoadData();
        }
        private void UpdateCategoria2(object sender, EventArgs e)
        {
            string nombre = txtNameCategoria2.Text.Trim().ToUpper();
            string description = txtDescriptionCategoria2.Text.Trim().ToUpper();
            int id = 2;
            string[] arr = { nombre, description };
            UpdateData(id, arr);
            //LoadData();
        }
        private void UpdateCategoria3(object sender, EventArgs e)
        {
            string nombre = txtNameCategoria3.Text.Trim().ToUpper();
            string description = txtDescriptionCategoria3.Text.Trim().ToUpper();
            int id = 3;
            string[] arr = { nombre, description };
            UpdateData(id, arr);
            //LoadData();
        }
        private void UpdateCategoria4(object sender, EventArgs e)
        {
            string nombre = txtNameCategoria4.Text.Trim().ToUpper();
            string description = txtDescriptionCategoria4.Text.Trim().ToUpper();
            int id = 4;
            string[] arr = { nombre, description };
            UpdateData(id, arr);
            //LoadData();
        }

        private void UpdateData(int id, string[] arr)
        {
            string sql = $"UPDATE CATEGORIAS SET categoria = ?, descripcion = ? WHERE Id = {id}";
            if(DataAplication.InsertData(sql, arr))
            {
                MessageBox.Show("Transaccion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fallo la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
