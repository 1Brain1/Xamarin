using Android.Content;
using Android.Graphics.Drawables;
using CarouselView.Controls;
using CarouselView.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;
using TextAlignment = Android.Views.TextAlignment;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyCustomEntryRenderer))]

namespace CarouselView.Droid.Renderers
{
    public class MyCustomEntryRenderer : EntryRenderer
    {
        public MyCustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;
            Control.SetBackgroundResource(Color.Transparent);
            Control.SetBackgroundColor(Color.Transparent);
            Control.SetPadding(0, 0, 0, 0);
            Control.TextAlignment = TextAlignment.ViewStart;
            Control.SetTextColor(Color.Black);
            Control.SetHighlightColor(Color.Gray);


            var gd = new GradientDrawable();
            gd.SetColor(Color.White);
            gd.SetCornerRadius(10);
            gd.SetStroke(2, Color.LightGray);


#pragma warning disable 618
            Control.SetBackgroundDrawable(gd);
#pragma warning restore 618
            Control.SetHintTextColor(Color.Gray);
        }
    }
}