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
    public partial class EntradasView : Form
    {
        List<Provider> listProvider = new List<Provider>();
        List<InsumosModel> listInsumos = new List<InsumosModel>();
        public EntradasView()
        {
            InitializeComponent();
            LoadListProducts();
            LoadListProvider();
        }

        private void NewInsumo(object sender, EventArgs e)
        {
            Insumos insumo = new Insumos();
            insumo.ShowDialog();
            LoadListProducts();
        }

        private void NewProvider(object sender, EventArgs e)
        {
            ProveedorView provider = new ProveedorView();
            provider.ShowDialog();
            LoadListProvider();
        }

        private void LoadListProvider()
        {
            cmbProvider.Items.Clear();
            string sql = "SELECT * FROM PROVEEDOR";
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listProvider.Add(new Provider(dr["nit"].ToString(), dr["proveedor"].ToString(), dr["telefono"].ToString(), 
                            dr["direccion"].ToString(), dr["email"].ToString(), dr["otros"].ToString()));
                        cmbProvider.Items.Add(dr["proveedor"].ToString());
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadListProducts()
        {
            cmbInsumo.Items.Clear();
            string sql = "SELECT * FROM insumos";
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listInsumos.Add(new InsumosModel(Convert.ToInt32(dr["id"]), dr["insumo"].ToString(),
                            dr["unidad"].ToString(), Convert.ToInt32(dr["stock"]), Convert.ToInt32(dr["stockMinimo"])));
                        cmbInsumo.Items.Add(dr["insumo"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductListView(object sender, EventArgs e)
        {
            string provider = cmbProvider.Text;
            string nFactura = txtNumberSales.Text.Trim();
            string insumo = cmbInsumo.Text;
            string cant = txtCantAdd.Text.Trim();
            string vlrUnit = txtVlrUnitario.Text;
            string fecha = dateAddinsumo.Text;
            //DateTime fecha = Convert.ToDateTime(dateAddinsumo);
            

            if(provider.Length>0 && nFactura.Length>0 && insumo.Length>0 && cant.Length > 0
                && vlrUnit.Length>0 && fecha.Length>0)
            {
                InsumosModel insumoExistente = listInsumos.Find(x => x.Insumo == insumo);
                if (insumoExistente != null)
                {
                    string sql = "INSERT INTO ingresos (insumo, vlrUnitario, recibo, cantidad, proveedor, observacion, fecha) VALUES " +
                        "(@Insumo, @VlrUnitario, @Recibo, @Cantidad, @Proveedor, @Observacion, @Fecha)";
                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                        {
                            con.Open();
                            OleDbCommand cmd = new OleDbCommand();
                            OleDbTransaction transaction = null;
                            cmd.Connection = con;
                            cmd.Transaction = transaction;
                            con.BeginTransaction();
                            cmd.CommandText = sql;

                            cmd.Parameters.Add();
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ValidateInt(object sender, KeyPressEventArgs e)
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

        private void CantidadValid_Leave(object sender, EventArgs e)
        {
            try
            {
                int cant = Convert.ToInt32(txtCantAdd.Text.Trim());
            }
            catch
            {
                txtCantAdd.Text = "";
            }
        }
    }
}
