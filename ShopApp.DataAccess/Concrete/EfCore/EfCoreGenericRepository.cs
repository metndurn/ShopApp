using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
	public class EfCoreGenericRepository<T, TContext> : IRepository<T> where T : class where TContext : DbContext, new()
	{
		public void Add(T entity)
		{
			using(var context = new TContext())//ekleme işlemi için context oluşturduk
			{
				context.Set<T>().Add(entity);
				context.SaveChanges();
			}
		}

		public void Delete(T entity)
		{
			using (var context = new TContext())//silme işlemi için context oluşturduk
			{
				context.Set<T>().Remove(entity);
				context.SaveChanges();
			}
		}

		public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				return filter == null
					? context.Set<T>().ToList()//filtre null ise tüm verileri getir
					: context.Set<T>().Where(filter).ToList();//filtre null değilse filtreye göre getir
			}
		}

		public T GetById(int id)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Find(id);//id ye göre veriyi getir
			}
		}

		public T GetOne(Expression<Func<T, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Where(filter).SingleOrDefault();//id ye göre veriyi getir
			}
		}

		public void Update(T entity)
		{
			using (var context = new TContext())//güncelleme işlemi için context oluşturduk
			{
				context.Entry(entity).State = EntityState.Modified;//güncelleme işlemi
				context.SaveChanges();
			}
		}
	}
}
