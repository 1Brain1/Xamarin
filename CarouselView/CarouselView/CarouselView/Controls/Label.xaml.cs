using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Label
{
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(Label), string.Empty, BindingMode.TwoWay);

    public static readonly BindableProperty FontSizeProperty =
        BindableProperty.Create(nameof(FontSize), typeof(double), typeof(Label), 12d, BindingMode.TwoWay);

    public static readonly BindableProperty TextColorProperty =
        BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(Label), Color.White, BindingMode.TwoWay);

    public static readonly BindableProperty LabelColorProperty =
        BindableProperty.Create(nameof(LabelColor), typeof(Color), typeof(Label), Color.Default, BindingMode.TwoWay);

    public static readonly BindableProperty IsVisibleLabelProperty =
        BindableProperty.Create(nameof(IsVisibleLabel), typeof(bool), typeof(Label), true, BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    [TypeConverter(typeof(FontSizeConverter))]
    public double FontSize
    {
        get => (double)GetValue(FontSizeProperty);
        set => SetValue(FontSizeProperty, value);
    }
    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public Color LabelColor
    {
        get => (Color)GetValue(LabelColorProperty);
        set => SetValue(LabelColorProperty, value);
    }

    public bool IsVisibleLabel
    {
        get => (bool)GetValue(IsVisibleLabelProperty);
        set => SetValue(IsVisibleLabelProperty, value);
    }

    public Label()
    {
        InitializeComponent();
    }
}