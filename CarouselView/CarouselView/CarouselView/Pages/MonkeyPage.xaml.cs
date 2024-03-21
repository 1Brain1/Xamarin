using System.Collections.ObjectModel;
using System.Net.Http;
using CarouselView.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyPage : ContentPage
    {
        private const string monkeyUrl = "https://montemagno.com/monkeys.json";
        private readonly HttpClient _httpClient = new HttpClient();

        public ObservableCollection<Monkey> Monkeys { get; set; } = new ObservableCollection<Monkey>();

        public MonkeyPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var monkeyJson = await _httpClient.GetStringAsync(monkeyUrl);
            var monkeys = JsonConvert.DeserializeObject<Monkey[]>(monkeyJson);

            Monkeys?.Clear();

            foreach (var monkey in monkeys) Monkeys.Add(monkey);
        }
    }
}