using System;

namespace semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;    
            ClubDeportivo club = new ClubDeportivo();
            club.AltaSocio("Gustavo", "30123123");
            club.AltaSocio("Eugenia", "22200000");
            ActividadDeportiva futbol = new ActividadDeportiva("Futbol", 10);
            ActividadDeportiva voley = new ActividadDeportiva("Voley", 8);
            ActividadDeportiva tenis = new ActividadDeportiva("Tenis", 2);
            ActividadDeportiva basquet = new ActividadDeportiva("Basquet", 15);
            club.AgregarActividad(futbol);
            club.AgregarActividad(voley);
            club.AgregarActividad(tenis);
            club.AgregarActividad(basquet);
            club.InscribirActividad("Futbol", "30123123");
            club.InscribirActividad("Voley", "30123123");
            club.InscribirActividad("Tenis", "30123123");
            club.InscribirActividad("Tenis", "22200000");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine("\n\n\n +---- El proyecto fue creado por el grupo nro. 5 ---+");
            Console.WriteLine(" |                Marcelo Galimberti                 |");
            Console.WriteLine(" |                 Catriel Escobar                   |");
            Console.WriteLine(" |                 M. Eugenia Bava                   |");
            Console.WriteLine(" |                 Alejandro Abadi                   |");
            Console.WriteLine(" |                 Gustavo Baranda                   |");
               Console.WriteLine(" +---------------------------------------------------+");
            
            
            // Ciclo principal para solicitar datos
            bool continuar = true;
            while (continuar)
            {             
                MostrarMenu();
                Console.ForegroundColor = ConsoleColor.DarkYellow;  
                Console.Write("\n Ingrese la opción que desea realizar: ");
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
                        // Listado de socios registrados
                        MostrarListaDeSocios(club);
                        break;

                    case "5":
                       // Salir del programa
                        continuar = false;
                        break;

                    default:
                        MostrarMensajeOpcionInvalida();
                        break;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine(" +---------------------------------------------------+");
            Console.WriteLine(" |              Programa finalizado.                 |");
            Console.WriteLine(" +---------------------------------------------------+");
            Console.ReadKey();
        }
        static void MostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine("\n +---------------- Menú de opciones -----------------+");
            Console.WriteLine(" |   1. Registrar nuevo socio                        |");
            Console.WriteLine(" |   2. Agregar nueva actividad deportiva            |");
            Console.WriteLine(" |   3. Inscribir socio a una actividad              |");
            Console.WriteLine(" |   4. Listar socios                                |");
            Console.WriteLine(" |   5. Salir                                        |");
            Console.WriteLine(" +---------------------------------------------------+");
        }
        static void RegistrarNuevoSocio(ClubDeportivo club)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine("\n +----------------- Alta de socios ------------------+");
            Console.ForegroundColor = ConsoleColor.DarkYellow;  
            string nombreSocio;
            while (true)
            {
                Console.Write("  Ingrese el nombre del socio: ");
                nombreSocio = Console.ReadLine().Trim();  

                if (!string.IsNullOrEmpty(nombreSocio)) 
                {
                    break;  
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  El nombre no puede estar vacío. Intente nuevamente.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            string idSocio;
            while (true)
            {
                Console.Write("  Ingrese el DNI del socio: ");
                idSocio = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(idSocio))
                {
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  El DNI no puede estar vacío. Intente nuevamente.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            club.AltaSocio(nombreSocio, idSocio);
                
        }
        static void AgregarNuevaActividad(ClubDeportivo club)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine(" +------------- Actividades registradas -------------+");
            Console.ForegroundColor = ConsoleColor.DarkYellow;  
            club.MostrarActividades();
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine("\n +---------------------------------------------------+ \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow; 

            string nombreActividad;
            while (true)
            {
                Console.Write("  Ingrese nueva actividad a resgistrar: ");
                nombreActividad = Console.ReadLine().Trim();  

                if (!string.IsNullOrEmpty(nombreActividad)) 
                {
                    break;  
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  La actividad no puede estar vacío. Intente nuevamente.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.Write("  Ingrese cupos disponibles: ");
            int cuposDisponibles;
            while (!int.TryParse(Console.ReadLine(), out cuposDisponibles) || cuposDisponibles <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Ingrese un número válido mayor que cero para los cupos disponibles.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;  
                Console.Write("  Ingrese los cupos disponibles para la actividad: ");
            }
            ActividadDeportiva nuevaActividad = new ActividadDeportiva(nombreActividad, cuposDisponibles);
            club.AgregarActividad(nuevaActividad);
        }
        static void InscribirSocioActividad(ClubDeportivo club)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine(" +--------------- Oferta de actividades -------------+");
            Console.ForegroundColor = ConsoleColor.DarkYellow;  
            club.MostrarCupos();
            Console.ForegroundColor = ConsoleColor.Gray;  
            Console.WriteLine(" +---------------------------------------------------+\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;  
       
            string nombreAct;
            while (true)
            {
                Console.Write("  Ingrese nueva actividad a resgistrar: ");
                nombreAct = Console.ReadLine().Trim();  

                if (!string.IsNullOrEmpty(nombreAct)) 
                {
                    break;  
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  La actividad no puede estar vacío. Intente nuevamente.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            string idSoc;
            while (true)
            {
                Console.Write("  Ingrese el DNI del socio: ");
                idSoc = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(idSoc))
                {
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  El DNI no puede estar vacío. Intente nuevamente.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            Console.WriteLine(club.InscribirActividad(nombreAct, idSoc));
        }
        static void MostrarListaDeSocios(ClubDeportivo club)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n +---------------- Lista de socios ------------------+");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            club.ListarSocios();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" +---------------------------------------------------+");
        }
        static void MostrarMensajeOpcionInvalida()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" +---------------------------------------------------+");
            Console.WriteLine(" |       Opción no válida. Intente nuevamente.       |");
            Console.WriteLine(" +---------------------------------------------------+");
        }  
    }
}

