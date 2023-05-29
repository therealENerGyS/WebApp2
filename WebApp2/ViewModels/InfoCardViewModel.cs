namespace WebApp2.ViewModels;

public class InfoCardViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string PostedBy { get; set; } = null!;
    public int Comments { get; set; }
    public string ImageUrl { get; set; } = null!;
}
