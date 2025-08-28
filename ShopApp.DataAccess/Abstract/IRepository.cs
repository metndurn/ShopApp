using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
	public interface IRepository<T>//
	{
		T GetById(int id);/*id ye göre ürünü getirecek*/
		T GetOne(Expression<Func<T, bool>> filter);/*tek bir ürün getirecek*/
		IQueryable<T> GetAll(Expression<Func<T, bool>> filter);/*butun ürünleri getirecek*/
		void Add(T entity);/*ürün ekleme*/
		void Update(T entity);/*ürün güncelleme*/
		void Delete(T entity);/*ürün silme*/
	}
}
