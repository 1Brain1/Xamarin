using CarouselView.Controls;
using CarouselView.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyCustomEntryRenderer))]

namespace CarouselView.iOS.Renderers
{
    public class MyCustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var entry = (MyEntry)Element;

            if (Control == null) return;
            if (entry == null) return;
            Control.TextColor = UIColor.Black;
            Control.TintColor = UIColor.Black;

            Control.BorderStyle = UITextBorderStyle.RoundedRect;

            Control.ShouldReturn += textField =>
            {
                entry.InvokeCompleted();
                return true;
            };
        }
    }
}