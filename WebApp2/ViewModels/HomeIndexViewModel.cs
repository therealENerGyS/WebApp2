namespace WebApp2.ViewModels;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Home";
    public GridCollectionViewModel FeaturedCollection { get; set; } = null!;
    public GridCollectionViewModel NewCollection { get; set; } = null!;
    public DiscountViewModel DiscountCollection { get; set; } = null!;
    public GridCollectionViewModel PopularCollection { get; set; } = null!;
    public InfoViewModel InfoCollection { get; set; } = null!;
}
