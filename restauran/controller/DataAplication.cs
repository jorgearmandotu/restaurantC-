using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace restauran.controller
{
    class DataAplication
    {
        public static DataSet Execute(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    con.Open();
                    //OleDbCommand cmd = new OleDbCommand(sql, con);
                    //OleDbDataReader dr = cmd.ExecuteReader();
                    OleDbDataAdapter dp = new OleDbDataAdapter(string.Format(sql), con);
                    dp.Fill(ds);
                    //con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //Console.WriteLine(ex.Message);
            }
            return ds;
        }

        public static bool InsertData(string sql)
        {
            bool res = false;
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    //con.Close();
                    res = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //Console.WriteLine(ex.Message);
            }
            return res;
        }

        public static bool InsertData(string sql, string[] array)
        {
            bool res = false;
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con)
                    {
                        CommandText = sql
                    };
                    //cmd.CommandText = sql;
                    
                    foreach (string dato in array)
                    {
                        //cmd.Parameters.Add("?", OleDbType.Integer).Value = ingreso.Insumo;
                        cmd.Parameters.AddWithValue("?", dato);
                    }
                    
                    cmd.ExecuteNonQuery();
                    //con.Close();
                    res = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //Console.WriteLine(ex.Message);
            }
            return res;
        }
    }
}
