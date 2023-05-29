using WebApp2.Models;

namespace WebApp2.Services
{
    public class ShowcaseService
    {
        private readonly List<ShowcaseModel> _showcases = new()
        {
            new ShowcaseModel()
            {
                SmallTitle = "WELCOME TO BMERKETO SHOP",
                Title = "Exclusive Chair gold Collection.",
                ImageUrl = "images/placeholders/625x647.svg",
                Button = new LinkButtonModel
                {
                    Content = "SHOP NOW",
                    Url = "/products",
                }
            }
        };

        public ShowcaseModel GetLatest()
        {
            return _showcases.LastOrDefault()!;
        }
    }
}
