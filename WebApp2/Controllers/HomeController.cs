using Microsoft.AspNetCore.Mvc;
using WebApp2.Context;
using WebApp2.Services;
using WebApp2.ViewModels;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _product;

        public HomeController(ProductService product)
        {
            _product = product;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                FeaturedCollection = new GridCollectionViewModel
                {
                    Title = "Best Collection",
                    Categories = new List<string> { "All", "Bags", "Dresses", "Decorations", "Essentials", "Interior", "Laptops", "Mobile", "MakeUp" },
                    GridCards = await _product.GetProductsByCategoryAsync(8)
                },
                DiscountCollection = new DiscountViewModel
                {
                    DiscountCard = new List<DiscountCardViewModel>
                    {
                        new DiscountCardViewModel { Id = "1", Title = "Table Lamp - scelerisque tempore", Price = 50, Discount = 30, ImageUrl = "images/placeholders/369x310.svg" },
                        new DiscountCardViewModel { Id = "2", Title = "Table Lamp - scelerisque tempore", Price = 50, Discount = 30, ImageUrl = "images/placeholders/369x310.svg" }
                    },
                    DiscoverMore = true
                },
                NewCollection = new GridCollectionViewModel
                {
                    GridCards = await _product.GetProductsByCategoryAsync(3)
                },
                PopularCollection = new GridCollectionViewModel
                {
                    Title = "Popular this week",
                    GridCards = await _product.GetProductsByCategoryAsync(7)
                },
                InfoCollection = new InfoViewModel
                {
                    InfoCards = new List<InfoCardViewModel>
                    {
                        new InfoCardViewModel { Id = 1, Title = "Table lamp 1562 LTG modal", Comments = 13, PostedBy = "Admin", ImageUrl = "images/placeholders/370x295.svg", Description = "Best dress for everyone ed totam velit risus viverra \r\nnobis donec recusandae perspiciatis incididuno"},
                        new InfoCardViewModel { Id = 1, Title = "Table lamp 1562 LTG modal", Comments = 13, PostedBy = "Admin", ImageUrl = "images/placeholders/370x295.svg", Description = "Best dress for everyone ed totam velit risus viverra \r\nnobis donec recusandae perspiciatis incididuno"},
                        new InfoCardViewModel { Id = 1, Title = "Table lamp 1562 LTG modal", Comments = 13, PostedBy = "Admin", ImageUrl = "images/placeholders/370x295.svg", Description = "Best dress for everyone ed totam velit risus viverra \r\nnobis donec recusandae perspiciatis incididuno"},
                    }
                }
            };

            return View(viewModel);
        }
    }
}
