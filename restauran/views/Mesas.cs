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
	public partial class Mesas : Form
	{
        public Mesas()
        {
            InitializeComponent();
        }

        private void BtnAddMesa_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO mesas (nombre) VALUES(@nombre)";
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.Add("@nombre", OleDbType.Char).Value = txtNameMesa.Text.Trim().ToUpper();
                    cmd.ExecuteNonQuery();
                    //con.Close();
                    MessageBox.Show("Transacion exitosa", "Transaccion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameMesa.Text = "";
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }
    }
}
