using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
	public class ProductManager : IProductService //service katmanında urunlerle ilgili operasyonları gerceklestirecek olan sinif
	{
		private IProductDal _productDal; //bunu interface olarak tanımladık ki farklı veri erişim katmanlarıyla çalışabilelim

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Create(Product entity)
		{
			_productDal.Add(entity);
		}

		public void Delete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public List<Product> GetAll()
		{
			return _productDal.GetAll().ToList();
		}

		public Product GetById(int id)
		{
			return _productDal.GetById(id);
		}

		public void Update(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}
