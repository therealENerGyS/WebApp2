using Microsoft.EntityFrameworkCore;
using WebApp2.Context;
using WebApp2.ViewModels;

namespace WebApp2.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        //Get all products
        public async Task<List<GridCollectionCardViewModel>> GetAllAsync()
        {
            var products = await _context.Products
                .Cast<GridCollectionCardViewModel>()
                .ToListAsync();
            return products;
        }

        //Get certain amounts of products from a category
        public async Task<List<GridCollectionCardViewModel>> GetProductsByCategoryAsync(int productsAmount)
        {
            var products = await _context.Products
                .Cast<GridCollectionCardViewModel>()
                .Take(productsAmount)
                .ToListAsync();
            return products;
        }

        public async Task<GridCollectionCardViewModel> GetProductByIdAsync(int id)
        {
            var product = await _context.Products
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return product!;
        }

        public async Task EditProductAsync(int id, GridCollectionCardViewModel updatedCard)
        {
            var product = await _context.Products.FindAsync(id);
            if(product != null)
                if(updatedCard != null)
                {
                    product.Name = updatedCard.Title;
                    product.Price = updatedCard.Price;
                    product.Description = updatedCard.Description;
                    product.ImageUrl = updatedCard.ImageUrl;
                }
            await _context.SaveChangesAsync();
        }

        public async Task RemoveProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if(product != null)
                _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<GridCollectionCardViewModel>> GetRelatedAsync(int productAmount)
        {
            var products = await _context.Products
                .Cast<GridCollectionCardViewModel>()
                .Take(productAmount)
                .ToListAsync();
            return products;
        }
    }
}
