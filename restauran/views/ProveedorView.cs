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
    public partial class ProveedorView : Form
    {
        public ProveedorView()
        {
            InitializeComponent();
        }

        private void AddProvider(object sender, EventArgs e)
        {
            string id = txtIdProvider.Text.Trim();
            string name = txtNameProvider.Text.Trim().ToUpper();
            string phone = txtPhoneProvider.Text.Trim();
            string adress = txtadressProvider.Text.Trim();
            string email = txtEmailProvider.Text.Trim();
            string others = txtOthersProvider.Text.Trim();
            if (id.Length > 0 && name.Length > 0 && phone.Length > 0)
            {
                string sql = "INSERT INTO proveedor (nit, proveedor, telefono, email, direccion, otros) VALUES " +
                    "(@Id, @Name, @Phone, @Email, @Adress, @Others)";
                try
                {
                    using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(sql, con);
                        cmd.Parameters.Add("@Id", OleDbType.Char).Value = id;
                        cmd.Parameters.Add("@Name", OleDbType.Char).Value = name;
                        cmd.Parameters.Add("@Phone", OleDbType.Char).Value = phone;
                        cmd.Parameters.Add("@Email", OleDbType.Char).Value = email;
                        cmd.Parameters.Add("@Adress", OleDbType.Char).Value = adress;
                        cmd.Parameters.Add("@Others", OleDbType.Char).Value = others;

                        cmd.ExecuteNonQuery();
                        //con.Close();
                        txtIdProvider.Text = "";
                        txtNameProvider.Text = "";
                        txtPhoneProvider.Text = "";
                        txtEmailProvider.Text = "";
                        txtadressProvider.Text = "";
                        txtOthersProvider.Text = "";
                        MessageBox.Show("Transaccion Exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
