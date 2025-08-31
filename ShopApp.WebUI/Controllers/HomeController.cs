using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;

namespace ShopApp.WebUI.Controllers
{
	public class HomeController : Controller
	{
		private IProductService _productService;
		public HomeController(IProductService productService)//dependency injection yani bağımlılık enjeksiyonu yapıyoruz
		{
			_productService = productService;
		}

		public IActionResult Index()
		{
			return View(_productService.GetAll());
		}
	}
}
