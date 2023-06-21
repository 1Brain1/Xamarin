using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class MdnDetailsPage : ContentPage
{
    public ObservableCollection<MdnDto> MdnDtos { get; set; }

    public MdnDetailsPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        MdnDtos?.Clear();

        MdnDtos = new ObservableCollection<MdnDto>
        {
            new MdnDto
            {
                Mnd = "3304324630",
                Sim = "89148000005758879720",
                Imei = "1535500225374",
                Provider = "Red",
                IsActive = true
            },

            new MdnDto
            {
                Mnd = "7172501308",
                Sim = "89148000005758880256",
                Imei = "990007043121315",
                Provider = "Purple",
                IsActive = false
            },

            new MdnDto
            {
                Mnd = "4846609115",
                Sim = "8901260853187564503",
                Imei = "352051374249487",
                Provider = "Purple",
                IsActive = true
            },

            new MdnDto
            {
                Mnd = "4847725148",
                Sim = "",
                Imei = "352051374614417",
                Provider = "Red",
                IsActive = true
            },
        };
    }
}