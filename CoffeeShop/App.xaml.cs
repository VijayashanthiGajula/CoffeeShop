namespace CoffeeShop;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        var navpage = new NavigationPage(new MainPage());
        //var navpage = new NavigationPage(new Views.Menu());
       // navpage.BarBackground = Colors.RosyBrown;

		//navpage.BarTextColor = Colors.White;

        MainPage =navpage;
    }
}
