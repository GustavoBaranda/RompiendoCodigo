using System;
using System.Collections.Generic;
using semana5;

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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  No se puede agregar una actividad nula.");
            return;
        }

        // Verificar si ya existe una actividad con el mismo nombre
        if (actividades.Exists(a => a.Nombre.ToLower() == actividad.Nombre.ToLower()))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  Ya existe una actividad con el nombre '{actividad.Nombre}'.");
            return;
        }

        actividades.Add(actividad);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"  Actividad '{actividad.Nombre}' agregada correctamente.");
    }
    public void AltaSocio(string nombre, string dniSocio)
    {
        if (socios.Exists(s => s.DniSocio == dniSocio))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  EL SOCIO SE ENCUENTRA REGISTRADO.");
            return;
        }

        Socio nuevoSocio = new Socio(nombre, dniSocio);
        socios.Add(nuevoSocio);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  Socio registrado correctamente.");
    }
    public string InscribirActividad(string nombreActividad, string idSocio)
    {
        
        ActividadDeportiva actividad = actividades.Find(a => a.Nombre.ToLower() == nombreActividad.ToLower());
        if (actividad == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "  ACTIVIDAD INEXISTENTE";
        }

        if (actividad.CuposDisponibles <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "  CUPOS AGOTADOS PARA ESTA ACTIVIDAD";
        }

        Socio socio = socios.Find(s => s.DniSocio == idSocio);
        if (socio == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "  SOCIO INEXISTENTE";
        }        

        if (socio.Actividades.Exists(a => a.Nombre.ToLower() == nombreActividad.ToLower()))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "  EL SOCIO YA ESTÁ INSCRITO EN ESTA ACTIVIDAD";
        }

        socio.InscribirActividad(actividad);
        actividad.DecrementarCupo();
        Console.ForegroundColor = ConsoleColor.Green;
        return "  INSCRIPCIÓN EXITOSA";
    }
    public void MostrarCupos(string nombreActividad)
    {
        ActividadDeportiva actividad = actividades.Find(actividad => actividad.Nombre == nombreActividad);
        if(actividad == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  NO EXISTE UNA ACTIVIDAD CON ESE NOMBRE");
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

