using System;
using System.Collections.Generic;
using System.Text;

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
            mensaje += cuposDisponibles == 0 ?
                "no tiene cupos disponibles." 
                :
                $"tiene {cuposDisponibles} cupos disponibles.";
            return mensaje;
        }

    }

}
