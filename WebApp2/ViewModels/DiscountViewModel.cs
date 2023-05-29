namespace WebApp2.ViewModels;

public class DiscountViewModel
{
    public IEnumerable<DiscountCardViewModel> DiscountCard { get; set; } = null!;
    public bool DiscoverMore { get; set; } = false;
}
