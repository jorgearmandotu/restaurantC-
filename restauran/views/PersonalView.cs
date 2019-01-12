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
    public partial class PersonalView : Form
    {
        public PersonalView()
        {
            InitializeComponent();
        }

        private void IngresarPersonal(object sender, EventArgs e)
        {
            
            string tipoId = txtTipoId.Text.Trim().ToUpper();
            string identificacion = txtNumIdentificacion.Text.Trim();
            string name = txtName.Text.Trim().ToUpper();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string otros = txtOtros.Text.Trim();
            string fechaIngreso = dateFechaIngreso.Text.Trim();
            if(tipoId.Length>0 && identificacion.Length>0 && name.Length>0 && fechaIngreso.Length > 0)
            {
                string sql = $"INSERT INTO personal (identificacion, nombre, telefono, email, tipoIdentificacion, " +
                $"otros, fechaIngreso, direccion) VALUES (@id, @name, @phone, " +
                $"@email, @tipoId, @otros, @fechaIngreso, @direccion);";

                using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
                {
                    try
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(sql, con);
                        cmd.Parameters.Add("@id", OleDbType.Char).Value = identificacion;
                        cmd.Parameters.Add("@name", OleDbType.Char).Value = name;
                        cmd.Parameters.Add("@phone", OleDbType.Char).Value = phone;
                        cmd.Parameters.Add("@email", OleDbType.Char).Value = email;
                        cmd.Parameters.Add("@tipoId", OleDbType.Char).Value = tipoId;
                        cmd.Parameters.Add("@otros", OleDbType.Char).Value = otros;
                        cmd.Parameters.Add("@fechaIngreso", OleDbType.Char).Value = fechaIngreso;
                        cmd.Parameters.Add("@direccion", OleDbType.Char).Value = direccion;

                        cmd.ExecuteNonQuery();

                        con.Close();

                        txtDireccion.Text = "";
                        txtEmail.Text = "";
                        txtName.Text = "";
                        txtNumIdentificacion.Text = "";
                        txtOtros.Text = "";
                        txtPhone.Text = "";
                        txtTipoId.Text = "CC";
                        dateFechaIngreso.ResetText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: "+ ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
