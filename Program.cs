using Models;

using SqliteDotNet.Models;

using System.Threading.Tasks;

namespace SqliteDotNet
{
	class Program
	{
		/// <summary>
		/// Descripción: Este programa hace uso de EntityFrameWorkCore para crear crear un archivo de una base de datos Sqlite dentro de a carpeta bin de este mismo Proyecto.
		/// </summary>
		static async Task Main()
		{
			string database = "dbSqlite.db";
			using (var db_vehiculos = new DatabaseDbContext(database))
			{
				await db_vehiculos.Database.EnsureCreatedAsync();
				Vehiculo[] vehiculos = new Vehiculo[] {
					new Vehiculo()
					{
						id = 1,
						nombre = "Juan",
						capacidad = 8,
						tipo_vehiculo = "mi tipo",
						oficina ="donde Juan",
						ciudad = "donde vive Juan",
						pais = "paisano",
						precio = 4000
					},
					new Vehiculo()
					{
						id = 2,
						nombre = "Pedro",
						capacidad = 4,
						tipo_vehiculo = "el tipo de pedro",
						oficina ="donde Pedro",
						ciudad = "donde vive Pedro",
						pais = "extrangero",
						precio = 5000
					}
				};

				foreach (Vehiculo vehiculo in vehiculos)
					db_vehiculos.Vehiculo.Add(vehiculo);

				await db_vehiculos.SaveChangesAsync();
			}
		}
	}
}
