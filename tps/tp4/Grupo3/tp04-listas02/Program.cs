using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Realice un sistema que permita el registro de alumnos de una institución que permita
 registrar, modificar, eliminar los mismos. Los datos de los alumnos son nombres, apellido,
 DNI, fecha de nacimiento, dirección y teléfono.
 El sistema debe permitir:
 a. Registrar un nuevo alumno
 b. Eliminar alumno (en cualquier posición)
 c. Actualizar alumno (modificar algún dato)
 d. Agregar después del seleccionado
 e. Agregar antes del seleccionado
 f. Mostrar Listado de los alumnos actuales
 */
namespace tp04_listas02
{
    public class NodoSimple
    {
        public string Nombre;
        public string Apellido;
        public int Dni;
        public string FechaNacimiento;
        public string Direccion;
        public string Telefono;
        public NodoSimple Siguiente;

        public override string ToString()
        {
            return string.Format("DNI: {0}, Nombre: {1}, Apellido: {2}, FechaNac: {3}, Direccion: {4}, Telefono: {5}",
                Dni, Nombre, Apellido, FechaNacimiento, Direccion, Telefono);
        }
    }

    public class ListaEnlazadaSimple
    {
        public NodoSimple NodoInicial = null;

        // a. Registrar un nuevo alumno (al principio)
        public void AgregarAlPrincipio(string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Dni = dni;
            nodo.FechaNacimiento = fechaNacimiento;
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

        // f. Mostrar Listado
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

        // Busca el nodo por DNI.
        private NodoSimple BuscarNodo(NodoSimple nodo, int dni)
        {
            if (nodo == null) return null; // no se encontró
            if (nodo.Dni == dni) return nodo;
            return BuscarNodo(nodo.Siguiente, dni);
        }

        // Busca el nodo ANTERIOR al que tiene el DNI dado.
        private NodoSimple BuscarAnterior(NodoSimple nodo, int dni)
        {
            if (nodo == null || nodo.Siguiente == null) return null; // no hay anterior posible
            if (nodo.Siguiente.Dni == dni) return nodo;
            return BuscarAnterior(nodo.Siguiente, dni);
        }

        // b. ELIMINAR ALUMNO (en cualquier posición)
        public void EliminarAlumno(int dni)
        {
            if (NodoInicial == null) return; // lista vacía

            // Caso 1: es el primero
            if (NodoInicial.Dni == dni)
            {
                NodoInicial = NodoInicial.Siguiente;
                return;
            }

            // Caso 2: está en el medio o al final
            NodoSimple anterior = BuscarAnterior(NodoInicial, dni);
            if (anterior != null)
            {
                anterior.Siguiente = anterior.Siguiente.Siguiente;
            }
            else
            {
                Console.WriteLine("No se encontró un alumno con ese DNI.");
            }
        }

        // c. ACTUALIZAR ALUMNO
        public void ActualizarAlumno(int dni, string nombre, string apellido, string fechaNacimiento, string direccion, string telefono)
        {
            NodoSimple nodo = BuscarNodo(NodoInicial, dni);
            if (nodo == null)
            {
                Console.WriteLine("No se encontró un alumno con ese DNI.");
                return;
            }
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.FechaNacimiento = fechaNacimiento;
            nodo.Direccion = direccion;
            nodo.Telefono = telefono;
        }

        // d. AGREGAR DESPUÉS DEL SELECCIONADO
        public void AgregarDespuesDe(int dniSeleccionado, string nombre, string apellido, int dniNuevo, string fechaNacimiento, string direccion, string telefono)
        {
            NodoSimple seleccionado = BuscarNodo(NodoInicial, dniSeleccionado);
            if (seleccionado == null)
            {
                Console.WriteLine("No se encontró el alumno seleccionado.");
                return;
            }

            NodoSimple nuevo = new NodoSimple();
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
            nuevo.Dni = dniNuevo;
            nuevo.FechaNacimiento = fechaNacimiento;
            nuevo.Direccion = direccion;
            nuevo.Telefono = telefono;

            // El nuevo apunta a lo que apuntaba el seleccionado...
            nuevo.Siguiente = seleccionado.Siguiente;
            // ...y el seleccionado ahora apunta al nuevo.
            seleccionado.Siguiente = nuevo;
        }

        // e. AGREGAR ANTES DEL SELECCIONADO
        public void AgregarAntesDe(int dniSeleccionado, string nombre, string apellido, int dniNuevo, string fechaNacimiento, string direccion, string telefono)
        {
            if (NodoInicial == null)
            {
                Console.WriteLine("No se encontró el alumno seleccionado.");
                return;
            }

            NodoSimple nuevo = new NodoSimple();
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
            nuevo.Dni = dniNuevo;
            nuevo.FechaNacimiento = fechaNacimiento;
            nuevo.Direccion = direccion;
            nuevo.Telefono = telefono;

            // Caso especial: si el seleccionado es el PRIMERO de la lista,
            // no tiene "anterior", así que el nuevo pasa a ser el NodoInicial.
            if (NodoInicial.Dni == dniSeleccionado)
            {
                nuevo.Siguiente = NodoInicial;
                NodoInicial = nuevo;
                return;
            }

            // Caso general: busco el anterior al seleccionado, y me "inserto" entre medio.
            NodoSimple anterior = BuscarAnterior(NodoInicial, dniSeleccionado);
            if (anterior == null)
            {
                Console.WriteLine("No se encontró el alumno seleccionado.");
                return;
            }

            nuevo.Siguiente = anterior.Siguiente; // el nuevo apunta al seleccionado
            anterior.Siguiente = nuevo;           // el anterior ahora apunta al nuevo
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple lista = new ListaEnlazadaSimple();

            lista.AgregarAlPrincipio("Ana", "Soria", 30111222, "10/03/2005", "Calle Falsa 123", "11634789");
            lista.AgregarAlPrincipio("Laura", "Diaz", 30333444, "22/07/2004", "Calle SinNumero", "11664783");

            Console.WriteLine("Listado inicial");
            lista.MostrarListado();

            Console.WriteLine("\nAgregar después de 30111222");
            lista.AgregarDespuesDe(30111222, "Marcos", "Perez", 30555666, "01/01/2006", "Av. Siempreviva 742", "1155512345");
            lista.MostrarListado();

            Console.WriteLine("\nAgregar antes de 30333444");
            lista.AgregarAntesDe(30333444, "Julia", "Gomez", 30777888, "15/09/2003", "Belgrano 456", "1166677788");
            lista.MostrarListado();

            Console.WriteLine("\nActualizar DNI 30555666");
            lista.ActualizarAlumno(30555666, "Marcos", "Perez", "01/01/2006", "Av. Siempreviva 742", "1199998888");
            lista.MostrarListado();

            Console.WriteLine("\nEliminar DNI 30333444");
            lista.EliminarAlumno(30333444);
            lista.MostrarListado();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}