using System;
using CarouselView.Core;
using FFImageLoading.Svg.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.MarkupExtension
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var isSvg = Source.EndsWith(".svg");

            if (isSvg)
            {
                var svgImageSource = SvgImageSource.FromResource(Constants.ImagesFolder + Source);
                return svgImageSource;
            }

            var imageSource = ImageSource.FromResource(Constants.ImagesFolder + Source);

            return imageSource;
        }
    }
}