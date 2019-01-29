using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRetailNetwork.Models {
	public class Address {
		// TODO put some more normalization stuff here 
		[Key]
		public string					StreetName					{	get; set; }
		public string					StreetNumber				{	get; set; }
		public string					DoorLocation				{	get; set; }

		public string                   getNormalized				() {
			return StreetName 
					+ ", n." 
					+StreetName
					+DoorLocation!=null?"("+DoorLocation+")":"";
		}
	}
}
