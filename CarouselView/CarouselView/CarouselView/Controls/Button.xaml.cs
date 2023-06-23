using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Button
{

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(Button), string.Empty, BindingMode.TwoWay);

    public static readonly BindableProperty FontSizeProperty =
        BindableProperty.Create(nameof(FontSize), typeof(double), typeof(Button), 12d, BindingMode.TwoWay);

    public static readonly BindableProperty TextColorProperty =
        BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(Button), Color.White, BindingMode.TwoWay);
    
    public static readonly BindableProperty FontAttributesProperty =
        BindableProperty.Create(nameof(FontAttributes), typeof(FontAttributes), typeof(Button), FontAttributes.Bold, BindingMode.TwoWay);

    public static readonly BindableProperty IsIconVisibleProperty =
        BindableProperty.Create(nameof(IsIconVisible), typeof(bool), typeof(Button), true, BindingMode.TwoWay);
    
    public static readonly BindableProperty SourceProperty =
        BindableProperty.Create(nameof(Source), typeof(ImageSource), typeof(Button), default(ImageSource), BindingMode.TwoWay);
    
    public static readonly BindableProperty IconScaleProperty =
        BindableProperty.Create(nameof(IconScale), typeof(double), typeof(Button), 1d, BindingMode.TwoWay);


    public Button()
    {
        InitializeComponent();
    }

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

    public FontAttributes FontAttributes
    {
        get => (FontAttributes)GetValue(FontAttributesProperty);
        set => SetValue(FontAttributesProperty, value);
    }

    public bool IsIconVisible
    {
        get => (bool)GetValue(IsIconVisibleProperty);
        set => SetValue(IsIconVisibleProperty, value);
    }

    public ImageSource Source
    {
        get => (ImageSource)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public double IconScale
    {
        get => (double)GetValue(IconScaleProperty);
        set => SetValue(IconScaleProperty, value);
    }
}