using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Card
{
    public static readonly BindableProperty TextFirstRowProperty =
        BindableProperty.Create(nameof(TextFirstRow), typeof(string), typeof(Card), string.Empty, BindingMode.TwoWay);

    public static readonly BindableProperty TextColorFirstRowProperty =
        BindableProperty.Create(nameof(TextColorFirstRow), typeof(Color), typeof(Card), Color.White, BindingMode.TwoWay);

    public static readonly BindableProperty FontAttributesFirstRowProperty =
        BindableProperty.Create(nameof(FontAttributesFirstRow), typeof(FontAttributes), typeof(Button), FontAttributes.Bold, BindingMode.TwoWay);

    public static readonly BindableProperty FontSizeFirstRowProperty =
        BindableProperty.Create(nameof(FontSizeFirstRow), typeof(double), typeof(Card), 12d, BindingMode.TwoWay);

    public static readonly BindableProperty TextTransformFirstRowProperty =
        BindableProperty.Create(nameof(TextTransformFirstRow), typeof(TextTransform), typeof(Button), TextTransform.Uppercase, BindingMode.TwoWay);

    public static readonly BindableProperty TextSecondRowProperty =
        BindableProperty.Create(nameof(TextSecondRow), typeof(string), typeof(Card), string.Empty, BindingMode.TwoWay);

    public static readonly BindableProperty TextColorSecondRowProperty =
        BindableProperty.Create(nameof(TextColorSecondRow), typeof(Color), typeof(Card), Color.White, BindingMode.TwoWay);

    public static readonly BindableProperty FontAttributesSecondRowProperty =
        BindableProperty.Create(nameof(FontAttributesSecondRow), typeof(FontAttributes), typeof(Button), FontAttributes.Bold, BindingMode.TwoWay);

    public static readonly BindableProperty FontSizeSecondRowProperty =
        BindableProperty.Create(nameof(FontSizeSecondRow), typeof(double), typeof(Card), 12d, BindingMode.TwoWay);

    public static readonly BindableProperty TextTransformSecomdRowProperty =
        BindableProperty.Create(nameof(TextTransformSecomdRow), typeof(TextTransform), typeof(Button), TextTransform.Uppercase, BindingMode.TwoWay);

    public static readonly BindableProperty IsIconVisibleProperty =
        BindableProperty.Create(nameof(IsIconVisible), typeof(bool), typeof(Card), true, BindingMode.TwoWay);

    public static readonly BindableProperty SourceProperty =
        BindableProperty.Create(nameof(Source), typeof(ImageSource), typeof(Card), default(ImageSource), BindingMode.TwoWay);

    public static readonly BindableProperty IconScaleProperty =
        BindableProperty.Create(nameof(IconScale), typeof(double), typeof(Card), 1d, BindingMode.TwoWay);

    public Card()
    {
        InitializeComponent();
    }

    public string TextFirstRow
    {
        get => (string)GetValue(TextFirstRowProperty);
        set => SetValue(TextFirstRowProperty, value);
    }

    public Color TextColorFirstRow
    {
        get => (Color)GetValue(TextColorFirstRowProperty);
        set => SetValue(TextColorFirstRowProperty, value);
    }

    public FontAttributes FontAttributesFirstRow
    {
        get => (FontAttributes)GetValue(FontAttributesFirstRowProperty);
        set => SetValue(FontAttributesFirstRowProperty, value);
    }

    [TypeConverter(typeof(FontSizeConverter))]
    public double FontSizeFirstRow
    {
        get => (double)GetValue(FontSizeFirstRowProperty);
        set => SetValue(FontSizeFirstRowProperty, value);
    }

    public TextTransform TextTransformFirstRow
    {
        get => (TextTransform)GetValue(TextTransformFirstRowProperty);
        set => SetValue(TextTransformFirstRowProperty, value);
    }

    public string TextSecondRow
    {
        get => (string)GetValue(TextSecondRowProperty);
        set => SetValue(TextSecondRowProperty, value);
    }

    public Color TextColorSecondRow
    {
        get => (Color)GetValue(TextColorSecondRowProperty);
        set => SetValue(TextColorSecondRowProperty, value);
    }

    public FontAttributes FontAttributesSecondRow
    {
        get => (FontAttributes)GetValue(FontAttributesSecondRowProperty);
        set => SetValue(FontAttributesSecondRowProperty, value);
    }

    [TypeConverter(typeof(FontSizeConverter))]
    public double FontSizeSecondRow
    {
        get => (double)GetValue(FontSizeSecondRowProperty);
        set => SetValue(FontSizeSecondRowProperty, value);
    }

    public TextTransform TextTransformSecomdRow
    {
        get => (TextTransform)GetValue(TextTransformSecomdRowProperty);
        set => SetValue(TextTransformSecomdRowProperty, value);
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