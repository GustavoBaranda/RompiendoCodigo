using System;
using System.Collections.Generic;
using System.Text;

namespace semana5
{
    internal class ClubDeportivo
    {
        private List<Socio> socios;
        private List<ActividadDeportiva> actividades;

        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividades = new List<ActividadDeportiva>();
        }

        public void AgregarActividad(ActividadDeportiva actividad)
        {
            if (actividad == null)
            {
                Console.WriteLine("  No se puede agregar una actividad nula.");
                return;
            }

            // Verificar si ya existe una actividad con el mismo nombre
            if (actividades.Exists(a => a.Nombre == actividad.Nombre))
            {
                Console.WriteLine($"  Ya existe una actividad con el nombre '{actividad.Nombre}'.");
                return;
            }

            actividades.Add(actividad);
            Console.WriteLine($"  Actividad '{actividad.Nombre}' agregada correctamente.");
        }

        public void AltaSocio(string nombre, string dniSocio)
        {
            if (socios.Exists(s => s.DniSocio == dniSocio))
            {
                Console.WriteLine("  El socio ya está registrado.");
                return;
            }

            int cantidad = socios.Count;
            Socio nuevoSocio = new Socio(nombre, dniSocio, cantidad+1);
            socios.Add(nuevoSocio);
            Console.WriteLine("  Socio registrado correctamente.");
        }

        public string InscribirActividad(string nombreActividad, string dniSocio)
        {
            
            ActividadDeportiva actividad = actividades.Find(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "  ACTIVIDAD INEXISTENTE";
            }

            if (actividad.CuposDisponibles <= 0)
            {
                return "  CUPOS AGOTADOS PARA ESTA ACTIVIDAD";
            }

            Socio socio = socios.Find(s => s.DniSocio == dniSocio);
            if (socio == null)
            {
                 return "  SOCIO INEXISTENTE";
            }
            
            if (socio.Actividades.Count >= 3)
            {
                return "  TOPE DE ACTIVIDADES ALCANZADO";
            }

            socio.InscribirActividad(actividad);
            actividad.DecrementarCupo();
            return "  INSCRIPCIÓN EXITOSA";
        }
        
        public void MostrarCupos(string nombreActividad)
        {
            ActividadDeportiva actividad = actividades.Find(actividad => actividad.Nombre == nombreActividad);
            if(actividad == null)
            {
                Console.WriteLine("  No existe una actividad con ese nombre");
            } else
            {
                Console.WriteLine(actividad);
            }
        }
        public void MostrarCupos()
        {
            foreach(var actividad in actividades)
            {
                Console.WriteLine(actividad);
            }
        }

         public void MostrarActividades()
        {
            foreach(var actividad in actividades)
            {
                Console.Write(new string(' ', 2)+ actividad.Nombre);
            }
        }
        public void ListarSocios()
        {
            foreach (var nuevoSocio in socios)
            
                Console.WriteLine(nuevoSocio);

        }
    }
}
