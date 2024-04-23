using System;

namespace semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClubDeportivo club = new ClubDeportivo();
            club.AltaSocio("Juan Perez", "12345");
            club.AltaSocio("Maria Lopez", "67890");

            ActividadDeportiva futbol = new ActividadDeportiva("Fútbol", 1);
            ActividadDeportiva voley = new ActividadDeportiva("voley", 1);
            club.AgregarActividad(futbol);
            club.AgregarActividad(voley);

            Console.WriteLine(club.InscribirActividad("Fútbol", "12345"));  // Debería mostrar "INSCRIPCIÓN EXITOSA"
            Console.WriteLine(club.InscribirActividad("Fútbol", "12345"));  // Debería mostrar "TOPE DE ACTIVIDADES ALCANZADO"
            Console.WriteLine(club.InscribirActividad("Fútbol", "67890"));  // Debería mostrar "INSCRIPCIÓN EXITOSA"
            Console.WriteLine(club.InscribirActividad("Natación", "12345"));  // Debería mostrar "ACTIVIDAD INEXISTENTE"
            Console.WriteLine(club.InscribirActividad("Fútbol", "00000"));  // Debería mostrar "SOCIO INEXISTENTE"
            club.MostrarCupos("Fútbol");
            club.MostrarCupos();
        }
    }
}
