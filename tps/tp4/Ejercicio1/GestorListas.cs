using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class GestorListas
    {
        Nodo Cabeza;
        List <string> lista = new List <string> ();

        public void AgregarPaciente(int codigo, string nombre, string apellido, string direccion, string telefono)
        {
            Nodo paciente = new Nodo();
            paciente.Codigo = codigo;
            paciente.Nombre = nombre;
            paciente.Apellido = apellido;
            paciente.Direccion = direccion;
            paciente.Telefono = telefono;

            if (Cabeza == null) 
            {
                Cabeza = paciente;
            }else
            {
                Nodo ultimo = new Nodo();
                ultimo = BuscarUltimo(Cabeza);
                ultimo.Siguiente = paciente;
            }

        }

        public void Eliminar(int posicion) 
        {
            if (Cabeza.Siguiente == null)
            {
                Cabeza = null;
            }else
            {
                if(posicion == 0)
                {
                    Cabeza = Cabeza.Siguiente;
                }else
                {
                    Nodo NodoN = BuscarPosicionAnt(Cabeza, 0, posicion);
                    NodoN.Siguiente = NodoN.Siguiente.Siguiente;
                }
            }
        }

        private Nodo BuscarPosicionAnt(Nodo actual, int n, int pos)
        {
            if(n+1 == pos)
            {
                return actual;
            }else
            {
                return BuscarPosicionAnt(actual.Siguiente, n + 1, pos);
            }
        }

        private Nodo BuscarUltimo(Nodo actual)
        {
            if(actual.Siguiente == null) 
            {
                return actual;
            }else
            {
                return BuscarUltimo(actual.Siguiente);
            }
        }

        public List<string> MostrarLista()
        {
            lista.Clear();
            MostrarListaRecursivo(Cabeza);
            return lista;
        }

        private void MostrarListaRecursivo(Nodo actual)
        {
            if(actual != null)
            {
                lista.Add(actual.ToString());
                MostrarListaRecursivo(actual.Siguiente);
            }
        }

        public void Modificar(int posicion, int codigo, string nombre, string apellido, string direccion, string telefono)
        {
            Nodo mPaciente = BuscarPosicionN(Cabeza, 0, posicion);
            mPaciente.Codigo = codigo;
            mPaciente.Nombre = nombre;
            mPaciente.Apellido = apellido;
            mPaciente.Direccion = direccion;
            mPaciente.Telefono = telefono;
        }
        private Nodo BuscarPosicionN(Nodo actual, int n, int pos)
        {
            if (pos == n)
            {
                return actual;
            }
            else
            {
                return BuscarPosicionN(actual.Siguiente, n + 1, pos);
            }
        }

        public void AgregarSiguiente(int posicion, int codigo, string nombre, string apellido, string direccion, string telefono)
        {
            Nodo paciente = new Nodo();
            paciente.Codigo = codigo;
            paciente.Nombre = nombre;
            paciente.Apellido = apellido;
            paciente.Direccion = direccion;
            paciente.Telefono = telefono;

            if(Cabeza == null)
            {
                Cabeza = paciente;
            }
            else
            {
                if (posicion == 0)
                {
                    paciente.Siguiente = Cabeza;
                    Cabeza = paciente;
                }else
                {
                    Nodo ultimo = new Nodo();
                    ultimo = BuscarPosicionN(Cabeza, 0, posicion);
                    paciente.Siguiente = ultimo.Siguiente;
                    ultimo.Siguiente = paciente;
                }
            }
        }

        

        public int ContarPaciente()
        {
            return lista.Count;
        }
    }
}
