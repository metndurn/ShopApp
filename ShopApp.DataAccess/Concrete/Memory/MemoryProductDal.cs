using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.Memory
{
	public class MemoryProductDal : IProductDal //bellekte veri tutan bir veri erişim katmanı
	{
		public void Add(Product entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Product entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
		{
			var products = new List<Product>//bellekte veri tutan bir liste
			{
				new Product{Id=1, Name="Samsung S7", Price=15000, ImageUrl="1.jpg"},
				new Product{Id=2, Name="Samsung A24", Price=25000, ImageUrl="2.jpg"},
				new Product{Id=3, Name="Redmi 15", Price=10000, ImageUrl="3.jpg"},
			};
			return products;//bellekteki listeyi döndürüyoruz
		}

		public Product GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Product GetOne(Expression<Func<Product, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> GetPopularProducts()
		{
			throw new NotImplementedException();
		}

		public void Update(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
