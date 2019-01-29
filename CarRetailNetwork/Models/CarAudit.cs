using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRetailNetwork.Models {
	public class CarAudit {
		// Date
		[Key]
		public DateTime					Date						{ get; set; }
		// Brand 
		public CarBrand					Brand						{ get; set; }
		// Audit Result
		public List<AuditAction>		Actions						{ get; set; }

	}
}
