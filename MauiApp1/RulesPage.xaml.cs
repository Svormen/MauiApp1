namespace MauiApp1
{
    public partial class RulesPage : ContentPage
    {
        public List<string> Rules { get; set; }
        public RulesPage()
        {
            InitializeComponent();
            Rules = new List<string>
            {
                "1. Rule one: ...",
                "2. Rule two: ...",
                "3. Rule three: ..."
            };

        BindingContext = this;
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Game");
        }
    }
}
