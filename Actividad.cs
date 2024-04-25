using System;
using System.Collections.Generic;
using System.Text;

namespace TP_ClubDeportivo
{
    internal class Actividad
    {

        private int cupo;
        private string nombre;

        public Actividad(string nombre, int cupo)
        {
            this.Nombre = nombre;
            this.Cupo = cupo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cupo { get => cupo; set => cupo = value; }
    }
}
