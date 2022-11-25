namespace CoffeeShop;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

	private async void OnButton_Clicked(object sender, EventArgs e)
	{
	 
        await Navigation.PushAsync(new Espresso());
    }

    private async  void OnHot_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new HotDrinks());

    }
    private async void OnCold_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ColdDrinks());

    }

    private async void OnQuick_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuickBites());
    }
}