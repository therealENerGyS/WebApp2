using Microsoft.AspNetCore.Mvc;
using WebApp2.Services;
using WebApp2.ViewModels;

namespace WebApp2.Controllers;

public class ProductsController : Controller
{
    private readonly ProductService _product;

    public ProductsController(ProductService product)
    {
        _product = product;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new ProductIndexViewModel
        {
            All = new GridCollectionViewModel
            {
                Title = "All Products",
                GridCards = await _product.GetAllAsync()
            }
        };

        return View(viewModel);
    }

    public async Task<IActionResult> Details(int id)
    {
        var product = await _product.GetProductByIdAsync(id);

        if(product != null)
        {
            var viewModel = new ProductDetailsViewModel
            {
                Id = Convert.ToInt32(product.Id),
                Name = product.Title,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Category = product.Category,
                CategoryId = product.Category?.Id,
                RelatedList = await _product.GetRelatedAsync(4)
            };
            return View(viewModel);
        }
        else { return RedirectToAction("Index"); }
    }
}
