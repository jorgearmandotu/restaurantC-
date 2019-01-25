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
	public partial class Insumos : Form
	{
		public Insumos()
		{
			InitializeComponent();
		}

		private void BtnIngresoInsumo_Click(object sender, EventArgs e)
		{
			
		}

        private void ValidateNumbertxtStockInical(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ValidateTxtStockMinimokeypress(object sender, KeyPressEventArgs e)
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

        private void LeaveTxtStockInical(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtStockInicial.Text.Trim());
            }
            catch
            {
                txtStockInicial.Text = "";
            }
        }

        private void TxtStockMinimo_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtStockMinimo.Text.Trim());
            }
            catch
            {
                txtStockMinimo.Text = "";
            }
        }
    }
}
