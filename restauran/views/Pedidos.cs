using restauran.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void mesa2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void listPlatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             if (listViewPlatos.SelectedItems == null)
             {
                 MessageBox.Show("no selecciono nada");
             }else
             {
                int idPedido = cmbMesa.SelectedIndex;
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
                    Pedido pedidoExistente = listPedidos.Find(y => y.Name == namePedido);
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
                 foreach(Pedido ped in listPedidos)
                {
                    if(ped.Id == cmbMesa.SelectedIndex)
                    {
                        MessageBox.Show(cmbMesa.SelectedIndex.ToString());
                        string[] row = { ped.Name, ped.Precio.ToString(), ped.Cantidad.ToString() };
                        var listViewItem = new ListViewItem(row);
                        listViewPedido.Items.Add(listViewItem);
                    }
                }
             }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
