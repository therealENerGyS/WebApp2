using WebApp2.Models.Entities;

namespace WebApp2.ViewModels;

public class DiscountCardViewModel
{
    public string Id { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
