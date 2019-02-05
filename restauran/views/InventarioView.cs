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
            listViewDetail.Clear();
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
            if (radioButtonVentas.Checked)
            {
                ReportVentas(fechaInicio, fechaFin);
            }else if (radioButtonEntradas.Checked)
            {
                ReportEntradas(fechaInicio, fechaFin);
            }else if (radioButtonBajas.Checked)
            {
                ReportBajas(fechaInicio, fechaFin);
            }
        }

        private void ReportBajas(string fechaInicio, string fechaFin)
        {
            listViewDetail.Clear();
            string sql = $"SELECT * FROM bajas WHERE ((bajas.[fecha] <=#{fechaFin} 00:00:00#) AND fecha >= #{fechaInicio}#) ORDER BY fecha DESC";
            string sqlInsumo = "SELECT Id, insumo, unidad FROM insumos";
            DataSet dsBajas = DataAplication.Execute(sql);
            listViewDetail.Columns.Add("fecha", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Insumo", 200, textAlign: HorizontalAlignment.Left);
            listViewDetail.Columns.Add("Unidad", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("cantidad", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("observaciones", 300, textAlign: HorizontalAlignment.Center);
            if(dsBajas.Tables.Count > 0)
            {
                DataSet dsInsumos = DataAplication.Execute(sqlInsumo);
                foreach(DataRow drB in dsBajas.Tables[0].Rows)
                {
                    string insumo = "";
                    string unidad = "";
                    foreach(DataRow drI in dsInsumos.Tables[0].Rows)
                    {
                        if(drB["insumo"].ToString() == drI["Id"].ToString())
                        {
                            insumo = drI["insumo"].ToString();
                            unidad = drI["unidad"].ToString();
                            break;
                        }
                    }
                    string[] row = { drB["fecha"].ToString(), insumo, unidad, drB["cantidad"].ToString(), drB["observacion"].ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listViewDetail.Items.Add(item);
                }
            }
        }
        private void ReportEntradas(string fechaInicio, string fechaFin)
        {
            listViewDetail.Clear();
            string sqlEntradas = $"SELECT * from ingresos WHERE ((ingresos.[fecha] <=#{fechaFin} 00:00:00#) AND fecha >= #{fechaInicio}#) ORDER BY fecha DESC";
            string sqlInsumos = "SELECT Id, insumo, unidad FROM insumos";
            string sqlProveedor = "SELECT iD, proveedor FROM proveedor";
            DataSet dsEntradas = DataAplication.Execute(sqlEntradas);
            listViewDetail.Columns.Add("fecha", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Insumo", 200, textAlign: HorizontalAlignment.Left);
            listViewDetail.Columns.Add("Unidad", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("VlrUnitario", 150, textAlign: HorizontalAlignment.Right);
            listViewDetail.Columns.Add("cantidad", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("proveedor", 200, textAlign: HorizontalAlignment.Left);
            listViewDetail.Columns.Add("recibo", 100, textAlign: HorizontalAlignment.Left);
            listViewDetail.Columns.Add("Observaciones", 200);
            if (dsEntradas.Tables.Count > 0)
            {
                DataSet dsInsumos = DataAplication.Execute(sqlInsumos);
                DataSet dsProveedor = DataAplication.Execute(sqlProveedor);
                foreach (DataRow dr in dsEntradas.Tables[0].Rows)
                {
                    string insumo = "";
                    string unidad = "";
                    string proveedor = "";
                    foreach (DataRow drI in dsInsumos.Tables[0].Rows)
                    {
                        if(dr["insumo"].ToString() == drI["Id"].ToString())
                        {
                            insumo = drI["insumo"].ToString();
                            unidad = drI["unidad"].ToString();
                            break;
                        }
                    }
                    foreach(DataRow drP in dsProveedor.Tables[0].Rows)
                    {
                        if(drP["Id"].ToString() == dr["proveedor"].ToString())
                        {
                            proveedor = drP["proveedor"].ToString();
                            break;
                        }
                    }
                    decimal valorUnidad = Convert.ToDecimal(dr["vlrUnitario"]);
                    string vlrUnitario = string.Format("{0:C}",valorUnidad);
                    string[] row = {dr["fecha"].ToString(), insumo, unidad, vlrUnitario, dr["cantidad"].ToString(), proveedor,
                    dr["recibo"].ToString(), dr["observacion"].ToString()};
                    ListViewItem item = new ListViewItem(row);
                    listViewDetail.Items.Add(item);
                }
            }
        }
        private void ReportVentas(string fechaInicio, string fechaFin)
        {
            string sqlPlatos = "SELECT * FROM platos";
            string sqlFactura = "SELECT * FROM facturacion";
            string sql = string.Format($"SELECT * FROM salidas WHERE((salidas.[fecha] <=#{fechaFin}00:00:00#) AND fecha >= #{fechaInicio}#) ORDER BY fecha DESC");
            // $"((salidas.fecha) Between #{fechaInicio}# And #{fechaFin}#));");

            //Console.WriteLine(sql);
            DataSet ds = DataAplication.Execute(sql);
            listViewDetail.Clear();
            listViewDetail.Columns.Add("Plato", 300);
            listViewDetail.Columns.Add("cantidad", 80, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Fecha", 150, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("N.Factura", 150, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Vlr Factura", 150, textAlign: HorizontalAlignment.Right);
            if (ds.Tables.Count > 0)//verifico q devuelva resultados
            {
                DataSet dsFactura = DataAplication.Execute(sqlFactura);
                DataSet dsPlatos = DataAplication.Execute(sqlPlatos);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string namePlato = "";
                    string vlrFacturado = "0";
                    string baja = "";
                    foreach (DataRow drP in dsPlatos.Tables[0].Rows)
                    {
                        if (drP["Id"].ToString() == dr["plato"].ToString())
                        {
                            namePlato = drP["plato"].ToString();
                            break;
                        }
                    }
                    foreach (DataRow drF in dsFactura.Tables[0].Rows)
                    {
                        if (drF["nFactura"].ToString() == dr["Factura"].ToString())
                        {
                            decimal valorFactura = Convert.ToDecimal(drF["vlrFacturado"]);
                            vlrFacturado = string.Format("{0:C}", valorFactura);
                            break;
                        }
                    }

                    string[] row = { namePlato, dr["cantidad"].ToString(), dr["fecha"].ToString(), dr["factura"].ToString(),
                        vlrFacturado };
                    ListViewItem item = new ListViewItem(row);
                    listViewDetail.Items.Add(item);
                }
            }
        }


        private void EstadoActuatStock(object sender, EventArgs e)
        {
            StockActual();
        }
    }
}
