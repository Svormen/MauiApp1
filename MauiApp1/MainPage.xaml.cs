namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnContinueClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///Rules");
	}
}

