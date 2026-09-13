using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Se tiene una lista de pacientes de un hospital y se desea realizar un sistema sobre registro de los mismos.
Los datos de los pacientes son código, nombres, apellido, dirección y teléfono.
El sistema debe permitir:
a. Registrar un nuevo paciente 
b. Eliminar paciente (en cualquier posición)
c. Actualizar Pacientes (modificar algún dato)
d. Agregar después del seleccionado.
e. Mostrar Listado
 
 */
namespace tp04_listas01
{
    public class NodoSimple
    {
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Telefono;
        public NodoSimple Siguiente;

        public override string ToString()
        {
            return string.Format("Codigo: {0} , Nombre: {1}, Apellido: {2}, Direccion: {3}, Telefono: {4}", Codigo, Nombre, Apellido, Direccion, Telefono);
        }
    }

    public class ListaEnlazadaSimple
    {
        public NodoSimple NodoInicial = null;

        // Registrar un nuevo paciente al principio
        public void AgregarAlPrincipio(int codigo, string nombre, string apellido, string direccion, string telefono)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Codigo = codigo;
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Direccion = direccion;
            nodo.Telefono = telefono;

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                NodoSimple aux = NodoInicial;
                NodoInicial = nodo;
                NodoInicial.Siguiente = aux;
            }
        }

        // Mostrar Listado
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


        // Busca el nodo por codigo.
        private NodoSimple BuscarNodo(NodoSimple nodo, int codigo)
        {
            if (nodo == null) return null; // no se encontró
            if (nodo.Codigo == codigo) return nodo;
            return BuscarNodo(nodo.Siguiente, codigo);
        }

        // Busca el nodo ANTERIOR al que tiene el código dado (necesario para poder "saltearlo").
        private NodoSimple BuscarAnterior(NodoSimple nodo, int codigo)
        {
            if (nodo == null || nodo.Siguiente == null) return null; // no hay anterior posible
            if (nodo.Siguiente.Codigo == codigo) return nodo;
            return BuscarAnterior(nodo.Siguiente, codigo);
        }

        //  ELIMINAR PACIENTE (en cualquier posición) 
        public void EliminarPaciente(int codigo)
        {
            if (NodoInicial == null) return; // lista vacía, no hay nada que borrar

            // Caso 1
            if (NodoInicial.Codigo == codigo)
            {
                NodoInicial = NodoInicial.Siguiente;
                return;
            }

            // Caso 2
            NodoSimple anterior = BuscarAnterior(NodoInicial, codigo);
            if (anterior != null)
            {
                anterior.Siguiente = anterior.Siguiente.Siguiente;
            }
            else
            {
                Console.WriteLine("No se encontró un paciente con ese código.");
            }
        }

        //  ACTUALIZAR PACIENTE
        public void ActualizarPaciente(int codigo, string nombre, string apellido, string direccion, string telefono)
        {
            NodoSimple nodo = BuscarNodo(NodoInicial, codigo);
            if (nodo == null)
            {
                Console.WriteLine("No se encontró un paciente con ese código.");
                return;
            }
         
        }

        //  AGREGAR DESPUÉS DEL SELECCIONADO 
        public void AgregarDespuesDe(int codigoSeleccionado, int codigoNuevo, string nombre, string apellido, string direccion, string telefono)
        {
            NodoSimple seleccionado = BuscarNodo(NodoInicial, codigoSeleccionado);
            if (seleccionado == null)
            {
                Console.WriteLine("No se encontró el paciente seleccionado.");
                return;
            }

            NodoSimple nuevo = new NodoSimple();
            nuevo.Codigo = codigoNuevo;
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
            nuevo.Direccion = direccion;
            nuevo.Telefono = telefono;

            // El nuevo apunta a lo que apuntaba el seleccionado
            nuevo.Siguiente = seleccionado.Siguiente;
            // y el seleccionado ahora apunta al nuevo. En ese orden, si no se pierde la cadena.
            seleccionado.Siguiente = nuevo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple lista = new ListaEnlazadaSimple();

            lista.AgregarAlPrincipio(1, "Ana", "Soria", "Calle Falsa 123", "11634789");
            lista.AgregarAlPrincipio(2, "Laura", "Diaz", "Calle SinNumero", "11664783");

            Console.WriteLine(" Listado inicial ");
            lista.MostrarListado();

            Console.WriteLine("\n Agregar ");
            lista.AgregarDespuesDe(1, 3, "Marcos", "Perez", "Av. Siempreviva 742", "1155512345");
            lista.MostrarListado();

            Console.WriteLine("\n Actualizar ");
            lista.ActualizarPaciente(3, null, null, null, "1199998888");
            lista.MostrarListado();

            Console.WriteLine("\n Eliminar código 2 ");
            lista.EliminarPaciente(2);
            lista.MostrarListado();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}