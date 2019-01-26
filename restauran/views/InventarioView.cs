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
            string sql = "SELECT * FROM insumos ORDER BY insumo ASC";
            listViewDetail.Columns.Add("Insumo", 300);
            listViewDetail.Columns.Add("Und", 80, textAlign:HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Existencias", 150, textAlign:HorizontalAlignment.Right);
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

        private void ConsultXfecha(object sender, EventArgs e)
        {
            string fechaInicio = dateTimeFechaInicio.Text;
            string fechaFin = dateTimeFechaFin.Text;

            string sqlPlatos = "SELECT * FROM platos";
            DataSet dsPlatos = DataAplication.Execute(sqlPlatos);
            string sql = string.Format($"SELECT * FROM salidas WHERE((salidas.[fecha] <=#{fechaFin} 23:59:59#) AND fecha >= #{fechaInicio}#)");
               // $"((salidas.fecha) Between #{fechaInicio}# And #{fechaFin}#));");

            //Console.WriteLine(sql);
            DataSet ds = DataAplication.Execute(sql);
            listViewDetail.Clear();
            listViewDetail.Columns.Add("Plato", 300);
            listViewDetail.Columns.Add("cantidad", 80, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Fecha", 150, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("N.Factura", 150, textAlign: HorizontalAlignment.Center);
            if (ds.Tables.Count > 0)//verifico q devuelva resultados
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string namePlato = "";
                    foreach (DataRow drP in dsPlatos.Tables[0].Rows)
                    {
                        if (drP["Id"].ToString() == dr["plato"].ToString())
                        {
                            namePlato = drP["plato"].ToString();
                            break;
                        }
                    }
                    string[] row = { namePlato, dr["cantidad"].ToString(), dr["fecha"].ToString(), dr["factura"].ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listViewDetail.Items.Add(item);
                }
            }
            
        }
    }
}
