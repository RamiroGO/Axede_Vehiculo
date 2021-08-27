using System.Reflection;

using Microsoft.EntityFrameworkCore;

using SqliteDotNet.Models;

namespace Models
{
	class DatabaseDbContext : DbContext
	{
		private string database;

		internal DatabaseDbContext(string database) => this.database = database;

		internal DbSet<Vehiculo> Vehiculo { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(connectionString: "Filename=" + database, sqliteOptionsAction: op =>
			{
				op.MigrationsAssembly(
					Assembly.GetExecutingAssembly().FullName);
			});
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder model_build)
		{
			model_build.Entity<Vehiculo>().ToTable("Vehiculo");
			model_build.Entity<Vehiculo>(entity =>
			{
				entity.HasKey(e => e.id);
			});

			base.OnModelCreating(model_build);
		}
	}
}
