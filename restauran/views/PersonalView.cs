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
    public partial class PersonalView : Form
    {
        List<Personal> personal = new List<Personal>();
        public PersonalView()
        {
            InitializeComponent();
            LoadCmbPersonal();
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
            if (tipoId.Length > 0 && identificacion.Length > 0 && name.Length > 0 && fechaIngreso.Length > 0)
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
                        MessageBox.Show("Error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RetirarPersonal(object sender, EventArgs e)
        {
            string id = txtCCDel.Text;
            string motivo = txtMotivoRetiro.Text;
            Personal persona = personal.Find(x => x.Identificacion == id);
            if(persona != null)
            {
                string sql = "DElETE FROM personal WHERE identificacion = "+persona.Identificacion;
            }
        }

        private void LoadCmbPersonal()
        {
            string sql = "select * from personal";
            using (OleDbConnection con = new OleDbConnection(DataAcces.conection))
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    cmbNombre.Items.Clear();
                    while (dr.Read())
                    {
                        string id = Convert.ToString(dr["identificacion"]);
                        string nombre = Convert.ToString(dr["nombre"]);
                        string telefono = Convert.ToString(dr["telefono"]);
                        string email = Convert.ToString(dr["email"]);
                        string tipoId = Convert.ToString(dr["tipoIdentificacion"]);
                        string direccion = "";
                        DateTime fechaRetiro = DateTime.Now;
                        string otros = "";
                        string causaRetiro = "";
                        if (dr["otros"].ToString() != "")
                        {
                            otros = Convert.ToString(dr["otros"]);
                        }
                        DateTime fechaIngreso = Convert.ToDateTime(dr["fechaIngreso"]);
                        if (dr["fechaRetiro"].ToString() != "")
                        {
                            fechaRetiro = Convert.ToDateTime(dr["fechaRetiro"]);
                        }
                        if(dr["direccion"].ToString() != "")
                        {
                            direccion = Convert.ToString(dr["direccion"]);
                        }
                        if (dr["causaRetiro"].ToString() != "")
                        {
                            causaRetiro = Convert.ToString(dr["causaRetiro"]);
                        }
                        personal.Add(new Personal(id, nombre, telefono, email, tipoId, otros, 
                            fechaIngreso, fechaRetiro, direccion, causaRetiro));
                        //cmbNombre.Items.Add(Convert.ToString(dr["nombre"]));
                    }
                    con.Close();
                    foreach(Personal p in personal)
                    {
                        
                        cmbNombre.DisplayMember = p.Nombre;
                        cmbNombre.ValueMember = p.Identificacion;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
