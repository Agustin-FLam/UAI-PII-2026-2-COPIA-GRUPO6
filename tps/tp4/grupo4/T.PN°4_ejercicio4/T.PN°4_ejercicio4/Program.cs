class ejercicio4
{


    public class Nodojugador
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        public int DNI;
        public Nodojugador Siguiente;
    }
    public class ListaDeJugadores
    {
        private Nodojugador primero;
        private Nodojugador ultimo;

        public void Agregar(string nombre, string apellido, int edad, int dni)
        {
            Nodojugador nuevo = new Nodojugador
            {
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                DNI = dni
            };
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                ultimo.Siguiente = primero; 
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
                ultimo.Siguiente = primero; 
            }
        }
        public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía");
                return;
            }
            Nodojugador actual = primero;
            do
            {
                Console.WriteLine(actual.Nombre);
                actual = actual.Siguiente;

            } while (actual != primero);
        }
        public void Eliminar(int dni)
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía");
                return;
            }
            Nodojugador actual = primero;
            Nodojugador anterior = ultimo;
            do
            {
                if (actual.DNI == dni)
                {
                    if (actual == primero && actual == ultimo) 
                    {
                        primero = null;
                        ultimo = null; 
                    }
                    else if (actual == primero) 
                    {
                        primero = primero.Siguiente;
                        ultimo.Siguiente = primero; 
                    }
                    else if (actual == ultimo) 
                    {
                        ultimo = anterior;
                        ultimo.Siguiente = primero; 
                    }
                    else 
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    Console.WriteLine("Jugador eliminado.");
                    return;
                }

                anterior = actual;
                actual = actual.Siguiente;

            } while (actual != primero);
            Console.WriteLine("No se encontro un jugador con ese DNI.");
        }
        public void Actualizar(int dni)
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía");
                return;
            }
            Nodojugador actual = primero;
            do
            {
                if (actual.DNI == dni)
                {
                    Console.Write("Ingrese nuevo nombre: ");
                    actual.Nombre = Console.ReadLine();
                    Console.Write("Ingrese nuevo apellido: ");
                    actual.Apellido = Console.ReadLine();
                    Console.Write("Ingrese nueva edad: ");
                    actual.Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Jugador actualizado.");
                    return;
                }
                actual = actual.Siguiente;
            } while (actual != primero);
            Console.WriteLine("No se encontro un jugador con ese DNI.");
        }
        public void AgregarDespues(int dni)
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía");
                return;
            }
            Nodojugador actual = primero;
            do
            {
                if (actual.DNI == dni)
                {
                    Console.Write("Ingrese nombre del nuevo jugador: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese apellido del nuevo jugador: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Ingrese edad del nuevo jugador: ");
                    int edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese DNI del nuevo jugador: ");
                    int nuevoDni = int.Parse(Console.ReadLine());

                    Nodojugador nuevo = new Nodojugador
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Edad = edad,
                        DNI = nuevoDni,
                        Siguiente = actual.Siguiente
                    };
                    nuevo.Siguiente = actual.Siguiente;
                    actual.Siguiente = nuevo;
                    if (actual == ultimo) 
                    {
                        ultimo = nuevo;
                    }
                    ultimo.Siguiente = primero; 
                    Console.WriteLine("Jugador agregado después del seleccionado.");
                    return;
                }
                actual = actual.Siguiente;
            } while (actual != primero);
            Console.WriteLine("No se encontro un jugador con ese DNI.");
        }
    }
    static void Main(string[] args)
    {
        ListaDeJugadores lista = new ListaDeJugadores();
        char opcion;

        do
        {
          Console.WriteLine("\n----TORNEO PATO ÑATO----");
            Console.WriteLine("A. Registrar jugador");
            Console.WriteLine("B. Eliminar jugador");
            Console.WriteLine("C. Actualizar datos");
            Console.WriteLine("D. Agregar ganador");
            Console.WriteLine("E. Mostrar listado de jugadores");
            Console.WriteLine("F. Salir");
            Console.Write("Ingrese una opción: ");
            opcion = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (opcion)
            {
                case 'A':
                    Console.Write("Ingrese nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Ingrese edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    int dni;
                    do
                    {
                        Console.Write("Ingrese DNI(8 dígitos): ");
                    }while(!int.TryParse(Console.ReadLine(), out dni) || dni < 10000000 || dni > 99999999);
                    lista.Agregar(nombre, apellido, edad, dni);
                    Console.WriteLine("Jugador registrado.");
                    break;

                case 'B':
                    Console.Write("Ingrese DNI del jugador a eliminar: ");
                    int dniEliminar;
                    do
                    {
                        Console.Write("Ingrese DNI(8 dígitos): ");
                    }while(!int.TryParse(Console.ReadLine(), out dniEliminar) || dniEliminar < 10000000 || dniEliminar > 99999999);
                    lista.Eliminar(dniEliminar);
                    break;

                case 'C':
                  Console.Write("Ingrese DNI del jugador a actualizar: ");
                    int dniModificar;
                    do
                    {
                        Console.Write("Ingrese DNI(8 dígitos): ");
                    }while(!int.TryParse(Console.ReadLine(), out dniModificar) || dniModificar < 10000000 || dniModificar > 99999999);
                    lista.Actualizar(dniModificar);
                    break;

                case 'D':
                    Console.Write("Ingrese DNI del jugador después del cual desea agregar un nuevo jugador: ");
                    int dniSeleccionado;
                    do
                    {
                        Console.Write("Ingrese DNI(8 dígitos): ");
                    }while(!int.TryParse(Console.ReadLine(), out dniSeleccionado) || dniSeleccionado < 10000000 || dniSeleccionado > 99999999);
                    lista.AgregarDespues(dniSeleccionado);
                    break;

                case 'E':
                    lista.Mostrar();
                    break;

                case 'F':
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 'F');



    }
}