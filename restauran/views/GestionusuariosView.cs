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
    public partial class GestionusuariosView : Form
    {
        private Users usuarioLog = null;
        public GestionusuariosView(Users user)
        {
            InitializeComponent();
            usuarioLog = user;
            LoadUsers();
        }
        private void LoadUsers()
        {
            string sql = string.Format($"SELECT usuario FROM users WHERE usuario <> '{usuarioLog.Usuario}'");
            DataSet ds = DataAplication.Execute(sql);
            if(ds.Tables.Count > 0)
            {
                cmbUserDelete.DataSource = ds.Tables[0];
                cmbUserDelete.DisplayMember = ds.Tables[0].Columns["usuario"].ToString();
            }
        }

        private void AddUser(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
            string passwordRepeat = txtRepitPassword.Text.Trim();
            bool admin = checkBoxAdministrador.Checked;
            if (password != passwordRepeat)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(password.Length >= 5 && usuario.Length>0)
            {
                Helpper help = new Helpper();
                password = help.EncriptPwd(password);
                string sql = String.Format($"INSERT INTO users (usuario, [password], administrador) VALUES ('{usuario}', '{password}', {admin});");
                string[] data = {usuario, password, admin.ToString()};
                if(DataAplication.InsertData(sql))
                {
                    MessageBox.Show("Transaccion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtRepitPassword.Text = "";
                    checkBoxAdministrador.Checked = false;
                    txtUsuario.Text = "";
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operacion", "Upss!. Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("La contraseña debe contener al menos 5 carateres y el campo usuario no puede estar vacio",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DelUser(object sender, EventArgs e)
        {
            string usuarioDel = cmbUserDelete.Text.Trim();
            string usuario = txtUserValid.Text.Trim();
            string password = txtPasswordValid.Text.Trim();
            if (usuarioDel.Length<=0 || usuario.Length<=0 || password.Length<=0)
            {
                MessageBox.Show("Todos los campos deben estar llenos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(usuario == usuarioLog.Usuario)
            {
                if (VerifiquePass(password, usuario))
                {
                    string sql = string.Format($"delete from users where usuario = '{usuarioDel}'");
                    DataAplication.Execute(sql);
                    txtUserValid.Text = "";
                    txtPasswordValid.Text = "";
                    LoadUsers();
                    //cmbUserDelete.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("contraseña Incorrecta", "Upps!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("solo el usuario logueado puede realizar esta accion", "Upps!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool VerifiquePass(string pwd, string user)
        {
            bool res = false;
            string sql = string.Format($"SELECT * FROM users WHERE usuario = '{user}'");
            DataSet ds = DataAplication.Execute(sql);
            if(ds.Tables.Count > 0)
            {
                Helpper help = new Helpper();
                res = help.ComparePwd(pwd, ds.Tables[0].Rows[0]["password"].ToString());
            }
            return res;
        }
    }
}
