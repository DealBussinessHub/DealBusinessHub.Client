namespace DealBusinessHub.Web.Repositories
{
    public interface IGlobalService
    {
        string AuthPageTitle { get; set; }
        string AuthPageDescription { get; set; }
        void SetAuthLayout(string title, string description);
    }
}