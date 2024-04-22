using System;

namespace semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.ForegroundColor = ConsoleColor.Green;
     ClubDeportivo club = new ClubDeportivo();

     // Ciclo principal para solicitar datos
     bool continuar = true;
     while (continuar)
     {               
         Console.WriteLine("\n+---------------- Menú de opciones -----------------+");
         Console.WriteLine("|   1. Registrar nuevo socio                        |");
         Console.WriteLine("|   2. Agregar nueva actividad deportiva            |");
         Console.WriteLine("|   3. Inscribir socio a una actividad              |");
         Console.WriteLine("|   4. Mostrar cupos de una actividad               |");
         Console.WriteLine("|   5. Mostrar cupos de todas las actividades       |");
         Console.WriteLine("|   6. Salir                                        |");
         Console.WriteLine("+---------------------------------------------------+");

         Console.Write("  Ingrese el número de la opción que desea realizar: ");
         string opcion = Console.ReadLine();

         switch (opcion)
         {
             case "1":
                 // Registrar un nuevo socio
                 Console.Write("  Ingrese el nombre del socio: ");
                 string nombreSocio = Console.ReadLine();
                 Console.Write("  Ingrese el ID del socio: ");
                 string idSocio = Console.ReadLine();
                 club.AltaSocio(nombreSocio, idSocio);
                 break;

             case "2":
                 //Agregar una nueva actividad deportiva
                 Console.Clear();
                 Console.WriteLine("\n ---------------- Ingrese actividad  ---------------");
                 Console.WriteLine("|   Futbol                                          |");
                 Console.WriteLine("|   Voley                                           |");
                 Console.WriteLine("|   Hambol                                          |");
                 Console.WriteLine("|   Bocha                                           |");
                 Console.WriteLine("|   Salsa                                           |");
                 Console.WriteLine("|   Zumba                                           |");
                 Console.WriteLine(" ---------------------------------------------------");
                 Console.Write("  Ingrese el nombre de la actividad: ");
                 string nombreActividad = Console.ReadLine();
                 Console.Write("  Ingrese los cupos disponibles para la actividad: ");
                 int cuposDisponibles;
                 while (!int.TryParse(Console.ReadLine(), out cuposDisponibles) || cuposDisponibles <= 0)
                 {
                     Console.WriteLine("  Ingrese un número válido mayor que cero para los cupos disponibles.");
                     Console.Write("  Ingrese los cupos disponibles para la actividad: ");
                 }
                 ActividadDeportiva nuevaActividad = new ActividadDeportiva(nombreActividad, cuposDisponibles);
                 club.AgregarActividad(nuevaActividad);
                 break;

             case "3":
                 // Inscribir a un socio en una actividad
                 Console.Clear();
                 Console.Write("  Ingrese el nombre de la actividad: ");
                 string nombreAct = Console.ReadLine();
                 Console.Write("  Ingrese el ID del socio: ");
                 string idSoc = Console.ReadLine();
                 Console.WriteLine(club.InscribirActividad(nombreAct, idSoc));
                 break;

             case "4":
                 // Mostrar cupos de una actividad
                 Console.Clear();
                 Console.Write("  Ingrese el nombre de la actividad: ");
                 string nombreActMostrar = Console.ReadLine();
                 club.MostrarCupos(nombreActMostrar);
                 break;

             case "5":
                 // Mostrar cupos de todas las actividades
                 Console.Clear();
                 club.MostrarCupos();
                 break;

             case "6":
                 // Salir del programa
                 continuar = false;
                 break;

             default:
                 Console.Clear();
                 Console.WriteLine("  Opción no válida. Intente nuevamente.");
                 break;
         }
     }
     Console.Clear();
     Console.WriteLine(" ---------------------------------------------------");
     Console.WriteLine("|  Programa finalizado.                             |");
     Console.WriteLine(" ---------------------------------------------------");
        }
    }
}
