using System.Globalization;
using System.IO;
using System;
using Xamarin.Forms;

namespace CarouselView.Converters;

class Base64ToImageConverter : IValueConverter
{

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        try
        {
            var byteArray = System.Convert.FromBase64String((string)value);
            Stream stream = new MemoryStream(byteArray);
            var imageSource = ImageSource.FromStream(() => stream);
            return imageSource;
        }
        catch
        {
            return value;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}