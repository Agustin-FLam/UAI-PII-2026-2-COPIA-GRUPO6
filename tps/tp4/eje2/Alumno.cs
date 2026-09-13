using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje2
{
    internal class Alumno
    {
        public string Nombre;
        public string Apellido;
        public int DNI;
        public string FechaNacimiento;
        public string Direccion;
        public string Telefono;
        public Alumno Siguiente;

        public override string ToString()
        {
            return $"{Nombre} - {Apellido} - {DNI} - {FechaNacimiento} - {Direccion} - {Telefono}";
        }
    }

    
}
