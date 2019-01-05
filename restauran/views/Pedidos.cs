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
        

        public Pedidos()
        {
            
            LogIn log = new LogIn();
            InitializeComponent();
            log.ShowDialog();
            colection();
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
        private void colection()
        {
            //Pedido pedido = new Pedido();
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
                //MessageBox.Show("selecciono "+listPlatos.SelectedItem.ToString());
                //listBebidas.Items.Add(listPlatos.SelectedItem);
                List<Pedido> listpedidos = new List<Pedido>();
                int idPedido = cmbMesa.SelectedIndex;
                string namePedido = listViewPlatos.SelectedItems[0].Text;
                string precioPedido = listViewPlatos.SelectedItems[0].SubItems[1].Text;
                

                 string[] row = { listViewPlatos.SelectedItems[0].Text, listViewPlatos.SelectedItems[0].SubItems[1].Text };
                 var listViewItem = new ListViewItem(row);
                 listViewPedido.Items.Add(listViewItem);
             }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
