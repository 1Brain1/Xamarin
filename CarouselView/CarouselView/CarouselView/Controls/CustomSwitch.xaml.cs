using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSwitch
    {
        public static readonly BindableProperty TextProperty = BindableProperty
            .Create(nameof(Text), typeof(string), typeof(CustomSwitch), string.Empty, BindingMode.TwoWay);

        public static readonly BindableProperty FontSizeProperty = BindableProperty
            .Create(nameof(FontSize), typeof(double), typeof(CustomSwitch), 12d, BindingMode.TwoWay);

        public static readonly BindableProperty TextColorProperty = BindableProperty
            .Create(nameof(TextColor), typeof(Color), typeof(CustomSwitch), Color.White, BindingMode.TwoWay);

        public static readonly BindableProperty FontAttributesProperty = BindableProperty
            .Create(nameof(FontAttributes), typeof(FontAttributes), typeof(CustomSwitch), FontAttributes.Bold);

        public static readonly BindableProperty TextTransformProperty = BindableProperty
            .Create(nameof(TextTransform), typeof(TextTransform), typeof(CustomSwitch), TextTransform.Uppercase);

        public static readonly BindableProperty IsVisibleLabelProperty = BindableProperty
            .Create(nameof(IsVisibleLabel), typeof(bool), typeof(CustomSwitch), true, BindingMode.TwoWay);

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

        public CustomSwitch()
        {
            InitializeComponent();
        }
    }
}