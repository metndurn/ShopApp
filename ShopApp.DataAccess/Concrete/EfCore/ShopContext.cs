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
			optionsBuilder.UseSqlServer(@"Server=MONSTER;Database=ShopDb;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		/*ıkı tane ıd kısmı var ve aynı yapı ıcındedır bunların hepsı tek tek geşmesin diye
		 burada birleştirme yapılması lazım yanı productıd ve categoryıd sınıflarında ki
		ıd lerden bahsedıyoruz bunlar aynı gelmelı amac birincil anahtarların ıkısının olmasını saglamak*/
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ProductCategory>()
				.HasKey(pc => new { pc.ProductId, pc.CategoryId });
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
