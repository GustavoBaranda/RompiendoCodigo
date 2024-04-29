using System;
using System.Collections.Generic;
using System.Text;

namespace semana5
{
    internal class Socio
    {
        private string nombre;
        private string dniSocio;
        private int id;
        private List<ActividadDeportiva> actividades;

        public Socio(string nombre, string dniSocio, int id)
        {
            this.nombre = nombre;
            this.dniSocio = dniSocio;
            this.id = id;
            actividades = new List<ActividadDeportiva>();
        }

        public string Nombre { get => nombre; }
        public string DniSocio { get => dniSocio; }
        public int Id { get => id; }
        public List<ActividadDeportiva> Actividades { get => actividades; }

        public void InscribirActividad(ActividadDeportiva actividad)
        {
            actividades.Add(actividad);
        }

        public override string ToString()
        {
        return "  Socio N° "+ id + ": "+ nombre + " DNI: "+ dniSocio;
        }
    }
}
