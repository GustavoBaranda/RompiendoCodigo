using System;
using System.Collections.Generic;
using System.Text;

namespace TP_ClubDeportivo
{
    internal class Socio
    {
        private string nombre;
        private int id;
        private int cantActividades;
        private const int TOPE_ACTIVIDADES = 3;
        private List<Actividad> actividadList;

        public Socio(string nombre)
        {
            this.Nombre = nombre;
        }

        public Socio(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
            actividadList = new List<Actividad>();
        }

        public int GetTOPE_ACTIVIDADES() { return TOPE_ACTIVIDADES; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int CantActividades { get => cantActividades; set => cantActividades = value; }
        public List<Actividad> actividades { get => actividadList; }

        public void inscribirActividad(Actividad actividad)
        {
            actividadList.Add(actividad);
        }
        public override string ToString()
        {
            return $"Se registro exitosamente a {nombre} con id nº {id}";
        }
    }
}
