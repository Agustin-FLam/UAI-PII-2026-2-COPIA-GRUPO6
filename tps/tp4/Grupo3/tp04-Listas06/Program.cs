using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ejercicio 6:
 Un cine pequeño nos propone hacer una aplicación para controlar las personas que ingresan
 al mismo, para los grandes estrenos de películas.
 Un conjunto de personas esperará para sacar una entrada, calculando el precio según la edad
 de la persona (mínimo 5 años). Las edades se generan aleatoriamente entre 5 y 60 años.
 Al final, se debe mostrar la cantidad total recaudada. El número de personas de la lista
 se elige al azar entre 0 y 50.
 Además, se debe permitir:
 a. Registrar las nuevas personas que ingresan a la lista
 b. Eliminar a la persona que se va de la lista (en cualquier posición)
 c. Actualizar los datos de la persona (modificar algún dato)
 d. Mostrar Listado de las personas
 */
namespace tp04_listas06
{
    public class NodoSimple
    {
        public int Codigo;      // identificador único de la persona en la lista
        public int Edad;
        public double PrecioEntrada;
        public NodoSimple Siguiente;

        public override string ToString()
        {
            return string.Format("Codigo: {0}, Edad: {1}, Entrada: ${2}", Codigo, Edad, PrecioEntrada);
        }
    }

    public class ListaEnlazadaSimple
    {
        public NodoSimple NodoInicial = null;

        // Calcula el precio de la entrada según la edad.
        // Regla usada: menores (5 a 12) pagan mitad de precio, resto precio completo.
        private double CalcularPrecio(int edad)
        {
            double precioBase = 1000; // precio base de la entrada, ajustable
            if (edad < 13)
            {
                return precioBase / 2;
            }
            return precioBase;
        }

        // Recorrido recursivo para el próximo código disponible.
        private int BuscarMaximo(NodoSimple nodo, int codigo)
        {
            int max = nodo.Codigo > codigo ? nodo.Codigo : codigo;
            if (nodo.Siguiente != null)
            {
                return BuscarMaximo(nodo.Siguiente, max);
            }
            return max;
        }

        private int ProximoCodigo()
        {
            if (NodoInicial == null) return 1;
            return BuscarMaximo(NodoInicial, NodoInicial.Codigo) + 1;
        }

        // a. Registrar una nueva persona (recibe la edad; el precio se calcula solo)
        public void RegistrarPersona(int edad)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Codigo = ProximoCodigo();
            nodo.Edad = edad;
            nodo.PrecioEntrada = CalcularPrecio(edad);

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                NodoSimple ultimo = BuscarUltimo(NodoInicial);
                ultimo.Siguiente = nodo;
            }
        }

        private NodoSimple BuscarUltimo(NodoSimple nodo)
        {
            if (nodo.Siguiente != null)
                return BuscarUltimo(nodo.Siguiente);
            return nodo;
        }

        // d. Mostrar Listado
        public void MostrarListado()
        {
            NodoSimple actual = NodoInicial;
            if (actual == null)
            {
                Console.WriteLine("(la lista está vacía)");
                return;
            }
            while (actual != null)
            {
                Console.WriteLine(actual);
                actual = actual.Siguiente;
            }
        }

        // Busca el nodo por código.
        private NodoSimple BuscarNodo(NodoSimple nodo, int codigo)
        {
            if (nodo == null) return null;
            if (nodo.Codigo == codigo) return nodo;
            return BuscarNodo(nodo.Siguiente, codigo);
        }

        // Busca el nodo anterior al que tiene el código dado.
        private NodoSimple BuscarAnterior(NodoSimple nodo, int codigo)
        {
            if (nodo == null || nodo.Siguiente == null) return null;
            if (nodo.Siguiente.Codigo == codigo) return nodo;
            return BuscarAnterior(nodo.Siguiente, codigo);
        }

        // b. Eliminar persona (en cualquier posición)
        public void EliminarPersona(int codigo)
        {
            if (NodoInicial == null) return;

            if (NodoInicial.Codigo == codigo)
            {
                NodoInicial = NodoInicial.Siguiente;
                return;
            }

            NodoSimple anterior = BuscarAnterior(NodoInicial, codigo);
            if (anterior != null)
            {
                anterior.Siguiente = anterior.Siguiente.Siguiente;
            }
            else
            {
                Console.WriteLine("No se encontró una persona con ese código.");
            }
        }

        // c. Actualizar datos de la persona (acá, la edad; el precio se recalcula solo)
        public void ActualizarPersona(int codigo, int nuevaEdad)
        {
            NodoSimple nodo = BuscarNodo(NodoInicial, codigo);
            if (nodo == null)
            {
                Console.WriteLine("No se encontró una persona con ese código.");
                return;
            }
            nodo.Edad = nuevaEdad;
            nodo.PrecioEntrada = CalcularPrecio(nuevaEdad);
        }

        // Recorrido recursivo para sumar el total recaudado.
        private double SumarRecaudacion(NodoSimple nodo)
        {
            if (nodo == null) return 0;
            return nodo.PrecioEntrada + SumarRecaudacion(nodo.Siguiente);
        }

        public double TotalRecaudado()
        {
            return SumarRecaudacion(NodoInicial);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ListaEnlazadaSimple lista = new ListaEnlazadaSimple();

            // Cantidad de personas al azar entre 0 y 50 (51 excluido, por eso el +1).
            int cantidadPersonas = random.Next(0, 51);
            Console.WriteLine("Cantidad de personas generadas: " + cantidadPersonas);

            // Genero cada persona con edad aleatoria entre 5 y 60 (61 excluido, por eso el +1).
            for (int i = 0; i < cantidadPersonas; i++)
            {
                int edad = random.Next(5, 61);
                lista.RegistrarPersona(edad);
            }

            Console.WriteLine("\n=== Listado inicial ===");
            lista.MostrarListado();

            Console.WriteLine("\n=== Actualizar código 1 (si existe) ===");
            lista.ActualizarPersona(1, 30);
            lista.MostrarListado();

            Console.WriteLine("\n=== Eliminar código 2 (si existe) ===");
            lista.EliminarPersona(2);
            lista.MostrarListado();

            Console.WriteLine("\n=== Total recaudado ===");
            Console.WriteLine("${0}", lista.TotalRecaudado());

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}