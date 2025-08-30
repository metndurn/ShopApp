using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
	public interface IProductService //urunler icin servis metotlari olusturmak ıcın burası lazımdır data katmanına erismek ıcın
	{
		List<Product> GetAll();//tum urunleri getirmek ıcın
		Product GetById(int id);//id ye gore urun getirmek ıcın
		void Create(Product entity);//yeni urun eklemek ıcın
		void Update(Product entity);//var olan urunu guncellemek ıcın
		void Delete(Product entity);//var olan urunu silmek ıcın

	}
}
