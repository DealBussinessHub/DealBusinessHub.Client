namespace DealBusinessHub.UI.Services
{

    public class ThemeService
    {
        public event Action OnThemeChanged;
        private string _currentTheme = "light";

        public string CurrentTheme
        {
            get => _currentTheme;
            set
            {
                _currentTheme = value;
                OnThemeChanged?.Invoke();
            }
        }

    }
}
