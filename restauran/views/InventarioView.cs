using Microsoft.Office.Interop.Excel;
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
        string reporte = "";
        public InventarioView()
        {
            InitializeComponent();
            StockActual();
        }

        private void StockActual()
        {
            listViewDetail.Clear();
            reporte = "";
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
            //las consuyltas con fechas se hacen en orden mes dia año
            DateTime fechaInicial = Convert.ToDateTime(dateTimeFechaInicio.Text);
            string fechaInicio = fechaInicial.ToString("MM/dd/yyyy");
            DateTime fechaFinal = Convert.ToDateTime(dateTimeFechaFin.Text);
            string fechaFin = fechaFinal.ToString("MM/dd/yyyy");
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
            reporte = "bajas";
            //string sql = $"SELECT * FROM bajas WHERE ((bajas.[fecha] <=#{fechaFin} 00:00:00#) AND fecha >= #{fechaInicio}#) ORDER BY fecha DESC";
            string sql = $"SELECT * FROM bajas WHERE((fecha >=#{fechaInicio}#) AND fecha<=#{fechaFin}#) ORDER BY fecha DESC; ";
            string sqlInsumo = "SELECT Id, insumo, unidad FROM insumos";
            Console.WriteLine(sql);
            DataSet dsBajas = DataAplication.Execute(sql);
            listViewDetail.Columns.Add("fecha", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Insumo", 200, textAlign: HorizontalAlignment.Left);
            listViewDetail.Columns.Add("Unidad", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("cantidad", 100, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("observaciones", 300, textAlign: HorizontalAlignment.Center);
            if(dsBajas.Tables.Count > 0)
            {
                Console.WriteLine(sqlInsumo);
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
                    DateTime fecha = Convert.ToDateTime(drB["fecha"]);
                    string[] row = { fecha.ToString("dd/MM/yyyy"), insumo, unidad, drB["cantidad"].ToString(), drB["observacion"].ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listViewDetail.Items.Add(item);
                }
            }
        }
        private void ReportEntradas(string fechaInicio, string fechaFin)
        {
            listViewDetail.Clear();
            reporte = "entradas";
            string sqlEntradas = $"SELECT * from ingresos WHERE ((fecha>=#{fechaInicio}#) AND fecha <= #{fechaFin}#) ORDER BY fecha DESC";
            string sqlInsumos = "SELECT Id, insumo, unidad FROM insumos";
            string sqlProveedor = "SELECT iD, proveedor FROM proveedor";
            Console.WriteLine(sqlEntradas);
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
                Console.WriteLine(sqlInsumos);
                Console.WriteLine(sqlProveedor);
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
                    DateTime fecha = Convert.ToDateTime(dr["fecha"]);
                    string[] row = {fecha.ToString("dd/MM/yyyy"), insumo, unidad, vlrUnitario, dr["cantidad"].ToString(), proveedor,
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
            string sql = string.Format($"SELECT * FROM salidas WHERE((salidas.[fecha] <=#{fechaFin}#) AND fecha >= #{fechaInicio}#) ORDER BY fecha DESC");
            // $"((salidas.fecha) Between #{fechaInicio}# And #{fechaFin}#));");

            Console.WriteLine(sql);
            DataSet ds = DataAplication.Execute(sql);
            listViewDetail.Clear();
            reporte = "ventas";
            listViewDetail.Columns.Add("Plato", 300);
            listViewDetail.Columns.Add("cantidad", 80, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Fecha", 150, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("N.Factura", 150, textAlign: HorizontalAlignment.Center);
            listViewDetail.Columns.Add("Vlr Factura", 150, textAlign: HorizontalAlignment.Right);
            if (ds.Tables.Count > 0)//verifico q devuelva resultados
            {
                Console.WriteLine(sqlFactura);
                Console.WriteLine(sqlPlatos);
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
                    DateTime fecha = Convert.ToDateTime(dr["fecha"]);
                    string[] row = { namePlato, dr["cantidad"].ToString(), fecha.ToString("dd/MM/yyyy"), dr["factura"].ToString(),
                        vlrFacturado };
                    ListViewItem item = new ListViewItem(row);
                    listViewDetail.Items.Add(item);
                }
            }
        }


        private void EstadoActuatStock(object sender, EventArgs e)
        {
            StockActual();
            radioButtonBajas.Checked = false;
            radioButtonEntradas.Checked = false;
            radioButtonVentas.Checked = false;
        }

        private void ExportarXls(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|* xlsx", ValidateNames = true })
            {
                if (reporte == "")
                {
                    //stock actual
                    string[] row = { "Insumo", "Unidad", "Existencias" };
                    CreateExel(sfd, row);
                }else if(reporte == "bajas")
                {
                    string[] row = {"Fecha", "Insumo", "Unidad", "Cantidad", "Observaciones"};
                    CreateExel(sfd, row);
                }else if (reporte == "entradas")
                {
                    string[] row = { "Fecha", "Insumo", "Unidad", "Vlr.Unitario", "Cantidad", "Proveedor", "Recibo", "Observaciones"};
                    CreateExel(sfd, row);
                }else if (reporte == "ventas")
                {
                    string[] row = { "plato", "Cantidad", "Fecha", "N.Factura", "Vlr Facturado"};
                    CreateExel(sfd, row);
                }
            }
        }

        private void CreateExel(SaveFileDialog sfd, string[] row)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)app.ActiveSheet;
                app.Visible = false;

                int columna = 0;
                //titulos
                foreach(string title in row)
                {
                    //ws.Cells[1, columna + 1].Select.+ColorIndex = 40;
                    //ws.Cells[1, columna + 1].Style.Font.Bold = true;
                    ws.Cells[1, columna+1] = title;
                    columna++;
                }
                /*
                ws.Cells[1, 1] = "Insumo";
                ws.Cells[1, 2] = "Unidad";
                ws.Cells[1, 3] = "Existencias";*/

                int i = 2;//fila
                foreach (ListViewItem item in listViewDetail.Items)
                {
                    for(int j = 0; j < columna; j++)
                    {
                        //ws.Cells[1, columna + 1].Style.Font.Bold = false;
                        //ws.Cells[1, columna + 1].Style.Interior.ColorIndex = 0;
                        ws.Cells[i, j+1] = item.SubItems[j].Text;
                        Console.WriteLine(item.SubItems[j].Text);
                    }
                    i++;
                   /* ws.Cells[i, 1] = item.SubItems[0].Text;
                    ws.Cells[i, 2] = item.SubItems[1].Text;
                    ws.Cells[i, 3] = item.SubItems[2].Text;
                    i++;*/
                }
                wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false,
                    XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                app.Quit();
                MessageBox.Show("Exportacion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
