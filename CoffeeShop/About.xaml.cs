using System;
using System.Windows.Input;

namespace CoffeeShop;

public partial class About : ContentPage
{
    // public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public About()
    {
        InitializeComponent();
        //BindingContext = this;
    }

    //private async void facebooklogoOnClick(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        Uri fb = new Uri("https://www.instagram.com/");

    //        await Browser.Default.OpenAsync(fb, BrowserLaunchMode.SystemPreferred);

    //    }
    //    catch
    //    {

    //    }

    //}
    private async void facebooklogoOnClick(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.facebook.com/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }



    private async void instagramlogoOnClick(object sender, EventArgs e)
    {
        try
        {
            Uri a = new Uri("https://www.instagram.com/");
            await Browser.Default.OpenAsync(a, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {

        }
    }
}