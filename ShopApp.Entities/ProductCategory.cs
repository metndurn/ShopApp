using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
	public class ProductCategory/*product ve categorylerini burada birleştirdik cunku coka cok ılıskı olması gerekiyor*/
	{
		
		public int CategoryId { get; set; }
		public Category Category { get; set; }/*diger tablodan gelen verileri burada alıyoruz*/


		public int ProductId { get; set; }
		public Product Product { get; set; }/*diger tablodan gelen verileri burada alıyoruz*/
	}
}
