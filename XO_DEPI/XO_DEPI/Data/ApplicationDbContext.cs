using Microsoft.EntityFrameworkCore;
using XO_DEPI.Core.Models;

namespace XO_DEPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
		}
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
		{
		}
		public DbSet<Battle> battles { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Battle>().HasKey(c => new
			{
				c.FirstPlayer,
				c.SecondPlayer
			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
