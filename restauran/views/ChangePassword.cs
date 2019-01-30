using restauran.controller;
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
    public partial class ChangePassword : Form
    {
        private string pwd = "";
        private int id = 0;
        public ChangePassword(Users user)
        {
            InitializeComponent();
            LoadData(user);
        }

        private void LoadData(Users user)
        {
            string sql = $"SELECT * FROM users WHERE usuario = '{user.Usuario}';";
            DataSet ds = DataAplication.Execute(sql);
            if(ds.Tables.Count > 0)
            {
                pwd = ds.Tables[0].Rows[0]["password"].ToString();
                txtUser.Text = ds.Tables[0].Rows[0]["usuario"].ToString();
                id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
            }
        }

        private void UpdateData(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta accion cerrara la aplicacion para tener efecto. Desea continuar","Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialog == DialogResult.Yes)
            {
                string user = txtUser.Text.Trim().ToUpper();
                string password = txtPassword.Text.Trim();
                string newPass = txtNesPassword.Text.Trim();
                string repPass = txtRepPassword.Text.Trim();
                if (user.Length > 0 && password.Length > 0 && newPass.Length > 0)
                {
                    if (newPass == repPass)
                    {
                        Helpper help = new Helpper();
                        if (help.ComparePwd(password, pwd))
                        {
                            newPass = help.EncriptPwd(newPass);
                            string sql = $"UPDATE users SET usuario = '{user}', [password] = '{newPass}' WHERE Id = {id};";
                            //string[] arr = { user, newPass };
                            if (DataAplication.InsertData(sql))
                            {
                                MessageBox.Show("transaccion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("La aplicacion se cerrara para q los cambios tengan efecto");
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show("Se produjo un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña ingresada no es valida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas deben coincidir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
