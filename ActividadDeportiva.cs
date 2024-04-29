using System;

namespace semana5
{
    internal class ActividadDeportiva
    {
        private string nombre;
        private int cuposDisponibles;

        public ActividadDeportiva(string nombre, int cuposDisponibles)
        {
            this.nombre = nombre;
            this.cuposDisponibles = cuposDisponibles;
        }

        public string Nombre { get => nombre; }
        public int CuposDisponibles { get => cuposDisponibles; }

        public void DecrementarCupo()
        {
            cuposDisponibles--;
        }

        public override string ToString()
        {
            string mensaje = $"  La actividad {nombre} ";
            if (cuposDisponibles == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                mensaje += "no tiene cupos disponibles."; 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                mensaje += $"tiene {cuposDisponibles} cupos disponibles.";
            }
            return mensaje;
        }

    }

}
