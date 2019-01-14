using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Personal
    {
        string identificacion;
        string nombre;
        string telefono;
        string email;
        string tipoId;
        string otros;
        DateTime fechaIngreso;
        DateTime fechaRetiro;
        string direccion;
        string causaRetiro;

        public Personal(string identificacion, string nombre, string telefono, string email, 
            string tipoId, string otros, DateTime fechaIngreso, DateTime fechaRetiro, string direccion, 
            string causaRetiro)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Email = email;
            this.TipoId = tipoId;
            this.Otros = otros;
            this.FechaIngreso = fechaIngreso;
            this.FechaRetiro = fechaRetiro;
            this.Direccion = direccion;
            this.CausaRetiro = causaRetiro;
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string TipoId { get => tipoId; set => tipoId = value; }
        public string Otros { get => otros; set => otros = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaRetiro { get => fechaRetiro; set => fechaRetiro = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CausaRetiro { get => causaRetiro; set => causaRetiro = value; }
    }
}
