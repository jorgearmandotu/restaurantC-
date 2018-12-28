using System;
using System.Collections.Generic;
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

		public Boolean logIn(String user, String password)
		{
			if(user == "admin" && password == "12312")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
