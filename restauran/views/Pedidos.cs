using restauran.controller;
using restauran.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauran.views
{
    public partial class Pedidos : Form
    {

        private List<Pedido> listPedidos = new List<Pedido>();
        public Pedidos()
        {
            
            LogIn log = new LogIn();
            InitializeComponent();
            log.ShowDialog();
            loadPlatos();
			loadBebidas();
			loadEspeciales();
			loadOtros();
			consulta();
        }

		private void showProductos(object sender, EventArgs e)
		{
			Productos prod = new Productos();
			prod.ShowDialog();
		}

		private void showInsumos(object sender, EventArgs e)
		{
			Insumos insumo = new Insumos();
			insumo.ShowDialog();
		}

		private void showMesas(object sender, EventArgs e)
		{
			Mesas mesa = new Mesas();
			mesa.ShowDialog();
		}

		private void loadPlatos()
        {
            List<Platos> platos = new List<Platos>();
            Platos p = new Platos("sancocho", 9000);
            platos.Add(p);
            platos.Add(new Platos("arroz de coco", 10000));
            platos.Add(new Platos("pollo asado", 9000));

            foreach ( Platos plato in platos) {
                string[] row = { plato.Nombre, plato.Precio.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewPlatos.Items.Add(listViewItem);
            }
        }

		private void loadBebidas()
		{
			List<Platos> bebidas = new List<Platos>();
			Platos p = new Platos("jugo en agua", 3000);
			bebidas.Add(p);
			bebidas.Add(new Platos("jugo en leche", 3500));
			bebidas.Add(new Platos("cerveza poker", 3500));

			foreach (Platos plato in bebidas)
			{
				string[] row = { plato.Nombre, plato.Precio.ToString() };
				var listViewItem = new ListViewItem(row);
				listViewBebidas.Items.Add(listViewItem);
			}
		}

		private void loadEspeciales()
		{
			List<Platos> especiales = new List<Platos>();
			Platos p = new Platos("sancocho de bagre", 12000);
			especiales.Add(p);
			especiales.Add(new Platos("cangrejo asado", 15000));
			especiales.Add(new Platos("concha sudada", 11000));

			foreach (Platos plato in especiales)
			{
				string[] row = { plato.Nombre, plato.Precio.ToString() };
				var listViewItem = new ListViewItem(row);
				listViewEspeciales.Items.Add(listViewItem);
			}
		}

		private void loadOtros()
		{
			List<Platos> otros = new List<Platos>();
			Platos p = new Platos("baso de agua", 12000);
			otros.Add(p);
			otros.Add(new Platos("helado caliente", 15000));
			otros.Add(new Platos("wafless y crepes", 11000));

			foreach (Platos plato in otros)
			{
				string[] row = { plato.Nombre, plato.Precio.ToString() };
				var listViewItem = new ListViewItem(row);
				listViewOtros.Items.Add(listViewItem);
			}
		}

		private void listPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			if (listViewPlatos.SelectedItems == null)
             {
                 MessageBox.Show("no selecciono nada");
             }else
             {
				int idPedido = cmbMesa.SelectedIndex;
				//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
				string namePedido = listViewPlatos.SelectedItems[0].Text;
                string prec = listViewPlatos.SelectedItems[0].SubItems[1].Text;
                decimal precio = Decimal.Parse( prec );
                int cantidad = 1;
                if (listPedidos.Count < 1)
                {
                    listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
                }
                else
                {
                    Pedido pedidoExistente = listPedidos.Find(y => y.Name == namePedido && y.Id==idPedido);
                    if (pedidoExistente != null)
                    {
                        pedidoExistente.Cantidad += 1;
                    }
                    else
                    {
                        listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
                    }
                }
                listViewPedido.Items.Clear();
				cargarPedido();
             }
            
        }

		private void listBebidas_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listViewBebidas.SelectedItems == null)
			{
				MessageBox.Show("no selecciono nada");
			}
			else
			{
				int idPedido = cmbMesa.SelectedIndex;
				//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
				string namePedido = listViewBebidas.SelectedItems[0].Text;
				string prec = listViewBebidas.SelectedItems[0].SubItems[1].Text;
				decimal precio = Decimal.Parse(prec);
				int cantidad = 1;
				if (listPedidos.Count < 1)
				{
					listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
				}
				else
				{
					Pedido pedidoExistente = listPedidos.Find(y => y.Name == namePedido && y.Id == idPedido);
					if (pedidoExistente != null)
					{
						pedidoExistente.Cantidad += 1;
					}
					else
					{
						listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
					}
				}
				listViewPedido.Items.Clear();
				cargarPedido();
			}

		}

		private void listEspeciales_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listViewEspeciales.SelectedItems == null)
			{
				MessageBox.Show("no selecciono nada");
			}
			else
			{
				//MessageBox.Show(sender.ToString());
				int idPedido = cmbMesa.SelectedIndex;
				//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
				string namePedido = listViewEspeciales.SelectedItems[0].Text;
				string prec = listViewEspeciales.SelectedItems[0].SubItems[1].Text;
				decimal precio = Decimal.Parse(prec);
				int cantidad = 1;
				if (listPedidos.Count < 1)
				{
					listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
				}
				else
				{
					Pedido pedidoExistente = listPedidos.Find(y => y.Name == namePedido && y.Id == idPedido);
					if (pedidoExistente != null)
					{
						pedidoExistente.Cantidad += 1;
					}
					else
					{
						listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
					}
				}
				listViewPedido.Items.Clear();
				cargarPedido();
			}

		}

		private void listOtros_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listViewOtros.SelectedItems == null)
			{
				MessageBox.Show("no selecciono nada");
			}
			else
			{
				int idPedido = cmbMesa.SelectedIndex;
				//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
				string namePedido = listViewOtros.SelectedItems[0].Text;
				string prec = listViewOtros.SelectedItems[0].SubItems[1].Text;
				decimal precio = Decimal.Parse(prec);
				int cantidad = 1;
				if (listPedidos.Count < 1)
				{
					listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
				}
				else
				{
					Pedido pedidoExistente = listPedidos.Find(y => y.Name == namePedido && y.Id == idPedido);
					if (pedidoExistente != null)
					{
						pedidoExistente.Cantidad += 1;
					}
					else
					{
						listPedidos.Add(new Pedido(idPedido, namePedido, cantidad, precio));
					}
				}
				listViewPedido.Items.Clear();
				cargarPedido();
			}

		}


        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
			//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
			listViewPedido.Items.Clear();
			cargarPedido();
            if(cmbMesa.SelectedIndex >= 0)
            {
                listViewPlatos.Enabled = true;
                listViewBebidas.Enabled = true;
                listViewEspeciales.Enabled = true;
                listViewOtros.Enabled = true;
                
            }else
            {
                listViewPlatos.Enabled = false;
                listViewBebidas.Enabled = false;
                listViewEspeciales.Enabled = false;
                listViewOtros.Enabled = false;
            }

        }

		private void cargarPedido()
		{
			Decimal vlrPagar = 0;
			foreach (Pedido ped in listPedidos)
			{
				if (ped.Id == cmbMesa.SelectedIndex)
				{
					//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
					string[] row = { ped.Name, ped.Precio.ToString(), ped.Cantidad.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewPedido.Items.Add(listViewItem);
					vlrPagar += ped.Cantidad*ped.Precio;
				}
			}
			lblValorPagar.Text = String.Format("{0:C}",vlrPagar);
			decimal impConsumo = 0.08m;
			decimal imp = vlrPagar * impConsumo;
			lblImpConsumo.Text = String.Format("{0:C}",imp);
		}

		private void listViewPedido_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(listViewPedido.SelectedItems != null)
			{
				string namePedido = listViewPedido.SelectedItems[0].Text;
				int idPedido = cmbMesa.SelectedIndex;
				Pedido pedidoselect = listPedidos.Find(y => y.Name == namePedido && y.Id == idPedido);
				if (pedidoselect != null)
				{
					if (pedidoselect.Cantidad > 1)
					{
						pedidoselect.Cantidad -= 1;
					}
					else
					{
						listPedidos.Remove(pedidoselect);
					}
					listViewPedido.Items.Clear();
					cargarPedido();   
				}
			}
		}

		private void consulta()
		{
			/*using (SqlConnection con1 = new SqlConnection(DataAcces.conection))
			{
				con1.Open();
				SqlCommand cmd = new SqlCommand("select * from insumos", con1);
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Console.WriteLine(Convert.ToString(dr["insumo"]));
				}
				con1.Close();
			}*/
			using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
			{
				con.Open();
				OleDbCommand cmd = new OleDbCommand("Select * From insumos", con);
				OleDbDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					Console.WriteLine(Convert.ToString(dr["insumo"]));

				}
				con.Close();
			}
		}
	}
}
