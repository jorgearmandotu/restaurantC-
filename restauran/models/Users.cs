using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    public class Users
    {
        private string usuario;
        private string pasword;
        private bool administrador;

        public Users(string usuario, string pasword, bool administrador)
        {
            this.Usuario = usuario;
            this.Pasword = pasword;
            this.Administrador = administrador;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Pasword { get => pasword; set => pasword = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
    }
}
