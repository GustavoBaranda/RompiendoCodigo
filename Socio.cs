using System;
using System.Collections.Generic;
using System.Text;

namespace semana5
{
    internal class Socio
    {
        private string nombre;
        private string dniSocio;
        private List<ActividadDeportiva> actividades;

        public Socio(string nombre, string dniSocio)
        {
            this.nombre = nombre;
            this.dniSocio = dniSocio;
            actividades = new List<ActividadDeportiva>();
        }

        public string Nombre { get => nombre; }
        public string DniSocio { get => dniSocio; }
        public List<ActividadDeportiva> Actividades { get => actividades; }

        public void InscribirActividad(ActividadDeportiva actividad)
        {
            actividades.Add(actividad);
        }
        public override string ToString()
        {
        return "  Socio "+ dniSocio + ": " + nombre;
        }
    }
}
