using WebApp2.Models.Entities;

namespace WebApp2.ViewModels;
public class GridCollectionCardViewModel
{
    public string Id { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public CategoryEntity? Category { get; set; }

    public static implicit operator GridCollectionCardViewModel(ProductEntity productModel)
    {
        var card = new GridCollectionCardViewModel
        {
            Id = productModel.Id.ToString(),
            Title = productModel.Name,
            Price = productModel.Price,
            ImageUrl = productModel.ImageUrl,
            Description = productModel.Description
        };
        return card;
    }

}
