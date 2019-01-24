using restauran.controller;
using restauran.models;
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
			IntentLogIn();
		}

		private void IntentLogIn()
		{
			String user = txtUser.Text.Trim();
			String password = txtPassword.Text.Trim();
			Talks talk = new Talks();
            Users log = talk.LogIn(user, password);

            if (log != null)
			{
				//Console.WriteLine("logueado");
                //MessageBox.Show("logueado");
                //Productos products = new Productos();
                //products.Show();
                Pedidos pedido = new Pedidos(log);
                this.Hide();
                pedido.ShowDialog();
                this.Dispose();
			}
			else
			{
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
            Application.Exit();
        }
    }
}
