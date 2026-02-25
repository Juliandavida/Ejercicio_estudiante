Console.WriteLine("Hello, World!");
public class Seguros
{
	public int Id { get; set; }
	public string? Compañia { get; set; }
	public DateTime FechaSeguro { get; set; }
	public bool Vencido { get; set; }

	public Vehiculos? _Vehiculo { get; set; }
}
public class Empleados
{
	public int Id { get; set; }
	public string? Cedula { get; set; }
	public string? Nombre { get; set; }

	public DateTime FechaNacimiento { get; set; }
	public decimal Sueldo { get; set; }
	public bool	Activo { get; set; }

	public List<Ventas>? Ventas { get; set; }
}
public class Clientes
{
	public int Id { get; set; }
	public string? Cedula { get; set; }
	public string? Nombre { get; set; }

	public DateTime FechaNacimiento { get; set; }
	public decimal Sueldo { get; set; }
	public bool Activo { get; set; }

	public List<Ventas>? Ventas { get; set; }
}
public class Vehiculos
{
	public int Id { get; set; }
	public string? Marca { get; set; }

	public DateTime Modelo { get; set; }
	public decimal Valor { get; set; }
	public bool Disponible { get; set; }
	public int Seguro { get; set; }
	public int Venta { get; set; }
	public List<Seguros>? Seguros { get; set; }
	public Ventas? _Venta { get; set; }
}
public class Ventas
{
	public int Id { get; set; }

	public DateTime FechaVenta { get; set; }
	public bool cancelado { get; set; }
	public int Vehiculo { get; set; }
	public int Empleado { get; set; }

	public Empleados? _Empleado { get; set; }
	public List<Vehiculos>? _Vehiculos { get; set; }

}
