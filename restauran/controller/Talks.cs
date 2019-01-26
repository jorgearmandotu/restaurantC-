using restauran.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.controller
{
	class Talks
	{
		private String dataName;
		private String passwordDb;

		public Talks(string dataName, string passwordDb)
		{
			this.dataName = dataName;
			this.passwordDb = passwordDb;
		}

		public Talks ()
		{

		}

		public Users LogIn(String user, String password)
		{
            Users userLog = null;
            DataSet ds = new DataSet();
            string sql = string.Format($"SELECT * FROM users WHERE usuario = '{user}'");
            ds = DataAplication.Execute(sql);
            if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                string usuario = dr["usuario"].ToString();
                bool admin = Convert.ToBoolean(dr["administrador"]);
                string pwd = dr["password"].ToString();
                Helpper crypt = new Helpper();
                bool dataCorrect = crypt.ComparePwd(password, pwd);
                if (dataCorrect == true && user == usuario)
                {
                    //Console.WriteLine("se logueo "+usuario+" "+admin);
                    userLog = new Users(usuario, "", admin);
                    return userLog;
                }
                else
                {
                    //Console.WriteLine("No se logeo "+usuario+" "+password);
                    return userLog; 
                }
            }
            else
            {
                //Console.WriteLine("No hubo registros");
                return userLog;
            }
		}
	}
}
