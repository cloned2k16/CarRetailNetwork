using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRetailNetwork.Models {
	public class Car : CarGeneric {
		// the Car Plate ID
		[Key]
		public string					PlateID						{	get; set; }

		public CarAudit					Audit						{	get; set; }
	}
}
