using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Platos
    {
        //private int id;
        private string nombre;
        private float precio;

        public Platos(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            //this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        //public int Id { get => id; set => id = value; }

    }
}
