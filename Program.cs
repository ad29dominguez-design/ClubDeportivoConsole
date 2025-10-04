
using ClubDeportivo.Domain;

var app = new App();
app.Run();

class App
{
    private readonly List<Persona> personas = new();
    private readonly List<Socio> socios = new();
    private readonly List<Actividad> actividades = new();
    private readonly List<Inscripcion> inscripciones = new();

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Club Deportivo (Demo Consola) ===");
            Console.WriteLine("1) Alta Persona");
            Console.WriteLine("2) Alta Socio (desde Persona)");
            Console.WriteLine("3) Alta Actividad");
            Console.WriteLine("4) Listar Personas / Socios / Actividades");
            Console.WriteLine("5) Inscribir Persona en Actividad");
            Console.WriteLine("6) Listar Inscripciones");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");
            var op = Console.ReadLine();

            switch (op)
            {
                case "1": AltaPersona(); break;
                case "2": AltaSocio(); break;
                case "3": AltaActividad(); break;
                case "4": Listados(); break;
                case "5": Inscribir(); break;
                case "6": ListarInscripciones(); break;
                case "0": return;
                default: Console.WriteLine("Opción inválida"); Pause(); break;
            }
        }
    }

    void AltaPersona()
    {
        Console.Write("IdPersona: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nombre: ");
        string nom = Console.ReadLine() ?? "";
        Console.Write("Apellido: ");
        string ape = Console.ReadLine() ?? "";
        Console.Write("DNI: ");
        string dni = Console.ReadLine() ?? "";
        var p = new Persona { IdPersona = id, Nombre = nom, Apellido = ape, Dni = dni, FechaNacimiento = DateTime.Now.AddYears(-20) };
        personas.Add(p);
        Console.WriteLine("Persona creada.");
        Pause();
    }

    void AltaSocio()
    {
        Console.Write("IdPersona existente: ");
        int idp = int.Parse(Console.ReadLine() ?? "0");
        var p = personas.Find(x => x.IdPersona == idp);
        if (p == null) { Console.WriteLine("No existe Persona."); Pause(); return; }

        Console.Write("IdSocio: ");
        int ids = int.Parse(Console.ReadLine() ?? "0");
        var s = new Socio
        {
            IdSocio = ids,
            IdPersona = idp,
            FechaAlta = DateTime.Today,
            FechaVencimientoCuota = DateTime.Today.AddMonths(1),
            EstadoMembresia = "ACTIVO",
            TipoSocio = "adulto",
            AptoFisico = false,
            PagoCuota = false,
            Persona = p
        };
        socios.Add(s);
        Console.WriteLine("Socio creado.");
        Pause();
    }

    void AltaActividad()
    {
        Console.Write("IdActividad: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nombre: ");
        string nom = Console.ReadLine() ?? "";
        var a = new Actividad { IdActividad = id, Nombre = nom, IdProfesor = 0 };
        actividades.Add(a);
        Console.WriteLine("Actividad creada.");
        Pause();
    }

    void Listados()
    {
        Console.WriteLine("\n-- Personas --");
        personas.ForEach(p => Console.WriteLine($"{p.IdPersona} - {p}"));
        Console.WriteLine("\n-- Socios --");
        socios.ForEach(s => Console.WriteLine($"{s.IdSocio} - Persona:{s.IdPersona} Estado:{s.EstadoMembresia} Apto:{s.AptoFisico}"));
        Console.WriteLine("\n-- Actividades --");
        actividades.ForEach(a => Console.WriteLine($"{a.IdActividad} - {a.Nombre}"));
        Pause();
    }

    void Inscribir()
    {
        Console.Write("IdPersona a inscribir: ");
        int idp = int.Parse(Console.ReadLine() ?? "0");
        var p = personas.Find(x => x.IdPersona == idp);
        if (p == null) { Console.WriteLine("No existe Persona."); Pause(); return; }

        Console.Write("IdActividad: ");
        int ida = int.Parse(Console.ReadLine() ?? "0");
        var a = actividades.Find(x => x.IdActividad == ida);
        if (a == null) { Console.WriteLine("No existe Actividad."); Pause(); return; }

        var ins = new Inscripcion { IdPersona = idp, IdActividad = ida, Fecha = DateTime.Now };
        inscripciones.Add(ins);
        Console.WriteLine("Inscripción registrada.");
        Pause();
    }

    void ListarInscripciones()
    {
        Console.WriteLine("\n-- Inscripciones --");
        foreach (var ins in inscripciones)
        {
            Console.WriteLine($"Persona {ins.IdPersona} -> Actividad {ins.IdActividad} ({ins.Fecha})");
        }
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}
