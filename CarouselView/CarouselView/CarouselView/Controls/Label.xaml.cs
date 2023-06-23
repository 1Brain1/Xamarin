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

    public static readonly BindableProperty FontAttributesProperty =
        BindableProperty.Create(nameof(FontAttributes), typeof(FontAttributes), typeof(Button), FontAttributes.Bold, BindingMode.TwoWay);
    
    public static readonly BindableProperty TextTransformProperty =
        BindableProperty.Create(nameof(FontAttributes), typeof(TextTransform), typeof(Button), TextTransform.Uppercase, BindingMode.TwoWay);

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

    public FontAttributes FontAttributes
    {
        get => (FontAttributes)GetValue(FontAttributesProperty);
        set => SetValue(FontAttributesProperty, value);
    }

    public TextTransform TextTransform
    {
        get => (TextTransform)GetValue(TextTransformProperty);
        set => SetValue(TextTransformProperty, value);
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