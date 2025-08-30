using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
	public class CategoryManager : ICategoryService //service katmanında kategorilerle ilgili operasyonları gerceklestirecek olan sinif
	{
		EfCoreCategoryDal _categoryDal = new EfCoreCategoryDal();

		public CategoryManager(EfCoreCategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Create(Category entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAll()
		{
			return _categoryDal.GetAll().ToList();
		}

		public void Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
