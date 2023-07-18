using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupHeader
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
            typeof(string),
            typeof(PopupHeader), string.Empty, BindingMode.TwoWay);

        public PopupHeader()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
    }
}