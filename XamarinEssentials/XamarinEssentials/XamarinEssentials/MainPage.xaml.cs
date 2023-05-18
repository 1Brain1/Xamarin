using Xamarin.Forms;

namespace XamarinEssentials;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        slider.Value = 0.5;

        switch (Device.RuntimePlatform)
        {
            case Device.iOS:
                new Thickness(0, 20, 0, 0);
                break;
            default:
                new Thickness(0, 0, 0, 0);
                break;
        }
    }
}
