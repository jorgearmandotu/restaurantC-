using restauran.controller;
using restauran.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran
{
	public partial class LogIn : Form
	{
		private Boolean log = false;
		public LogIn()
		{
			InitializeComponent();
		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			logIn();
		}

		private void logIn()
		{
			String user = txtUser.Text;
			String password = txtPassword.Text;
			Talks talk = new Talks();
			if(talk.logIn(user, password))
			{
				Console.WriteLine("logueado");
                //MessageBox.Show("logueado");
                //Productos products = new Productos();
                //products.Show();
                Pedidos pedido = new Pedidos();
                this.Hide();
                pedido.ShowDialog();
                this.Dispose();
			}
			else
			{
				Console.WriteLine("no login");
				MessageBox.Show("Datos no validos");
				
			}
		}

		private void btnLogIn_MouseCaptureChanged(object sender, EventArgs e)
		{

		}
		public Boolean getLog()
		{
			return log;
		}

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
