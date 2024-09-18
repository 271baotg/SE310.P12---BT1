using Farm.DataLayer;
using System.Data.Entity;

public class FarmDbContext : DbContext
{
	public FarmDbContext() : base("name=FarmEntities")
	{
	}

	public DbSet<Animal> Animals { get; set; }
}