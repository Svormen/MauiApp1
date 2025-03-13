namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnContinueClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			ControlButton.Text = $"Clicked {count} time";
		else
			ControlButton.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(ControlButton.Text);
	}
}

