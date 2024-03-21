using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listList.ItemsSource = _coffees;
        }

        private List<Coffee> _coffees = new List<Coffee>
        {
            new Coffee { Id = 0, Roaster = "Yes Plz", Name = "Sip of Sunshine", Image = "coffeebag.png" },
            new Coffee { Id = 1, Roaster = "Yes Plz", Name = "Potent Potable", Image = "coffeebag.png" },
            new Coffee { Id = 2, Roaster = "Yes Plz", Name = "Potent Potable", Image = "coffeebag.png" },
            new Coffee { Id = 3, Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = "coffeebag.png" },
            new Coffee { Id = 4, Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = "coffeebag.png" }
        };
    }

    public class Coffee
    {
        public int Id { get; set; }
        public string Roaster { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}