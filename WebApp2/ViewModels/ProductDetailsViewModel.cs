using WebApp2.Models.Entities;

namespace WebApp2.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int? CategoryId { get; set; }
        public CategoryEntity? Category { get; set; }

        public List<GridCollectionCardViewModel> RelatedList { get; set; } = new List<GridCollectionCardViewModel>();
    }
}
