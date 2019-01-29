using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRetailNetwork.Models {
	public class CarDealer	{
		// DataBase Id
		public long						Id							{ get; set; }
		// commarcial ID
		public string					CommarcialId				{ get; set; }
		// Commercial Name
		public string					Name						{ get; set; }
		// Normalized Address info
		public Address					Address						{ get; set; }

		// Cars which belong to this dealer
		public List<Car>                Cars						{ get; set; }
	}
}
