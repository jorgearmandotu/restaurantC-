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
        private static Users usuario = null;
        private List<Pedido> listPedidos = new List<Pedido>();
		private List<Platos> listPlatos = new List<Platos>();
        private List<Clientes> listClientes = new List<Clientes>();
		public Pedidos(Users user)
        {
            usuario = user;
            //LogIn log = new LogIn();
            InitializeComponent();
            //log.ShowDialog();
            LoadPlatos();
			Consulta();
            LoadMesas();
            LoadMeseros();
            LoadClientes();
            LoadModoPago();
            cmbFormaPago.SelectedIndex = 0;
            if (user.Administrador)
            {
                toolStripPersonal.Enabled = true;
                toolStripPersonal.Visible = true;
                toolStripSettings.Enabled = true;
                toolStripSettings.Visible = true;
                toolStripInventario.Enabled = true;
                toolStripInventario.Visible = true;
                //toolStripSeparatorInventario.Visible = true;
            }
            else
            {

            }
        }

        private void LoadModoPago()
        {
            string sql = "SELECT * FROM medioPago";
            DataSet ds = DataAplication.Execute(sql);
            /*foreach (DataRow rows in ds.Tables[0].Rows)
            {
                cmbFormaPago.Items.Add(rows["namePago"].ToString());
            }*/
            cmbFormaPago.DataSource = ds.Tables[0];
            cmbFormaPago.DisplayMember = ds.Tables[0].Columns["namePago"].ToString();
            cmbFormaPago.ValueMember = ds.Tables[0].Columns["Id"].ToString();
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
            cmbMesa.SelectedIndex = 0;
		}

		private void LoadPlatos()
        {
			listPlatos.Clear();
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
					listPlatos .Add(new Platos(id, plato, precio, image, categoria));

				}
				con.Close();
			}

			foreach ( Platos plato in listPlatos) {
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
                    Pedido pedidoExistente = listPedidos.Find(y => y.Producto == namePedido && y.Id==idPedido);
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
					Pedido pedidoExistente = listPedidos.Find(y => y.Producto == namePedido && y.Id == idPedido);
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
					Pedido pedidoExistente = listPedidos.Find(y => y.Producto == namePedido && y.Id == idPedido);
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
					Pedido pedidoExistente = listPedidos.Find(y => y.Producto == namePedido && y.Id == idPedido);
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
            if(cmbMesa.SelectedIndex >= 0 && cmbMesero.SelectedIndex >= 0)
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
					string[] row = { ped.Producto, ped.Vlr_Unit.ToString(), ped.Cantidad.ToString() };
					var listViewItem = new ListViewItem(row);
					listViewPedido.Items.Add(listViewItem);
					vlrPagar += ped.Cantidad*ped.Vlr_Unit;
				}
			}
			lblValorPagar.Text = String.Format("{0:C}",vlrPagar);
            decimal impConsumo = Properties.Settings.Default.ImpuestoConsumo;
			decimal imp = vlrPagar * impConsumo;
			lblImpConsumo.Text = String.Format("{0:C}",imp);
		}

		private void ListViewPedido_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(listViewPedido.SelectedItems != null)
			{
				string namePedido = listViewPedido.SelectedItems[0].Text;
				int idPedido = cmbMesa.SelectedIndex;
				Pedido pedidoselect = listPedidos.Find(y => y.Producto == namePedido && y.Id == idPedido);
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

		private void Consulta()
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
                    MessageBox.Show("Error: "+ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LoadMeseros()
        {
            /*using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
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
                    MessageBox.Show("Error: "+ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
            try
            {
                string sql = "Select * From personal";
                DataSet ds = DataAplication.Execute(sql);
                cmbMesero.DataSource = ds.Tables[0];
                cmbMesero.DisplayMember = ds.Tables[0].Columns["nombre"].ToString();
                cmbMesero.ValueMember = ds.Tables[0].Columns["Id"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SettingsShow(object sender, EventArgs e)
        {
            SettingsView setting = new SettingsView();
            setting.ShowDialog();
        }

        private void SelectedChangedCommitCmbMesero(object sender, EventArgs e)
        {
            if (cmbMesa.SelectedIndex >= 0 && cmbMesero.SelectedIndex >= 0)
            {
                listViewPlatos.Enabled = true;
                listViewBebidas.Enabled = true;
                listViewEspeciales.Enabled = true;
                listViewOtros.Enabled = true;
            }
            else
            {
                listViewPlatos.Enabled = false;
                listViewBebidas.Enabled = false;
                listViewEspeciales.Enabled = false;
                listViewOtros.Enabled = false;
            }
        }

        private void ClientesShow(object sender, EventArgs e)
        {
            ClientesView clientes = new ClientesView("");
            clientes.ShowDialog();
            LoadClientes();
        }

        private void LoadClientes()
        {
            string sql = "SELECT * FROM clientes";
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    listClientes.Clear();
                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["Id"]);
                        string name = dr["nombre"].ToString();
                        string identificacion = dr["identificacion"].ToString();
                        string tipoId = dr["tipoId"].ToString();
                        string telefono = dr["telefono"].ToString();
                        string email = dr["email"].ToString();
                        string direccion = dr["direccion"].ToString();
                        listClientes.Add(new Clientes(id, name, identificacion, tipoId, telefono, email, direccion));
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FacturarPedido(object sender, EventArgs e)
        {
            //listPedido //restar a insumos las recetas
            string idCliente = txtIdCliente.Text.Trim();
            DateTime fecha = DateTime.Now;
            Clientes cliente = listClientes.Find(x => x.Identificacion == idCliente);
            string mesero = cmbMesero.Text;
            string formaPago = cmbFormaPago.Text;
            string idFormaPago = cmbFormaPago.SelectedValue.ToString();
            int idPedio = cmbMesa.SelectedIndex;
            string vlrImpConsumo = lblImpConsumo.Text;
            string vlrPagar = lblValorPagar.Text;
            if (cliente != null)
            {
                Factura factura = new Factura(fecha, cliente.Nombre, cliente.Identificacion, cliente.Direccion,
                    mesero, formaPago, vlrImpConsumo, vlrPagar);
                List<Pedido> pedido = new List<Pedido>();
                foreach (Pedido p in listPedidos)
                {
                    if(p.Id == idPedio)
                    {
                        pedido.Add(p);
                    }
                }
                FacturacionView reporteFactura = new FacturacionView(factura, pedido, cliente, idFormaPago);
                reporteFactura.ShowDialog();
                RestarInsumos();
            }
            else
            {
                MessageBox.Show("Debe Ingresar al cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              /*  Factura factura = new Factura(fecha, "", idCliente, "", mesero, formaPago, vlrImpConsumo, vlrPagar);
                FacturacionView reporteFactura = new FacturacionView(factura, listPedidos);
                reporteFactura.ShowDialog();
                RestarInsumos();*/
            }
            LoadClientes();
        }

        private void RestarInsumos()
        {
            int idPedido = cmbMesa.SelectedIndex;
            foreach (Pedido pedido in listPedidos)
            {
                if(pedido.Id == cmbMesa.SelectedIndex)
                {
                    string plato = pedido.Producto;
                    int cantidadPedido = pedido.Cantidad;
                    decimal precio = pedido.Vlr_Unit;
                    Platos platoSelect = listPlatos.Find(x => x.Nombre == plato);
                    //consultar receta// restar a insumos
                    if(platoSelect != null)
                    {
                        string sqlReceta = $"SELECT * FROM recetas WHERE plato = {platoSelect.Id} ";
                        // while => restar cantidad a insumo
                        using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                        {
                            try
                            {
                                con.Open();
                                OleDbCommand cmd = new OleDbCommand(sqlReceta, con);
                                OleDbDataReader dr = cmd.ExecuteReader();
                                listClientes.Clear();
                                while (dr.Read())
                                {
                                    string platoReceta = dr["plato"].ToString();
                                    string insumo = dr["insumo"].ToString();
                                    int cantidadInsumo = Convert.ToInt32(dr["cantidad"])*cantidadPedido;

                                    string sqlInsumo = $"UPDATE  insumos SET stock= (stock - {cantidadInsumo} )  WHERE id = {insumo};";
                                    OleDbCommand cmd2 = new OleDbCommand(sqlInsumo, con);
                                    cmd2.ExecuteNonQuery();
                                }
                                con.Close();
                                
                            }catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }   }

                }
                
            }
            listPedidos.RemoveAll(x => x.Id == idPedido);
            listViewPedido.Items.Clear();
            txtIdCliente.Text = "";
            lblNameCliente.Text = "";
            cmbFormaPago.SelectedIndex = 0;
        }
        private void ValidCliente(object sender, EventArgs e)
        {
            ValidCliente();
        }

        private void ValidClienteEnter(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValidCliente();
            }
        }

        private void ValidCliente()
        {
            string id = txtIdCliente.Text.Trim();
            Clientes cliente = listClientes.Find(x => x.Identificacion == id);
            if (cliente != null)
            {
                lblNameCliente.Text = cliente.Nombre;
            }
            else
            {
                lblNameCliente.Text = "";
            }
        }

        private void AddCliente(object sender, EventArgs e)
        {
            string id = txtIdCliente.Text.Trim();
            ClientesView cliente = new ClientesView(id);
            cliente.ShowDialog();
            LoadClientes();
            ValidCliente();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showUsers(object sender, EventArgs e)
        {
            //ventana usuarios
            GestionusuariosView userGestion = new GestionusuariosView(usuario);
            {
                userGestion.ShowDialog();
            }
        }
    }
}