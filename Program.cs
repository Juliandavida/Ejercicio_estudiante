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


	string? cliente	 = lista_clientes.FirstOrDefault(a => a.Id == venta.ClienteId).Nombre;
	string? empleado = lista_empleados.FirstOrDefault(b => b.Id == venta.EmpleadoId).Nombre;
	string? vehiculo = lista_vehiculos.FirstOrDefault(c => c.Id == venta.VehiculoId).Marca;

	Console.WriteLine("El nombre del cliente es: " + cliente +", el empleado: " + empleado + " y se vendió un modelo: " + vehiculo);

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

//otroooooooooooooooooooooooooooooooooooooooo
Console.WriteLine("Hello, World!");

//restaurante

var lista_clientes = new List<Clientes>();
lista_clientes.Add(new Clientes { Id = 1, Nombre = "Yohana", Cedula = "123", FechaNacimiento = new DateTime(2005 / 02 / 02), Estado = true });
lista_clientes.Add(new Clientes { Id = 2, Nombre = "Susana", Cedula = "456", FechaNacimiento = new DateTime(1990 / 02 / 02), Estado = false });
lista_clientes.Add(new Clientes { Id = 3, Nombre = "Laura",  Cedula = "789", FechaNacimiento = new DateTime(2003 / 02 / 02), Estado = true });

var lista_ventas = new List<Ventas>();
lista_ventas.Add(new Ventas() { Id = 1, Codigo = 0001, Descuento = 0.1m, Total = 19000.0m, cliente = 1, FechaVenta = new DateTime(2025 / 02 / 02) });
lista_ventas.Add(new Ventas() { Id = 2, Codigo = 0002, Descuento = 0.2m, Total = 20000.0m, cliente = 1, FechaVenta = new DateTime(2026 / 02 / 02) });

var lista_productos = new List<Productos>();
lista_ventas.Add(new Ventas() { Id = 1, Codigo = 0001, Valor = 0.1m, Nombre = 19000.0m, FechaCreacion = new DateTime(2025 / 02 / 02), VAencido= true });
lista_ventas.Add(new Ventas() { Id = 2, Codigo = 0002, Descuento = 0.2m, Total = 20000.0m, cliente = 1, FechaVenta = new DateTime(2026 / 02 / 02) });

var lista_Ventas_Productos = new List<Ventas_Productos>();
lista_ventas.Add(new Ventas() { Cantidad = 4, Valor = 100000.0m, Id = 1, Venta =1, Producto =2});
lista_ventas.Add(new Ventas() { Cantidad = 20, Valor = 12000.0m, Id = 2, Venta =1, Producto =2});
//factura calcular osea cuanto compro un cliente 


//que clientes estan activos
var Activos_clientes = lista_clientes.Count(x => x.Estado==true);

Console.WriteLine("numero de clientes activos es: " + Activos_clientes);


public class Calculos
{

}

public class Clientes
{
	public int Id { get; set; }
	public string? Nombre { get; set; }
	public string? Cedula { get; set; }
	public DateTime FechaNacimiento { get; set; }
	public bool Estado { get; set; }

	public List<Ventas> Ventas { get; set; }
}

public class Productos
{
	public int Id { get; set; }
	public int Codigo { get; set; }
	public decimal Valor { get; set; }
	public string? Nombre { get; set; }
	public DateTime FechaCreacion { get; set; }
	public bool Vencimiento { get; set; }

	public List<Ventas_Productos> Ventas_Productos { get; set; }
}

public class Ventas
{
	public int Id { get; set; }
	public int Codigo { get; set; }
	public decimal Descuento { get; set; }
	public decimal Total { get; set; }
	public int cliente { get; set; }
	public DateTime FechaVenta { get; set; }
	public List<Ventas_Productos> Ventas_Productos { get; set; }

}

public class Ventas_Productos
{
	public int Id { get; set; }
	public int Cantidad { get; set; }
	public decimal Valor { get; set; }
	public int Venta { get; set; }
	public int Producto { get; set; }

	public Productos? _Productos { get; set; }
	public Ventas? _Ventas { get; set; }
}

