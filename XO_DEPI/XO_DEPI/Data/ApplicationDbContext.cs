using Microsoft.EntityFrameworkCore;

namespace XO_DEPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{


			base.OnModelCreating(modelBuilder);
		}
	}
}
