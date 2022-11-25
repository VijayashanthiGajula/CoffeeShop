using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace CoffeeShop;

public partial class Map : ContentPage
{
	public Map()
	{
		InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        var cafe = new Location(-36.86798491396056, 174.77575463986602);

        MapSpan mapSpan = MapSpan.FromCenterAndRadius(cafe, Distance.FromKilometers(3));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Jules Cafe",
            Location = cafe,
        });
    }
}