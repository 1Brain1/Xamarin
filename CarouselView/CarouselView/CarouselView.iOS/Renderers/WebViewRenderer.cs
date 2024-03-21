using CarouselView.iOS.Renderers;
using Foundation;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WKWebView), typeof(WebViewRenderer))]

namespace CarouselView.iOS.Renderers
{
    public class WebViewRenderer : WkWebViewRenderer
    {
        public override WKNavigation LoadHtmlString(NSString htmlString, NSUrl baseUrl)
        {
            try
            {
                return base.LoadHtmlString(
                    (NSString)htmlString.ToString().Insert(0,
                        "<meta name='viewport' content='width=device-width,initial-scale=1,maximum-scale=1' />"),
                    baseUrl);
            }
            catch
            {
                return base.LoadHtmlString(htmlString, baseUrl);
            }
        }
    }
}
