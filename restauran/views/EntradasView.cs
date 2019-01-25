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
        List<Ingresos> listIngresos = new List<Ingresos>();
        int numberIndex = 1;
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
            listProvider.Clear();
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
                        int id = Convert.ToInt32(dr["id"]);
                        string nit = dr["nit"].ToString();
                        string providerName = dr["proveedor"].ToString();
                        string phone = dr["telefono"].ToString();
                        string adress = dr["direccion"].ToString();
                        string email = dr["email"].ToString();
                        string others = dr["otros"].ToString();
                        listProvider.Add(new Provider(id, nit, providerName, phone, adress, email, others));
                        cmbProvider.Items.Add(providerName);
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
            cmbProductsBaja.Items.Clear();
            listInsumos.Clear();
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
                        int id = Convert.ToInt32(dr["id"]);
                        string name = dr["insumo"].ToString();
                        string unidad = dr["unidad"].ToString();
                        int stock = Convert.ToInt32(dr["stock"]);
                        int stockMinimo = Convert.ToInt32(dr["stockMinimo"]);
                        listInsumos.Add(new InsumosModel(id, name, unidad, stock,stockMinimo));
                        cmbInsumo.Items.Add(name);
                        cmbProductsBaja.Items.Add(name);
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
            string vlrUnit = txtVlrUnitario.Text.Trim();
            string fecha = dateAddinsumo.Text;
            //DateTime fecha = Convert.ToDateTime(dateAddinsumo);
            

            if(provider.Length>0 && nFactura.Length>0 && insumo.Length>0 && cant.Length > 0
                && vlrUnit.Length>0 && fecha.Length>0)
            {
                //vamos a guradar datos en lista ingresos
                InsumosModel insumoExistente = listInsumos.Find(x => x.Insumo == insumo);
                Provider proveedorExistente = listProvider.Find(x => x.Name == provider);
                if (insumoExistente != null && proveedorExistente != null)
                {
                    try
                    {
                        decimal vlrUnitario = Convert.ToDecimal(txtVlrUnitario.Text);
                        int cantidad = Convert.ToInt32(txtCantAdd.Text);
                        DateTime fechaAdd = Convert.ToDateTime(dateAddinsumo.Text);
                        int idProveedor = Convert.ToInt32(proveedorExistente.Id);
                        listIngresos.Add(new Ingresos(insumoExistente.Id, vlrUnitario, txtNumberSales.Text, cantidad, 
                            idProveedor, txtObservation.Text, fechaAdd));
                        string[] row = { numberIndex++.ToString(), insumoExistente.Insumo, insumoExistente.Unidad,
                            cantidad.ToString(), vlrUnitario.ToString(), Convert.ToString(vlrUnitario*cantidad)};
                        var listViewItem = new ListViewItem(row);
                        listViewFactura.Items.Add(listViewItem);
                        cmbInsumo.Text = "";
                        txtVlrUnitario.Text = "";
                        txtCantAdd.Text = "";
                        txtObservation.Text = "";

                    }catch (Exception ex)
                    {
                        MessageError(ex);
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

        private void CantidadValidBaja_Leave(object sender, EventArgs e)
        {
            try
            {
                int cant = Convert.ToInt32(txtCantdel.Text.Trim());
            }
            catch
            {
                txtCantAdd.Text = "";
            }
        }

        private void MessageError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveItemsFacturaView(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                foreach (Ingresos ingreso in listIngresos)
                {
                    OleDbTransaction transaction = null;
                    try
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        con.Open();
                        transaction = con.BeginTransaction();
                        cmd.Connection = con;
                        cmd.Transaction = transaction;
                        //agregar a ingresos y sumo stock
                        string sql = $"INSERT INTO ingresos (insumo, vlrUnitario, recibo, cantidad, proveedor, observacion, fecha) VALUES " +
                             $"(@insumo, @vlrUnitario, @recibo, @cantidad, @proveedor, " +
                             $"@observacion, @fecha);";
                        //MessageBox.Show(sql);
                        cmd.CommandText = sql;
                        cmd.Parameters.Add("@insumo", OleDbType.Integer).Value = ingreso.Insumo;
                        cmd.Parameters.Add("@vlrUnitario", OleDbType.Decimal).Value = ingreso.VlrUnitario;
                        cmd.Parameters.Add("@recibo", OleDbType.Char).Value = ingreso.Recibo;
                        cmd.Parameters.Add("@cantidad", OleDbType.Integer).Value = ingreso.Cantidad;
                        cmd.Parameters.Add("@proveedor", OleDbType.Integer).Value = ingreso.Proveedor;
                        cmd.Parameters.Add("@observacion", OleDbType.Char).Value = ingreso.Observacion;
                        cmd.Parameters.Add("@fecha", OleDbType.Date).Value = ingreso.Fecha;
                        //MessageBox.Show("el id de proveedor es " + ingreso.Proveedor + " el id de insumo es " + ingreso.Insumo);

                        cmd.ExecuteNonQuery();

                        string sql2 = string.Format($"UPDATE  insumos SET stock= (stock + {ingreso.Cantidad} )  WHERE id = @Id;");
                        //cmd.Parameters.Add("@Cant", OleDbType.Integer).Value = ingreso.Cantidad;
                        cmd.Parameters.Add("@Id", OleDbType.Integer).Value = ingreso.Insumo;
                        MessageBox.Show(sql2);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        //con.Close();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                            //transaction no esta activa
                        }
                        MessageBox.Show("data base" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                listViewFactura.Items.Clear();
                listIngresos.Clear();
                cmbProvider.Text = "";
                txtNumberSales.Text = "";
                cmbProvider.Text = "";
                txtCantAdd.Text = "";
                txtObservation.Text = "";
                txtVlrUnitario.Text = "";
            }
        }

        private void DarBaja(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                OleDbTransaction transaction = null;
                try
                {
                    int cantidad = Convert.ToInt32(txtCantdel.Text);
                    InsumosModel insumoExistente = listInsumos.Find(x => x.Insumo == cmbProductsBaja.Text);

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    transaction = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = transaction;
                    string sql = string.Format($"UPDATE insumos SET stock = (stock - {cantidad} )  WHERE id = @Id;");
                    string sql2 = $"INSERT INTO bajas (insumo, cantidad, observacion, fecha) VALUES (@insumo, @cantidad," +
                        $"@observacion, @fecha)";
                    cmd.Parameters.Add("@Id", OleDbType.Integer).Value = insumoExistente.Id;
                    cmd.Parameters.Add("@Cantidad", OleDbType.Integer).Value = cantidad;
                    cmd.Parameters.Add("@observacion", OleDbType.Char).Value = txtObservationBaja.Text.Trim();
                    cmd.Parameters.Add("@fecha", OleDbType.Date).Value = Convert.ToDateTime(dateBaja.Text);

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = sql2;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    //con.Close();
                    MessageBox.Show("Transaccion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantdel.Text = "";
                    cmbProductsBaja.Text = "";
                    dateBaja.ResetText();
                    txtObservationBaja.Text = "";
                }
                catch(Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch { }
                    MessageError(ex);
                }
            }
        }

        private void ShowDetail(object sender, EventArgs e)
        {
            InventarioView inventario = new InventarioView();
            inventario.ShowDialog();
        }
    }
}
