using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje3
{
    internal class Cliente
    {
        public string Nombre;
        public int Edad;
        public double Precio;
        public Cliente Siguiente;

        public override string ToString()
        {
            return $"{Nombre}, {Edad}, {Precio}";
        }
    }

}
