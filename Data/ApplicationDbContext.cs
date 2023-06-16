using System;
using Microsoft.EntityFrameworkCore;
using AbbyWeb.Model;

namespace AbbyWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Category> Category { get; set; }
	}
}

