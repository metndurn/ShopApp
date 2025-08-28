using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
	public class ShopContext : DbContext 
	{
		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=MONSTER;Database=ShopDb;Trusted_Connection=True;");
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
