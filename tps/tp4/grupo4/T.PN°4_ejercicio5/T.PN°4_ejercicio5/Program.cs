using System.ComponentModel.Design;

class ejercicio5
{
    class NodoPaciente
    { 
        public string codigo;
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public NodoPaciente siguiente;
        public NodoPaciente anterior;
    }
    static NodoPaciente primero = null;
    static NodoPaciente ultimo = null;

    class ListaPacientes
    {
        private NodoPaciente primero = null;
        private NodoPaciente ultimo = null;
        public void RegistrarPaciente(NodoPaciente nuevo)
        {
            if(primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                ultimo = nuevo;
            }
        }
        public void EliminarPaciente(string codigo)
        {
            NodoPaciente actual = primero;

            while (actual != null)
            {
                if (actual.codigo == codigo)
                {
                    
                    if (actual == primero)
                    {
                        primero = actual.siguiente;

                        if (primero != null)
                        {
                            primero.anterior = null;
                        }
                        else
                        {
                            ultimo = null;
                        }
                    }

                    
                    else if (actual == ultimo)
                    {
                        ultimo = actual.anterior;
                        ultimo.siguiente = null;
                    }

                    
                    else
                    {
                        actual.anterior.siguiente = actual.siguiente;
                        actual.siguiente.anterior = actual.anterior;
                    }

                    Console.WriteLine("Paciente eliminado exitosamente.");
                    return;
                }

                actual = actual.siguiente;
            }

            Console.WriteLine("Paciente no encontrado.");
        }


        public void ActualizarPaciente(string codigo)
        {
            NodoPaciente actual = primero;
            while (actual != null)
            {
                if (actual.codigo == codigo)
                {
                    Console.WriteLine("Paciente encontrado:");
                    Console.Write("Ingrese nuevo nombre: ");
                    actual.nombre = Console.ReadLine();
                    Console.Write("Ingrese nuevo apellido: ");
                    actual.apellido = Console.ReadLine();
                    Console.Write("Ingrese nueva dirección: ");
                    actual.direccion = Console.ReadLine();
                    Console.Write("Ingrese nuevo teléfono: ");
                    actual.telefono = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Paciente actualizado exitosamente.");
                    Console.WriteLine("Paciente actualizado:");
                    return;
                }
                actual = actual.siguiente;
            }
            Console.WriteLine("Paciente no encontrado.");
        }
        public void MostrarListado()
        {
            if (primero == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }
            NodoPaciente actual = primero;
            while (actual != null)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Código: " + actual.codigo);
                Console.WriteLine("Nombre: " + actual.nombre);
                Console.WriteLine("Apellido: " + actual.apellido);
                Console.WriteLine("Dirección: " + actual.direccion);
                Console.WriteLine("Teléfono: " + actual.telefono);
                actual = actual.siguiente;
            }
        }
    }
    public static void Main(string[] args)
    {
        ListaPacientes lista = new ListaPacientes();
        int opcion;
        do
        {
            Console.WriteLine("\n---REGISTRO DE PACIENTES---");
            Console.WriteLine("1. Registrar Paciente");
            Console.WriteLine("2. Eliminar Paciente");
            Console.WriteLine("3. Actualizar Paciente");
            Console.WriteLine("4. Mostrar Listado");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    NodoPaciente nuevoPaciente = new NodoPaciente();
                    Console.Write("Ingrese código: ");
                    nuevoPaciente.codigo = Console.ReadLine();
                    Console.Write("Ingrese nombre: ");
                    nuevoPaciente.nombre = Console.ReadLine();
                    Console.Write("Ingrese apellido: ");
                    nuevoPaciente.apellido = Console.ReadLine();
                    Console.Write("Ingrese dirección: ");
                    nuevoPaciente.direccion = Console.ReadLine();
                    Console.Write("Ingrese teléfono: ");
                    string telefono = Console.ReadLine();
                    while (!long.TryParse(telefono, out long numero) || telefono.Length != 10)
                    {
                        Console.Write("El telefono debe contener 10 dígitos. Ingrese teléfono nuevamente: ");
                        telefono = Console.ReadLine();
                    }
                    nuevoPaciente.telefono = Convert.ToInt32(telefono);

                    lista.RegistrarPaciente(nuevoPaciente);
                    Console.WriteLine("Paciente registrado exitosamente.");
                    break;
                case 2:
                    Console.Write("Ingrese código del paciente a eliminar: ");
                    string codigoEliminar = Console.ReadLine();
                    lista.EliminarPaciente(codigoEliminar);
                    break;
                case 3:
                    Console.Write("Ingrese código del paciente a actualizar: ");
                    string codigoActualizar = Console.ReadLine();
                    lista.ActualizarPaciente(codigoActualizar);
                    break;
                case 4:
                    lista.MostrarListado();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 5);
    }
}
