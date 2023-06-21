using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;

namespace CarouselView;

public partial class MainPage : ContentPage
{
    private const string monkeyUrl = "https://montemagno.com/monkeys.json";
    private readonly HttpClient _httpClient = new();

    public ObservableCollection<Monkey> Monkeys { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var monkeyJson = await _httpClient.GetStringAsync(monkeyUrl);
        var monkeys = JsonConvert.DeserializeObject<Monkey[]>(monkeyJson);

        Monkeys?.Clear();

        foreach (var monkey in monkeys)
        {
            Monkeys.Add(monkey);
        }
    }
}
