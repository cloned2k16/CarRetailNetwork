using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRetailNetwork.Models {
	public class RetailNetworkContext : DbContext {

		public RetailNetworkContext(DbContextOptions<RetailNetworkContext> options): base(options)	{
		}

		public DbSet<CarDealer>			Dealers						{ get; set; }
	}
}
