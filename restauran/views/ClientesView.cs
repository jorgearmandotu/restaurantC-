using restauran.controller;
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
    public partial class ClientesView : Form
    {
        public ClientesView(string ced)
        {
            InitializeComponent();
            txtIdentificacion.Text = ced;
        }

        private void AddCliente(object sender, EventArgs e)
        {
            string tipoId = txtTipoId.Text.Trim();
            string id = txtIdentificacion.Text.Trim();
            string nombre = txtNombre.Text.Trim().ToUpper();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            if(tipoId.Length > 0 && id.Length > 0 && nombre.Length > 0)
            {
                string sql = $"INSERT INTO clientes (tipoId, identificacion, nombre, telefono, email, direccion) " +
                    $"VALUES (@TipoId, @Identificacion, @Nombre, @Telefono, @Email, @Direccion)";
                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    try
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(sql, con);
                        cmd.Parameters.Add("@TipoId", OleDbType.Char).Value = tipoId;
                        cmd.Parameters.Add("txtIdentificacion", OleDbType.Char).Value = id;
                        cmd.Parameters.Add("@Nombre", OleDbType.Char).Value = nombre;
                        cmd.Parameters.Add("@Telefono", OleDbType.Char).Value = telefono;
                        cmd.Parameters.Add("@Email", OleDbType.Char).Value = email;
                        cmd.Parameters.Add("@Direccion", OleDbType.Char).Value = direccion;
                        cmd.ExecuteNonQuery();
                        //con.Close();
                        MessageBox.Show("Transacion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoId.Text = "CC";
                        txtIdentificacion.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";
                        txtDireccion.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
