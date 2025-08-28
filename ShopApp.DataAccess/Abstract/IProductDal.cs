using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
	public interface IProductDal //metotları buraya yazacağız
	{
		Product GetById(int id);/*id ye göre ürünü getirecek*/
		Product GetOne(Expression<Func<Product, bool>> filter);/*tek bir ürün getirecek*/
		IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter);/*butun ürünleri getirecek*/
		void Add(Product entity);/*ürün ekleme*/
		void Update(Product entity);/*ürün güncelleme*/
		void Delete(Product entity);/*ürün silme*/
	}
}
