using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
	public interface ICategoryDal
	{
		Category GetById(int id);/*id ye göre Category getirecek*/
		Category GetOne(Expression<Func<Category, bool>> filter);/*tek bir Category getirecek*/
		IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter);/*butun Categoryleri getirecek*/
		void Add(Category entity);/*Category ekleme*/
		void Update(Category entity);/*Category güncelleme*/
		void Delete(Category entity);/*Category silme*/
	}
}
