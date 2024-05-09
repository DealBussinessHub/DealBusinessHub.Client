using DealBusinessHub.UI.Repositories;

namespace DealBusinessHub.UI.Services
{
    public class GlobalService : IGlobalService
    {
        public string AuthPageTitle { get; set; }
        public string AuthPageDescription { get; set; }

      
        public void SetAuthLayout(string title, string description)
        {
            AuthPageTitle = title;
            AuthPageDescription = description;
        }

    }
}
