using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje3
{
    internal class GestorClientes
    {
       public List<string> Lista = new List<string>();
       Cliente cabeza;
        //Mostrar Lista

        public List<string> MostrarLista()
        {
            Lista.Clear();
            MostrarListaRecursivo(cabeza);
            return Lista;
        }

        public void MostrarListaRecursivo(Cliente actual)
        {
            if (actual != null) 
            {
                Lista.Add(actual.ToString());
                MostrarListaRecursivo(actual.Siguiente);
            }
            
        }
       public void Agregar(string nombre, int edad, double precio)
        {
            Cliente persona = new Cliente();
            persona.Nombre = nombre;
            persona.Edad = edad;
            persona.Precio = precio;

            if (cabeza == null)
            {
                cabeza = persona;
            }else
            {
                Cliente ultimo = BuscarUltimo(cabeza);
                ultimo.Siguiente = persona;
            }
        }

        public void Eliminar(int pos)
        {
            if(cabeza.Siguiente == null)
            {
                cabeza = null;
            }else if (pos == 0)
            {
                cabeza = cabeza.Siguiente;
            }else
            {
                Cliente anterior = BuscarPosicionAnt(cabeza, 0, pos);
                anterior.Siguiente = anterior.Siguiente.Siguiente;
            }
        }

        public void Modificar(int pos, string nombre, int edad, double precio)
        {
            Cliente mPersona = BuscarPosicionN(cabeza, 0, pos);
            mPersona.Nombre = nombre;
            mPersona.Edad = edad;
            mPersona.Precio = precio;
        }

        public void agregarSiguiente(int pos, string nombre, int edad, double precio)
        {
            Cliente persona = new Cliente();
            persona.Nombre = nombre;
            persona.Edad = edad;
            persona.Precio = precio;

            Cliente actual = BuscarPosicionN(cabeza, 0, pos);
            persona.Siguiente = actual.Siguiente;
            actual.Siguiente = persona;
        }
        //Busqueda

        private Cliente BuscarUltimo(Cliente actual)
        {
            if(actual.Siguiente == null)
            {
                return actual;
            }else
            {
                return BuscarUltimo(actual.Siguiente);
            }
        }

        private Cliente BuscarPosicionAnt(Cliente actual, int n, int pos)
        {

            if (n + 1 == pos)
            {
                return actual;
            }
            else
            {
                return BuscarPosicionAnt(actual.Siguiente, n + 1, pos);
            }
        }

        private Cliente BuscarPosicionN(Cliente actual, int n, int pos)
        {
            if(n == pos)
            {
                return actual;
            }else
            {
                return BuscarPosicionN(actual.Siguiente, n + 1, pos);
            }
        }
    }
}
