using System;

namespace semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;    
            ClubDeportivo club = new ClubDeportivo();
            club.AltaSocio("Gustavo", "1234");
            club.AltaSocio("Eugenia", "4321");
            ActividadDeportiva futbol = new ActividadDeportiva("Futbol", 10);
            ActividadDeportiva voley = new ActividadDeportiva("Voley", 8);
            ActividadDeportiva tenis = new ActividadDeportiva("Tenis", 2);
            ActividadDeportiva basquet = new ActividadDeportiva("Basquet", 15);
            club.AgregarActividad(futbol);
            club.AgregarActividad(voley);
            club.AgregarActividad(tenis);
            club.AgregarActividad(basquet);
            club.InscribirActividad("Futbol", "1234");
            club.InscribirActividad("Voley", "1234");
            club.InscribirActividad("Tenis", "1234");
            club.InscribirActividad("Tenis", "4321");
            Console.Clear();
            
            // Ciclo principal para solicitar datos
            bool continuar = true;
            while (continuar)
            {             
                MostrarMenu();
                Console.Write("Ingrese la opción que desea realizar: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        // Registrar un nuevo socio
                        RegistrarNuevoSocio(club);                      
                        break;

                    case "2":
                        //Agregar una nueva actividad deportiva                        
                        AgregarNuevaActividad(club);
                        break;

                    case "3":
                        // Inscribir a un socio en una actividad
                        InscribirSocioActividad(club);
                        break;

                    case "4":
                       // Salir del programa
                        continuar = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n  Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine(" +---------------------------------------------------+");
            Console.WriteLine(" |              Programa finalizado.                 |");
            Console.WriteLine(" +---------------------------------------------------+");


        }
        static void MostrarMenu()
        {
            Console.WriteLine("\n+---------------- Menú de opciones -----------------+");
            Console.WriteLine("|   1. Registrar nuevo socio                        |");
            Console.WriteLine("|   2. Agregar nueva actividad deportiva            |");
            Console.WriteLine("|   3. Inscribir socio a una actividad              |");
            Console.WriteLine("|   4. Salir                                        |");
            Console.WriteLine("+---------------------------------------------------+");
        }
        static void RegistrarNuevoSocio(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine("\n+----------------- Alta de socios ------------------+");
            Console.Write("  Ingrese el nombre del socio: ");
            string nombreSocio = Console.ReadLine();
            Console.Write("  Ingrese el ID del socio: ");
            string idSocio = Console.ReadLine();
            club.AltaSocio(nombreSocio, idSocio);
        }
        static void AgregarNuevaActividad(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine(" +------------- Actividades registradas -------------+");
            club.MostrarActividades();
            Console.WriteLine("\n +---------------------------------------------------+ \n");
            Console.Write("  Ingrese nueva actividad a resgistrar: ");
            string nombreActividad = Console.ReadLine();
            Console.Write("  Ingrese cupos disponibles: ");
            int cuposDisponibles;
            while (!int.TryParse(Console.ReadLine(), out cuposDisponibles) || cuposDisponibles <= 0)
            {
                Console.WriteLine("  Ingrese un número válido mayor que cero para los cupos disponibles.");
                Console.Write("  Ingrese los cupos disponibles para la actividad: ");
            }
            ActividadDeportiva nuevaActividad = new ActividadDeportiva(nombreActividad, cuposDisponibles);
            club.AgregarActividad(nuevaActividad);
        }
        static void InscribirSocioActividad(ClubDeportivo club)
        {
            Console.Clear();
            Console.WriteLine(" +--------------- Oferta de actividades -------------+");
            club.MostrarCupos();
            Console.WriteLine(" +---------------------------------------------------+\n");
            Console.Write("  Elija actividad deseada: ");
            string nombreAct = Console.ReadLine();
            Console.Write("  Ingrese el ID del socio: ");
            string idSoc = Console.ReadLine();
            Console.WriteLine(club.InscribirActividad(nombreAct, idSoc));
        }  
    }
}