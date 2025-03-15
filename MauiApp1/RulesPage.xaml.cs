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
                "1. Fill the grid with numbers from 1 to 9. Each row and column must sum to the number in the blue cell",
                "2. Click on a number to select it, then click on a cell to place the number",
                "3. Click on the \"Check\" button to see if your solution is correct",
                "4. Click on the \"Hint\" button to see the correct solution",
                "5. Click on the \"New Game\" button to generate a new grid",
                "6. Click on the \"Reset\" button to clear the grid"
            };

        BindingContext = this;
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Game");
        }
    }
}
