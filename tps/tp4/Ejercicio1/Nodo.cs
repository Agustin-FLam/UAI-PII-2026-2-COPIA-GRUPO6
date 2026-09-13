using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Nodo
    {
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Telefono;
        public Nodo Siguiente;

        public override string ToString()
        {
            return $"{Codigo} - {Nombre} - {Apellido}  - {Direccion} - {Telefono}";
        }

    }
}
