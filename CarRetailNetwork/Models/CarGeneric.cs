using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRetailNetwork.Models {
	public class CarGeneric	{


		// the Car dealer
		public CarDealer				Dealer						{ get; set; }

		// the Car Brand
		public CarBrand					Brand						{ get; set; }
		
		// the Car Tachimeter counter		( expressed in hundred metters ? )
		public long						Kilometers					{ get; set; }

	}
}
