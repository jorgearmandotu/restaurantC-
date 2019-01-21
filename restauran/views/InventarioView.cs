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
    public partial class InventarioView : Form
    {
        public InventarioView()
        {
            InitializeComponent();
            StockActual();
        }

        private void StockActual()
        {
            string sql = "SELECT * FROM insumos";
            listViewDetail.Columns.Add("Insumo", 230);
            listViewDetail.Columns.Add("Und", 50, textAlign:HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Existencias", 100, textAlign:HorizontalAlignment.Right);
            try
            {
                /*using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string name = dr["insumo"].ToString();
                        string unidad = dr["unidad"].ToString();
                        int cantidad = Convert.ToInt32(dr["stock"]);
                        int cantMinima = Convert.ToInt32(dr["stockMinimo"]);
                        if (cantidad <= cantMinima)
                        {
                            string[] row = { name, unidad, cantidad.ToString() };
                            var listViewItem = new ListViewItem(row);
                            listViewDetail.Items.Add(listViewItem).BackColor = Color.Red;
                        }else if (cantidad <= (cantMinima + (cantMinima * 0.1)))
                        {
                            string[] row = { name, unidad, cantidad.ToString() };
                            var listViewItem = new ListViewItem(row);
                            listViewDetail.Items.Add(listViewItem).BackColor = Color.Yellow;
                        }
                        else
                        {
                            string[] row = { name, unidad, cantidad.ToString() };
                            var listViewItem = new ListViewItem(row);
                            listViewDetail.Items.Add(listViewItem);
                        }
                        
                    }
                }*/

                DataSet ds = DataAplication.Execute(sql);
                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    string name = rows["insumo"].ToString();
                    string unidad = rows["unidad"].ToString();
                    int cantidad = Convert.ToInt32(rows["stock"]);
                    int cantMinima = Convert.ToInt32(rows["stockMinimo"]);
                    if (cantidad <= cantMinima)
                    {
                        string[] row = { name, unidad, cantidad.ToString() };
                        var listViewItem = new ListViewItem(row);
                        listViewDetail.Items.Add(listViewItem).BackColor = Color.Red;
                    }
                    else if (cantidad <= (cantMinima + (cantMinima * 0.1)))
                    {
                        string[] row = { name, unidad, cantidad.ToString() };
                        var listViewItem = new ListViewItem(row);
                        listViewDetail.Items.Add(listViewItem).BackColor = Color.Yellow;
                    }
                    else
                    {
                        string[] row = { name, unidad, cantidad.ToString() };
                        var listViewItem = new ListViewItem(row);
                        listViewDetail.Items.Add(listViewItem);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
