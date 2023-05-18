using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private int _index = 0;
        private readonly string[] _qoutes =
        {
            "If you can't explain it simply, you don't understand it well enough.",
            "We cannot solve our problems with the same thinking we used when we created them.",
            "Only two things are infinite, the universe and human stupidity, and I'm not sure about the former."
        };

        public QuotesPage()
        {
            InitializeComponent();
            currentQuote.Text = _qoutes[_index];
        }

        private void NextQuote(object sender, System.EventArgs e)
        {
            _index++;

            if (_index >= _qoutes.Length) _index = 0;

            currentQuote.Text = _qoutes[_index];
        }
    }
}