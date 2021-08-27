using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDotNet.Models
{
	class Vehiculo
	{
		public int id { get; set; }
		public string nombre { get; set; }
		public int capacidad { get; set; }
		public string tipo_vehiculo { get; set; }
		public string oficina { get; set; }
		public string ciudad { get; set; }
		public string pais { get; set; }
		public int precio { get; set; }
	}
}
