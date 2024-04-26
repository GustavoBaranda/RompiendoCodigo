using System;
using System.Collections.Generic;

namespace TP_ClubDeportivo
{
    internal class ClubDeportivo
    {
        private List<Socio> socios;
        private List<Actividad> actividades;
        private int siguienteId = 0;

        public ClubDeportivo()
        {
            this.socios = new List<Socio>();
            this.actividades = new List<Actividad>();
        }

        private Socio buscarSocio(string nombreSocio)
        {
            Socio socioBuscado = null;
            int i = 0;
            while (i < socios.Count && !socios[i].Nombre.Equals(nombreSocio))
                i++;
            if (i != socios.Count)
                socioBuscado = socios[i];
            return socioBuscado;
        }

        private Socio buscarSocio(int id)
        {
            Socio socioBuscado = null;
            int i = 0;
            while (i < socios.Count && !socios[i].Id.Equals(id))
                i++;
            if (i != socios.Count)
                socioBuscado = socios[i];
            return socioBuscado;
        }

        public void altaSocio(string nombre)
        {
            string resultado = "El campo nombre no puede estar vacio";
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                Socio socioNuevo;
                socioNuevo = buscarSocio(nombre);
                if (socioNuevo != null)
                {
                    resultado = $"El socio {nombre} ya existe!";
                }
                else
                {
                    siguienteId++;
                    socioNuevo = new Socio(nombre.Trim(), siguienteId);
                    socios.Add(socioNuevo);
                    resultado = socioNuevo.ToString();
                }
            }
            Console.WriteLine(resultado);
        }

        private Actividad buscarActividad(string nombreActividad)
        {
            Actividad actividadBuscada = null;
            int i = 0;
            while (i < actividades.Count && !actividades[i].Nombre.Equals(nombreActividad))
                i++;
            if (i != actividades.Count)
                actividadBuscada = actividades[i];
            return actividadBuscada;
        }

        public bool altaActividad(string actividad, int cupo)
        {
            bool resultado = false;
            if (string.IsNullOrWhiteSpace(actividad) || cupo <= 0) return resultado;
            Actividad actividadNueva;
            actividadNueva = buscarActividad(actividad);
            if (actividadNueva == null)
            {
                actividadNueva = new Actividad(actividad, cupo);
                actividades.Add(actividadNueva);
                resultado = true;
            }

            return resultado;
        }

        public string inscribirActividad(string nombreActividad, int idSocio)
        {

            Actividad actividad = buscarActividad(nombreActividad);
            Socio socio = buscarSocio(idSocio);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }
            if (socio.CantActividades == socio.GetTOPE_ACTIVIDADES())
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }
            if (actividad.Cupo == 0)
            {
                return "LA ACTIVIDAD ALCANZO SU LIMITE MÁXIMO";
            }
            if (socio.actividades.Exists(a => a.Nombre == actividad.Nombre))
            {
                return $"YA SE ANOTÓ A {actividad.Nombre} EL CLIENTE";
            }
            socio.inscribirActividad(actividad);
            socio.CantActividades += 1;
            actividad.Cupo -= 1;
            return "INSCRIPCIÓN EXITOSA";
        }
    }
}
