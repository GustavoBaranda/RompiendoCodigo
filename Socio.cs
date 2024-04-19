using System;
using System.Collections.Generic;
using System.Text;

namespace semana5
{
    internal class Socio
    {
        private string nombre;
        private string id;
        private List<ActividadDeportiva> actividades;

        public Socio(string nombre, string id)
        {
            this.nombre = nombre;
            this.id = id;
            actividades = new List<ActividadDeportiva>();
        }

        public string Nombre { get => nombre; }
        public string Id { get => id; }
        public List<ActividadDeportiva> Actividades { get => actividades; }

        public void InscribirActividad(ActividadDeportiva actividad)
        {
            actividades.Add(actividad);
        }
    }
}
