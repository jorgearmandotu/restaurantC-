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
		List<Platos> platos = new List<Platos>();
		public Pedidos()
        {
            
            //LogIn log = new LogIn();
            InitializeComponent();
            //log.ShowDialog();
            LoadPlatos();
			consulta();
            LoadMesas();
            LoadMeseros();
        }

		private void ShowProductos(object sender, EventArgs e)
		{
			Productos prod = new Productos();
			prod.ShowDialog();
			LoadPlatos();
		}

		private void ShowInsumos(object sender, EventArgs e)
		{
			Insumos insumo = new Insumos();
			insumo.ShowDialog();
		}

		private void ShowMesas(object sender, EventArgs e)
		{
			Mesas mesa = new Mesas();
			mesa.ShowDialog();
            LoadMesas();
		}

		private void LoadPlatos()
        {
			platos.Clear();
			listViewPlatos.Items.Clear();
			listViewBebidas.Items.Clear();
			listViewEspeciales.Items.Clear();
			listViewOtros.Items.Clear();
			using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
			{
				con.Open();
				OleDbCommand cmd = new OleDbCommand("Select * From platos", con);
				OleDbDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					//ingredientes.Add(Convert.ToString(dr["insumo"]));
					int id = Convert.ToInt32(dr["id"]);
					string plato = Convert.ToString(dr["plato"]);
					decimal precio = Convert.ToDecimal(dr["precio"]);
					string image = Convert.ToString(dr["image"]);
					int categoria = Convert.ToInt32(dr["categoria"]);
					platos.Add(new Platos(id, plato, precio, image, categoria));

				}
				con.Close();
			}

			foreach ( Platos plato in platos) {
				if(plato.Categoria == 1)
				{
					string[] row = { plato.Nombre, plato.Precio.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewPlatos.Items.Add(listViewItem);
				}else if (plato.Categoria == 2)
				{
					string[] row = { plato.Nombre, plato.Precio.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewBebidas.Items.Add(listViewItem);
				}else if (plato.Categoria == 3)
				{
					string[] row = { plato.Nombre, plato.Precio.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewEspeciales.Items.Add(listViewItem);
				}
				else
				{
					string[] row = { plato.Nombre, plato.Precio.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewOtros.Items.Add(listViewItem);
				}
            }
        }

		private void ListPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
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
				CargarPedido();
             }
            
        }

		private void ListBebidas_MouseDoubleClick(object sender, MouseEventArgs e)
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
				CargarPedido();
			}

		}

		private void ListEspeciales_MouseDoubleClick(object sender, MouseEventArgs e)
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
				CargarPedido();
			}

		}

		private void ListOtros_MouseDoubleClick(object sender, MouseEventArgs e)
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
				CargarPedido();
			}

		}


        private void CmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
			//MessageBox.Show(cmbMesa.SelectedIndex.ToString());
			listViewPedido.Items.Clear();
			CargarPedido();
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

		private void CargarPedido()
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

		private void ListViewPedido_MouseDoubleClick(object sender, MouseEventArgs e)
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
					CargarPedido();   
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

        private void LoadMesas()
        {
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * From mesas", con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    cmbMesa.Items.Clear();
                    while (dr.Read())
                    {
                        //Console.WriteLine(Convert.ToString(dr["nombre"]));
                        cmbMesa.Items.Add(Convert.ToString(dr["nombre"]));

                    }
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LoadMeseros()
        {
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * From personal", con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    cmbMesero.Items.Clear();
                    while (dr.Read())
                    {
                        //Console.WriteLine(Convert.ToString(dr["nombre"]));
                        cmbMesero.Items.Add(Convert.ToString(dr["nombre"]));

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void GestionPersonal(object sender, EventArgs e)
        {
            PersonalView persona = new PersonalView();
            persona.ShowDialog();
            LoadMeseros();
        }

        private void GestionInsumos(object sender, EventArgs e)
        {
            EntradasView gestion = new EntradasView();
            gestion.ShowDialog();
        }
    }
}
