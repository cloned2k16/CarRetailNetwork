using System.ComponentModel.DataAnnotations;

namespace CarRetailNetwork.Models
{
	public class AuditAction {
		// we suppose there may be more several actions 
		// TODO maybe we may even better move the DateTime of each action here
		[Key]
		public string					Action						{ get; set; }

	}
}