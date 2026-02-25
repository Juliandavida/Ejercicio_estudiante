Console.WriteLine("Hello, World!");

// LISTA VEHICULOS 

var lista_vehiculos = new List<Vehiculos>()
{
	new Vehiculos { Id = 1, Marca = "Onix", Modelo = new DateTime(2020, 2, 24), Valor = 60000000m, Disponible = true },
	new Vehiculos { Id = 2, Marca = "Logan", Modelo = new DateTime(2021, 5, 14), Valor = 40000000m, Disponible = false },
	new Vehiculos { Id = 3, Marca = "Hilux", Modelo = new DateTime(2025, 12, 12), Valor = 120000000m, Disponible = true }
};

// LISTA CLIENTES 

var lista_clientes = new List<Clientes>()
{
	new Clientes { Id = 1, Nombre = "Juan", Cedula = "123", FechaNacimiento = new DateTime(1995, 5, 10), Activo = true },
	new Clientes { Id = 2, Nombre = "Carlos", Cedula = "456", FechaNacimiento = new DateTime(1990, 8, 20), Activo = true },
	new Clientes { Id = 3, Nombre = "Jose", Cedula = "789", FechaNacimiento = new DateTime(1985, 3, 15), Activo = false }
};

// LISTA EMPLEADOS 

var lista_empleados = new List<Empleados>()
{
	new Empleados { Id = 1, Nombre = "Dana", Cargo = "Asesora", Sueldo = 1000000m, Activo = true }
};

// LISTA VENTAS 

var lista_ventas = new List<Ventas>()
{
	new Ventas{Id = 1,FechaVenta = DateTime.Now,Cancelado = false,ClienteId = 1,EmpleadoId = 1,VehiculoId = 1},
	new Ventas{Id = 2,FechaVenta = DateTime.Now,Cancelado = true,ClienteId = 2,EmpleadoId = 1,VehiculoId = 3}
};

//muesto la venta uno con todos sus ATRIBUTOS

var venta = lista_ventas.FirstOrDefault(x => x.Id == 1);


	var cliente = lista_clientes.FirstOrDefault(a => a.Id == venta.ClienteId);
	var empleado = lista_empleados.FirstOrDefault(b => b.Id == venta.EmpleadoId);
	var vehiculo = lista_vehiculos.FirstOrDefault(c => c.Id == venta.VehiculoId);

	Console.WriteLine("El nombre del cliente es: " + cliente?.Nombre +", el empleado: " + empleado?.Nombre + " y se vendió un modelo: " + vehiculo?.Marca);


//  CLASES 

public class Seguros
{
	public int Id { get; set; }
	public string? Compania { get; set; }
	public DateTime FechaSeguro { get; set; }

	public int VehiculoId { get; set; }   // FK
	public Vehiculos? Vehiculo { get; set; }
}


public class Empleados
{
	public int Id { get; set; }
	public string? Cargo { get; set; }
	public string? Nombre { get; set; }
	public decimal Sueldo { get; set; }
	public bool Activo { get; set; }

	public List<Ventas> Ventas { get; set; } = new();
}

public class Clientes
{
	public int Id { get; set; }
	public string? Cedula { get; set; }
	public string? Nombre { get; set; }
	public DateTime FechaNacimiento { get; set; }
	public bool Activo { get; set; }

	public List<Ventas> Ventas { get; set; } = new();
}

public class Vehiculos
{
	public int Id { get; set; }
	public string? Marca { get; set; }
	public DateTime Modelo { get; set; }
	public decimal Valor { get; set; }
	public bool Disponible { get; set; }

	public List<Seguros> Seguros { get; set; } = new();
}

public class Ventas
{
	public int Id { get; set; }
	public DateTime FechaVenta { get; set; }
	public bool Cancelado { get; set; }

	public int VehiculoId { get; set; }   // FK
	public int EmpleadoId { get; set; }   // FK
	public int ClienteId { get; set; }    // FK

	public Empleados? Empleado { get; set; }
	public Vehiculos? Vehiculo { get; set; }
	public Clientes? Cliente { get; set; }
}
