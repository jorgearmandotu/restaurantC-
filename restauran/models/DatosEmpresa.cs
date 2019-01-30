using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class DatosEmpresa
    {
        string nit;
        string telefono;
        string direccion;
        string piePagina;

        public DatosEmpresa(string nit, string telefono, string direccion, string piePagina)
        {
            this.Nit = nit;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.PiePagina = piePagina;
        }

        public string Nit { get => nit; set => nit = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string PiePagina { get => piePagina; set => piePagina = value; }
    }
}
