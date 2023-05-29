namespace WebApp2.ViewModels;

public class ProductIndexViewModel
{
    public string Title { get; set; } = "Products";
    public GridCollectionViewModel All { get; set; } = null!;
}
