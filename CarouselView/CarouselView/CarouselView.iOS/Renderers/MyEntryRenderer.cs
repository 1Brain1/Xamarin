using CarouselView.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]

namespace CarouselView.iOS.Renderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;
            Control.TextColor = UIColor.Black;
            Control.TintColor = UIColor.Black;

            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
