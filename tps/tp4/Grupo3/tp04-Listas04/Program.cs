using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ejercicio 4:
 En el jardín hay torneo del juego el pato ñato. Para la inscripción del mismo se requiere
 saber el nombre, apellido, edad y DNI.

 Se va a llevar un registro sistémico:
 a. Registrar los chicos que participan del juego.
 b. Poder eliminar a los chicos que van perdiendo (en cualquier posición)
 c. Actualizar los datos de los chicos (modificar algún dato)
 d. Agregar después del seleccionado.
 e. Mostrar Listado de los chicos.
 Nota: Se requiere jugar en forma circular.
 */
namespace tp04_listas04
{
    public class NodoParticipante
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        public int Dni;
        public NodoParticipante Siguiente;

        public override string ToString()
        {
            return string.Format("DNI: {0}, Nombre: {1}, Apellido: {2}, Edad: {3}", Dni, Nombre, Apellido, Edad);
        }
    }

    public class ListaCircularSimple
    {
        // Igual que en el ejemplo del profesor: se guarda "ultimo",
        // porque el primero siempre se obtiene con ultimo.Siguiente.
        private NodoParticipante ultimo = null;
        private int cantidad;

        public int Cantidad => cantidad;

        // a. Registrar un nuevo chico (se agrega al final del anillo)
        public void RegistrarParticipante(string nombre, string apellido, int edad, int dni)
        {
            NodoParticipante nuevo = new NodoParticipante();
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
            nuevo.Edad = edad;
            nuevo.Dni = dni;

            if (ultimo == null)
            {
                ultimo = nuevo;
                ultimo.Siguiente = ultimo; // único nodo: se apunta a sí mismo
            }
            else
            {
                nuevo.Siguiente = ultimo.Siguiente; // apunta al primero
                ultimo.Siguiente = nuevo;
                ultimo = nuevo; // el nuevo pasa a ser el último
            }
            cantidad++;
        }

        // Busca un nodo por DNI. OJO: en lista circular hay que cortar
        // la vuelta con do-while, o el recorrido sería infinito.
        private NodoParticipante BuscarNodo(int dni)
        {
            if (ultimo == null) return null;

            NodoParticipante primero = ultimo.Siguiente;
            NodoParticipante actual = primero;
            do
            {
                if (actual.Dni == dni) return actual;
                actual = actual.Siguiente;
            } while (actual != primero);

            return null; // no se encontró
        }

        // Busca el nodo ANTERIOR al que tiene el DNI dado (misma idea, adaptada al anillo).
        private NodoParticipante BuscarAnterior(int dni)
        {
            if (ultimo == null) return null;

            NodoParticipante primero = ultimo.Siguiente;
            NodoParticipante actual = primero;
            do
            {
                if (actual.Siguiente.Dni == dni) return actual;
                actual = actual.Siguiente;
            } while (actual != primero);

            return null; // no se encontró
        }

        // b. Eliminar chico (en cualquier posición)
        public void EliminarParticipante(int dni)
        {
            if (ultimo == null) return; // lista vacía

            // Caso especial: queda un solo nodo en el anillo.
            if (ultimo.Siguiente == ultimo)
            {
                if (ultimo.Dni == dni)
                {
                    ultimo = null;
                    cantidad--;
                }
                else
                {
                    Console.WriteLine("No se encontró un participante con ese DNI.");
                }
                return;
            }

            NodoParticipante anterior = BuscarAnterior(dni);
            if (anterior == null)
            {
                Console.WriteLine("No se encontró un participante con ese DNI.");
                return;
            }

            NodoParticipante aEliminar = anterior.Siguiente;
            anterior.Siguiente = aEliminar.Siguiente; // "saltea" al eliminado

            if (aEliminar == ultimo) ultimo = anterior; // si borré el último, actualizo la referencia

            cantidad--;
        }

        // c. Actualizar datos del chico
        public void ActualizarParticipante(int dni, string nombre, string apellido, int edad)
        {
            NodoParticipante nodo = BuscarNodo(dni);
            if (nodo == null)
            {
                Console.WriteLine("No se encontró un participante con ese DNI.");
                return;
            }
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Edad = edad;
        }

        // d. Agregar después del seleccionado
        public void AgregarDespuesDe(int dniSeleccionado, string nombre, string apellido, int edad, int dniNuevo)
        {
            NodoParticipante seleccionado = BuscarNodo(dniSeleccionado);
            if (seleccionado == null)
            {
                Console.WriteLine("No se encontró el participante seleccionado.");
                return;
            }

            NodoParticipante nuevo = new NodoParticipante();
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
            nuevo.Edad = edad;
            nuevo.Dni = dniNuevo;

            nuevo.Siguiente = seleccionado.Siguiente; // el nuevo apunta a lo que apuntaba el seleccionado
            seleccionado.Siguiente = nuevo;           // el seleccionado ahora apunta al nuevo

            if (seleccionado == ultimo) ultimo = nuevo; // si agregué después del último, el nuevo es el nuevo último

            cantidad++;
        }

        // e. Mostrar Listado (una vuelta completa del anillo)
        public void MostrarListado()
        {
            if (ultimo == null)
            {
                Console.WriteLine("(la lista está vacía)");
                return;
            }

            NodoParticipante primero = ultimo.Siguiente;
            NodoParticipante actual = primero;
            do
            {
                Console.WriteLine(actual);
                actual = actual.Siguiente;
            } while (actual != primero);
        }

        // Nota: "jugar en forma circular" -> el juego del pato ñato es
        // el mismo problema de Josephus que vimos en el ejemplo del profesor:
        // se va contando "salto" chicos en ronda y el que cae, pierde y sale,
        // hasta que queda un solo ganador.
        public string JugarPatoNato(int salto)
        {
            if (ultimo == null) return null;

            NodoParticipante actual = ultimo.Siguiente; // arranca en el primero
            NodoParticipante anterior = ultimo;

            while (cantidad > 1)
            {
                for (int i = 1; i < salto; i++)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }

                Console.WriteLine("Pierde: " + actual.Nombre + " " + actual.Apellido);

                anterior.Siguiente = actual.Siguiente; // lo saca del anillo
                if (actual == ultimo) ultimo = anterior;
                actual = anterior.Siguiente;
                cantidad--;
            }

            return actual.Nombre + " " + actual.Apellido; // el ganador
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaCircularSimple lista = new ListaCircularSimple();

            lista.RegistrarParticipante("Juan", "Perez", 6, 1);
            lista.RegistrarParticipante("Sofia", "Diaz", 5, 2);
            lista.RegistrarParticipante("Lucas", "Gomez", 7, 3);
            lista.RegistrarParticipante("Mia", "Ruiz", 6, 4);

            Console.WriteLine("=== Listado inicial ===");
            lista.MostrarListado();

            Console.WriteLine("\n=== Agregar después del DNI 2 ===");
            lista.AgregarDespuesDe(2, "Tomas", "Lopez", 5, 5);
            lista.MostrarListado();

            Console.WriteLine("\n=== Actualizar DNI 3 ===");
            lista.ActualizarParticipante(3, "Lucas", "Gomez", 8);
            lista.MostrarListado();

            Console.WriteLine("\n=== Eliminar DNI 1 ===");
            lista.EliminarParticipante(1);
            lista.MostrarListado();

            Console.WriteLine("\n=== Jugar al pato ñato (salto = 2) ===");
            string ganador = lista.JugarPatoNato(2);
            Console.WriteLine("Gana: " + ganador);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}