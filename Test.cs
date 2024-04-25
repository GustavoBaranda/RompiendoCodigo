using System;
using System.Collections.Generic;
using System.Text;

namespace TP_ClubDeportivo
{
    internal class Test
    {
        static void Main(string[] args)
        {
            ClubDeportivo boca = new ClubDeportivo();
            boca.altaActividad("Zunga", 2);
            boca.altaActividad("Crossfix", 20);
            boca.altaActividad("Futbol", 10);
            boca.altaActividad("Basquet", 20);
            boca.altaSocio("Juan");
            boca.altaSocio("Manuel");
            boca.altaSocio("Manuel");
            Console.WriteLine(boca.inscribirActividad("Futbol", 1));
            Console.WriteLine(boca.inscribirActividad("Tenis", 1));
            Console.WriteLine(boca.inscribirActividad("Crossfix", 1));
            Console.WriteLine(boca.inscribirActividad("Zunga", 3));
            Console.WriteLine(boca.inscribirActividad("Zunga", 2));
            Console.WriteLine(boca.inscribirActividad("Futbol", 1));
            Console.WriteLine(boca.inscribirActividad("Zunga", 1));
            Console.WriteLine(boca.inscribirActividad("Basquet", 1));
            Console.WriteLine(boca.inscribirActividad("Zunga", 2));

        }
    }
}
