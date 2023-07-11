using Xamarin.Forms;

namespace CarouselView;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        InitializeComponent();
        CurrentPage = Children[3];
    }
}
