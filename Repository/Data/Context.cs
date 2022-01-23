using Business.Enties;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository.Data
{
	public class Context : DbContext
	{
		public DbSet<Client> Clients { get; set; }
		public DbSet<Estate> Estates { get; set; }
		public DbSet<Realtor> Realtors { get; set; }
		public DbSet<Deal> Deals { get; set; }
		public DbSet<EstateType> EstateTypes { get; set; }
		public DbSet<Street> Streets { get; set; }
		public DbSet<District> Districts { get; set; }
		public DbSet<Town> Towns { get; set; }

		public Context(DbContextOptions<Context> options) : base(options) 
		{
			Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			foreach (var relationship in modelbuilder.Model
				.GetEntityTypes()
				.Where(e => !e.IsOwned())
				.SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}
		}
	}
}
