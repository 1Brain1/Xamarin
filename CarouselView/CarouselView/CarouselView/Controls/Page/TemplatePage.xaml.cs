using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemplatePage : ContentView
    {
        public TemplatePage()
        {
            InitializeComponent();
        }

        public string PageTitle
        {
            get => HeaderLabel.Text;
            set => HeaderLabel.Text = value;
        }

        public View Body
        {
            get => BodyContent.Content;
            set => BodyContent.Content = value;
        }

        public View Footer
        {
            get => FooterContent.Content;
            set => FooterContent.Content = value;
        }
    }
}