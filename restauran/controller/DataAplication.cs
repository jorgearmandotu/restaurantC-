﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
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
                    OleDbDataAdapter dp = new OleDbDataAdapter(sql, con);
                    dp.Fill(ds);
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ds;
        } 
    }
}