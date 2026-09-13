using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje2
{
    internal class GestorAlumno
    {
        public List<string> Lista = new List<string>();
        Alumno cabeza;
        
        public List<string> MostrarLista()
        {
            Lista.Clear();
            MostrarListaRecursivo(cabeza);
            return Lista;
        }

        private void MostrarListaRecursivo(Alumno actual)
        {
            if (actual != null) 
            {
                Lista.Add(actual.ToString());
                MostrarListaRecursivo(actual.Siguiente);
            }
        }         
        public void AgregarAlumno(string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            Alumno persona = new Alumno();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.DNI = dni;
            persona.FechaNacimiento = fechaNacimiento;
            persona.Direccion = direccion;
            persona.Telefono = telefono;

            if (cabeza == null) 
            {
                cabeza = persona;
            }
            else
            {
                Alumno ultimo = new Alumno();
                ultimo = BuscarUltimo(cabeza);
                ultimo.Siguiente = persona;
            }
        }

        public void EliminarAlumno(int pos)
        {
            if(cabeza.Siguiente == null)
            {
                cabeza = null;
            }
            else
            {
                if(pos == 0)
                {
                    cabeza = cabeza.Siguiente;
                }else
                {
                    Alumno seleccion = BuscarPosicionAnt(cabeza, 0, pos);
                    seleccion.Siguiente = seleccion.Siguiente.Siguiente;
                }
            }
        }

        public void Modificar(int pos, string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            Alumno mPersona = BuscarPosicionN(cabeza, 0, pos);
            mPersona.Nombre = nombre;
            mPersona.Apellido = apellido;
            mPersona.DNI = dni;
            mPersona.FechaNacimiento = fechaNacimiento;
            mPersona.Direccion = direccion;
            mPersona.Telefono = telefono;

        }

        public void AgregarSiguiente(int pos, string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            
            Alumno persona = new Alumno();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.DNI = dni;
            persona.FechaNacimiento = fechaNacimiento;
            persona.Direccion = direccion;
            persona.Telefono = telefono;

            if(cabeza == null)
            {
                cabeza = persona;
            }
            
            else
            {
                Alumno actual = BuscarPosicionN(cabeza, 0, pos);
                persona.Siguiente = actual.Siguiente;
                actual.Siguiente = persona;
            }

        }

        public void AgregarAnterior(int pos, string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            Alumno persona = new Alumno();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.DNI = dni;
            persona.FechaNacimiento = fechaNacimiento;
            persona.Direccion = direccion;
            persona.Telefono = telefono;

            if (cabeza == null) 
            {
                cabeza = persona;
            }else if(pos == 0)
            {
                persona.Siguiente = cabeza;
                cabeza = persona;
            }else 
            {
                Alumno anterior = BuscarPosicionAnt(cabeza, 0, pos);
                persona.Siguiente = anterior.Siguiente;
                anterior.Siguiente = persona;

            }
        }
       
        private Alumno BuscarUltimo(Alumno nuevo)
        {
            if(nuevo.Siguiente == null)
            {
                return nuevo;
            }else
            {
                return BuscarUltimo(nuevo.Siguiente);
            }
        }

        private Alumno BuscarPosicionAnt(Alumno Actual, int n, int pos)
        {
            if(n+1 == pos)
            {
                return Actual;
            }else
            {
                return BuscarPosicionAnt(Actual.Siguiente, n + 1, pos);
            }
        }

        private Alumno BuscarPosicionN(Alumno Actual, int n, int pos)
        {
            if(pos == 0)
            {
                return Actual;
            }else
            {
                return BuscarPosicionN(Actual.Siguiente, n+1, pos);
            }
        }
    }
}
