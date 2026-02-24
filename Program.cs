Console.WriteLine("Hello, World!");
var lista_grupos = new List<Grupos>();
lista_grupos.Add(new Grupos(){ Id = 1, Nombre = "LGTV", Descuento = 0.0m, Activo = true });
lista_grupos.Add(new Grupos() { Id = 2, Nombre = "Indige", Descuento = 0.5m, Activo = true });
lista_grupos.Add(new Grupos() { Id = 3, Nombre = "Therian", Descuento = 0.0m, Activo = true });

var lista_materias = new List<Materias>();
lista_materias.Add(new Materias() { Id = 1, Codigo = "M1", Nombre = "Calculo", Activo=true});
lista_materias.Add(new Materias() { Id = 1, Codigo = "M2", Nombre = "Logica", Activo = true});
lista_materias.Add(new Materias() { Id = 1, Codigo = "M3", Nombre = "Redes", Activo = false });

var lista_estudiantes= new List<Estudiantes>();
lista_estudiantes.Add(new Estudiantes() { Id = 1, Cedula = "479", Nombre = "Carla", Activo = true, Edad = 20, Grupo = 3 });
lista_estudiantes.Add(new Estudiantes() { Id = 2, Cedula = "854", Nombre = "Andres", Activo = false, Edad = 15, Grupo = 2 });
lista_estudiantes.Add(new Estudiantes() { Id = 3, Cedula = "236", Nombre = "Pedro", Activo = true, Edad = 70, Grupo = 1 });
lista_estudiantes.Add(new Estudiantes() { Id = 4, Cedula = "111", Nombre = "Juli", Activo = true, Edad = 30, Grupo = 2 });

var lista_notas = new List<Notas>();
lista_notas.Add(new Notas() { Id = 1, Materia = 1, Estudiante = 2, N1 = 3.0m, N2 = 4.5m, N3 = 1.0m, N4 = 2.9m, N5 = 4.0m });
lista_notas.Add(new Notas() { Id = 2, Materia = 3, Estudiante = 3, N1 = 2.0m, N2 = 3.0m, N3 = 4.0m, N4 = 2.0m, N5 = 0.0m });
lista_notas.Add(new Notas() { Id = 3, Materia = 2, Estudiante = 2, N1 = 3.5m, N2 = 4.0m, N3 = 2.9m, N4 = 1.3m, N5 = 4.2m });

//estudiantes activos
var Estudiantes_Activos = lista_estudiantes.Count(x => x.Activo);
Console.WriteLine("los estudiantes activos son: " + Estudiantes_Activos);

//promedio
var promedio_estudiante = lista_notas.FirstOrDefault(x => x.Id == 3);
decimal promedio= Calculos.Promedio(promedio_estudiante);
Console.WriteLine("el promedio es : " + promedio);

//descuento
var estudiante_descuento = lista_estudiantes.FirstOrDefault(x => x.Id == 4);
decimal descuento = Calculos.clcDesc(estudiante_descuento);
Console.WriteLine("el descuento es es : " + descuento);

public class Calculos
{
	public static decimal Promedio(Notas notas)
	{
		return (notas.N1 + notas.N2 + notas.N3 + notas.N4 + notas.N5) / 5;
	}
	public static decimal clcDesc(Estudiantes estudiante)
	{
		decimal descuento = 0m;

		if (estudiante.Edad < 18)
		{
			descuento = 0.25m; 
		}
		else if (estudiante.Edad > 60)
		{
			descuento = 0.35m; 
		}

		// mas 5% si es indigena
		if (estudiante.Grupo == 2)
		{ 
			descuento += 0.05m; 
		}

		return descuento;
	}
}

public class Grupos
{ 
	public int Id { get; set; }
	public string? Nombre { get; set; }
	public decimal Descuento { get; set; }
	public bool Activo { get; set; }
	public List<Estudiantes>? Estudiante { get; set; }
}
public class Materias

{
	public int Id { get; set; }
	public string? Codigo { get; set; }
	public string? Nombre { get; set; }
	public bool Activo { get; set; }
	public List<Notas>? Notas { get; set; }
}

public class Estudiantes
{
	public int Id { get; set; }
	public string? Cedula { get; set; }
	public string? Nombre { get; set; }
	public bool Activo { get; set; }
	public int Edad { get; set; }
	public int Grupo { get; set; }
	public List<Notas>? Notas { get; set; }
	public Grupos? _Grupo { get; set; }
}
public class Notas
{
	public int Id { get; set; }
	public int Materia { get; set; }
	public int Estudiante { get; set; }
	public decimal N1 { get; set; }
	public decimal N2 { get; set; }
	public decimal N3 { get; set; }
	public decimal N4 { get; set; }
	public decimal N5 { get; set; }
	public decimal NF { get; set; }
	public Estudiantes? _Estudiante { get; set; }
	public Materias? _Materia { get; set; }
}