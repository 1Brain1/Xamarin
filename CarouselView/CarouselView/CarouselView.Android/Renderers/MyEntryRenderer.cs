using System;
using CarouselView.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;
using TextAlignment = Android.Views.TextAlignment;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace CarouselView.Droid.Renderers
{
    [Obsolete]
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;
            Control.SetBackgroundResource(Color.Transparent);
            Control.SetBackgroundColor(Color.Transparent);
            Control.SetPadding(0, 0, 0, 0);
            Control.TextAlignment = TextAlignment.TextStart;
            Control.SetTextColor(Color.Black);
        }
    }
}