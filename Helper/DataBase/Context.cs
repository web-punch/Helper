using Helper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DataBase
{
	internal class Context: DbContext
	{
		public DbSet <WorkType> WorkTypes { get; set; }
		public DbSet<WorkTitle> WorkTitles { get; set; }
		public DbSet<WorkPrice> WorkPrices { get; set; }
		public DbSet<Work> Works { get; set; }
		public Context() { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Data Source={Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Helper\\Helper.db");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WorkTitle>()
				.HasOne(w => w.WorkType)
				.WithMany(w => w.WorkTitles)
				.OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<WorkPrice>()
				.HasOne(w => w.WorkTitle)
				.WithMany(w => w.WorkPrices)
				.OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Work>()
				.HasOne(w => w.WorkPrice)
				.WithMany(w => w.Works)
				.OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<Work>().HasAlternateKey(w => new { w.DateTime, w.Address, w.WorkPriceId });
		}
	}
}
