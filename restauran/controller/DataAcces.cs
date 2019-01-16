using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace restauran.controller
{
	class DataAcces
	{
		public static string conection = ConfigurationManager.ConnectionStrings["restaurantConnectionString"].ConnectionString;
        //public static decimal impuestoConsumo = Properties.Settings.Default.ImpuestoConsumo;
		
	}
}
