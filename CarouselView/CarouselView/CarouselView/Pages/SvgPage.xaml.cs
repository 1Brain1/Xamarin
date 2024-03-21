using CarouselView.Core;
using FFImageLoading.Svg.Forms;
using FFImageLoading.Transformations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SvgPage : ContentPage
    {
        public ImageSource ImageSource { get; set; }

        public SvgImageSource Image { get; set; }

        public SvgPage()
        {
            InitializeComponent();

            var svgImageSource = SvgImageSource.FromResource(Constants.ImagesFolder + "ic_close.svg");
            ImageSource = ImageSource.FromResource(Constants.ImagesFolder + "boom.png");

            Image = svgImageSource;

            svgCachedImageControl.Source = svgImageSource;

            var color = Color.Red;

            var tintTransformation = new TintTransformation { HexColor = color.ToHex(), EnableSolidColor = true };

            svgCachedImageControl.Transformations.Add(tintTransformation);

            BindingContext = this;
        }
    }
}