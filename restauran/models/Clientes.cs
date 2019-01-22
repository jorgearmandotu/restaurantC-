using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    public class Clientes
    {
        private int id;
        private string nombre;
        private string identificacion;
        private string tipoIdentificacion;
        private string telefonoo;
        private string email;
        private string direccion;
        //private List<Pedido> pedido;

        public Clientes(int id, string nombre, string identificacion, string tipoIdentificacion, string telefonoo, string email, string direccion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Identificacion = identificacion;
            this.TipoIdentificacion = tipoIdentificacion;
            this.Telefonoo = telefonoo;
            this.Email = email;
            this.Direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string TipoIdentificacion { get => tipoIdentificacion; set => tipoIdentificacion = value; }
        public string Telefonoo { get => telefonoo; set => telefonoo = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }
        //internal List<Pedido> Pedido { get => pedido; set => pedido = value; }
    }
}
