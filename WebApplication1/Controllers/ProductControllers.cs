using System;

public class ProductController : Controller
{
	public ProductController()
	{
	}

	protected IActionResult Index()
	{
		var listOfProducts = _dbContext.Products.ToList();

		return View(listOfProducts);

	}
}
