using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp04_Listas07
{
    // TDA Nodo: representa un elemento de la lista y una referencia al siguiente.
    public class NodoSimple
    {
        public int Numero;
        public string Nombre;
        public NodoSimple Siguiente;

        public override string ToString()
        {
            return string.Format("{0} - {1}", Numero, Nombre);
        }
    }

    public class ListaEnlazadaSimple
    {
        public NodoSimple NodoInicial = null;

        // Agrega un nodo al final de la lista (necesario para poder armar la lista de prueba).
        public void AgregarAlFinal(int numero, string nombre)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Numero = numero;
            nodo.Nombre = nombre;

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
                return;
            }
            NodoSimple ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente = nodo;
        }

        private NodoSimple BuscarUltimo(NodoSimple nodo)
        {
            if (nodo.Siguiente != null)
                return BuscarUltimo(nodo.Siguiente);
            return nodo;
        }

        // Recorrido recursivo en busca del nodo con un número determinado.
        private NodoSimple BuscarNodo(NodoSimple nodo, int numero)
        {
            if (nodo == null) return null;
            if (nodo.Numero == numero) return nodo;
            return BuscarNodo(nodo.Siguiente, numero);
        }

        // Recorrido recursivo en busca del nodo anterior al que tiene "numero".
        private NodoSimple BuscarAnterior(NodoSimple nodo, int numero)
        {
            if (nodo == null || nodo.Siguiente == null) return null;
            if (nodo.Siguiente.Numero == numero) return nodo;
            return BuscarAnterior(nodo.Siguiente, numero);
        }

        // ================== EJERCICIO 7 ==================

        // 1. Intercambia el VALOR de un nodo con el de su siguiente (a la derecha).
        public void IntercambiarDerecha(int numero)
        {
            NodoSimple nodo = BuscarNodo(NodoInicial, numero);
            if (nodo != null && nodo.Siguiente != null)
            {
                Intercambiar(nodo, nodo.Siguiente);
            }
        }

        // 2. Intercambia el VALOR de un nodo con el de su anterior (a la izquierda).
        public void IntercambiarIzquierda(int numero)
        {
            NodoSimple anterior = BuscarAnterior(NodoInicial, numero);
            NodoSimple nodo = BuscarNodo(NodoInicial, numero);
            if (anterior != null && nodo != null)
            {
                Intercambiar(anterior, nodo);
            }
        }

        // 3. Intercambia el VALOR de dos nodos a partir de los números que los identifican.
        public void Intercambiar(int numero1, int numero2)
        {
            NodoSimple nodo1 = BuscarNodo(NodoInicial, numero1);
            NodoSimple nodo2 = BuscarNodo(NodoInicial, numero2);
            if (nodo1 != null && nodo2 != null)
            {
                Intercambiar(nodo1, nodo2);
            }
        }

        // Sobrecarga interna: intercambia Numero y Nombre entre dos nodos ya ubicados.
        private void Intercambiar(NodoSimple a, NodoSimple b)
        {
            int numAux = a.Numero;
            string nomAux = a.Nombre;
            a.Numero = b.Numero;
            a.Nombre = b.Nombre;
            b.Numero = numAux;
            b.Nombre = nomAux;
        }

        // ===================================================

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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple lista = new ListaEnlazadaSimple();

            lista.AgregarAlFinal(1, "Ana");
            lista.AgregarAlFinal(2, "Bruno");
            lista.AgregarAlFinal(3, "Carla");
            lista.AgregarAlFinal(4, "Diego");

            Console.WriteLine("=== Listado inicial ===");
            lista.MostrarListado();

            Console.WriteLine("\n=== IntercambiarDerecha(2) -> intercambia 2 con 3 ===");
            lista.IntercambiarDerecha(2);
            lista.MostrarListado();

            Console.WriteLine("\n=== IntercambiarIzquierda(4) -> intercambia 4 con su anterior ===");
            lista.IntercambiarIzquierda(4);
            lista.MostrarListado();

            Console.WriteLine("\n=== Intercambiar(1, 3) ===");
            lista.Intercambiar(1, 3);
            lista.MostrarListado();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}