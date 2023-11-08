namespace MonoGCDumpRepro;

public partial class MainPage : ContentPage
{
	int count = 0;
	CarouselView carouselView;

	public MainPage()
	{
		InitializeComponent();
		RunAsync();
	}

	async void RunAsync()
	{
		await Task.Delay(5000);
		carouselView = new CarouselView();
		MainStackLayout.Children.Add(carouselView);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

