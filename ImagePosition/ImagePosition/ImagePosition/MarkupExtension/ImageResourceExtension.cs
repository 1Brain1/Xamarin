using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImagePosition.MarkupExtension
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        private const string Header = "Resources.Images.";
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var imageSource = ImageSource.FromResource(Header + Source);

            return imageSource;
        }
    }
}
