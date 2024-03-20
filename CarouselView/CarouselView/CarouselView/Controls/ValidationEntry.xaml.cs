using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CarouselView.Core.Resources;
using CarouselView.Core.Validation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValidationEntry
    {
        public static readonly BindableProperty ValidatableTextProperty = BindableProperty.Create(
            nameof(ValidatableText), typeof(ValidatableObject<string>),
            typeof(ValidationEntry), default(ValidatableObject<string>), BindingMode.TwoWay);


        public static readonly BindableProperty PlaceHolderProperty = BindableProperty.Create(nameof(PlaceHolder),
            typeof(string),
            typeof(ValidationEntry), default(string), BindingMode.TwoWay);


        public static readonly BindableProperty EntryBackgroundColorProperty = BindableProperty.Create(
            nameof(EntryBackgroundColor), typeof(Color),
            typeof(ValidationEntry), Color.White, BindingMode.TwoWay);


        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor),
            typeof(Color),
            typeof(ValidationEntry), Color.Black, BindingMode.TwoWay);


        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword),
            typeof(bool),
            typeof(ValidationEntry), default(bool), BindingMode.TwoWay);


        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor),
            typeof(Color),
            typeof(ValidationEntry), Color.Black, BindingMode.TwoWay);


        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create(nameof(ReturnType),
            typeof(ReturnType),
            typeof(ValidationEntry), ReturnType.Next, BindingMode.TwoWay);


        public static readonly BindableProperty ReturnCommandProperty = BindableProperty.Create(nameof(ReturnCommand),
            typeof(ICommand),
            typeof(ValidationEntry), default(ICommand), BindingMode.TwoWay);


        public static readonly BindableProperty TextAlignmentProperty = BindableProperty.Create(nameof(TextAlignment),
            typeof(TextAlignment),
            typeof(ValidationEntry), default(TextAlignment), BindingMode.TwoWay);


        public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(nameof(Keyboard),
            typeof(Keyboard),
            typeof(ValidationEntry), default(Keyboard), BindingMode.TwoWay);


        public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create(nameof(MaxLength),
            typeof(int),
            typeof(ValidationEntry), int.MaxValue, BindingMode.TwoWay);


        public static readonly BindableProperty IconErrorColorProperty = BindableProperty.Create(nameof(IconErrorColor),
            typeof(Color),
            typeof(ValidationEntry), Color.Red, BindingMode.TwoWay);


        public static readonly BindableProperty TextErrorColorProperty = BindableProperty.Create(nameof(TextErrorColor),
            typeof(Color),
            typeof(ValidationEntry), Color.Red, BindingMode.TwoWay);


        public static readonly BindableProperty ValidatedColorProperty = BindableProperty.Create(nameof(ValidatedColor),
            typeof(Color),
            typeof(ValidationEntry), Color.Green, BindingMode.TwoWay);


        public static readonly BindableProperty PlaceHolderTextTransformProperty = BindableProperty.Create(nameof(PlaceHolderTextTransform), 
            typeof(TextTransform), 
            typeof(ValidationEntry), TextTransform.Uppercase, BindingMode.TwoWay);


        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius),
            typeof(double),
            typeof(ValidationEntry), 20d);


        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create(nameof(FontAttributes),
            typeof(FontAttributes),
            typeof(ValidationEntry), FontAttributes.None);


        public ValidationEntry()
        {
            InitializeComponent();
        }

        public ValidatableObject<string> ValidatableText
        {
            get => (ValidatableObject<string>)GetValue(ValidatableTextProperty);
            set => SetValue(ValidatableTextProperty, value);
        }

        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set => SetValue(PlaceHolderProperty, value);
        }

        public Color EntryBackgroundColor
        {
            get => (Color)GetValue(EntryBackgroundColorProperty);
            set => SetValue(EntryBackgroundColorProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public bool IsPassword
        {
            get => (bool)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public ReturnType ReturnType
        {
            get => (ReturnType)GetValue(ReturnTypeProperty);
            set => SetValue(ReturnTypeProperty, value);
        }

        public ICommand ReturnCommand
        {
            get => (ICommand)GetValue(ReturnCommandProperty);
            set => SetValue(ReturnCommandProperty, value);
        }

        public TextAlignment TextAlignment
        {
            get => (TextAlignment)GetValue(TextAlignmentProperty);
            set => SetValue(TextAlignmentProperty, value);
        }

        public Keyboard Keyboard
        {
            get => (Keyboard)GetValue(KeyboardProperty);
            set => SetValue(KeyboardProperty, value);
        }

        public int MaxLength
        {
            get => (int)GetValue(MaxLengthProperty);
            set => SetValue(MaxLengthProperty, value);
        }

        public Color IconErrorColor
        {
            get => (Color)GetValue(IconErrorColorProperty);
            set => SetValue(IconErrorColorProperty, value);
        }

        public Color TextErrorColor
        {
            get => (Color)GetValue(TextErrorColorProperty);
            set => SetValue(TextErrorColorProperty, value);
        }

        public Color ValidatedColor
        {
            get => (Color)GetValue(ValidatedColorProperty);
            set => SetValue(ValidatedColorProperty, value);
        }


        public TextTransform PlaceHolderTextTransform
        {
            get => (TextTransform)GetValue(PlaceHolderTextTransformProperty);
            set => SetValue(PlaceHolderTextTransformProperty, value);
        }

        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public FontAttributes FontAttributes
        {
            get => (FontAttributes)GetValue(FontAttributesProperty);
            set => SetValue(FontAttributesProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == ValidatableTextProperty.PropertyName && ValidatableText != null) SetValidatableObject();
            if (propertyName == PlaceHolderProperty.PropertyName)
                TopPlaceHolder.TranslationX = PlaceHolder.Length * 1.2;
            if ((propertyName == IsEnabledProperty.PropertyName || propertyName == BorderColorProperty.PropertyName) && !IsEnabled)
                BorderView.Opacity = 0.6;
        }

        private void SetValidatableObject()
        {
            if (ValidatableText == null) return;
            ValidatableText.PropertyChanged -= ValidatableText_PropertyChanged;
            ValidatableText.PropertyChanged += ValidatableText_PropertyChanged;
        }


        private void ValidatableText_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ValidatableText.IsValid) && ValidatableText.Value != null)
                SetValid();
        }

        private void SetValid()
        {
            if (ValidatableText.Validations?.Count > 0 && IsEnabled)
            {
                ErrorLabel.IsVisible = !ValidatableText.IsValid;
                IconView.Text = ValidatableText.IsValid ? IconFont.Valid : IconFont.Close;
                IconView.TextColor = ValidatableText.IsValid ? ValidatedColor : IconErrorColor;
            }
            else
            {
                ErrorLabel.IsVisible = false;
                IconView.Text = string.Empty;
            }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidatableText == null) return;

            ValidatableText.Value = e.NewTextValue;
            var isEmptyText = string.IsNullOrEmpty(ValidatableText.Value);
            TopPlaceHolder.FadeTo(isEmptyText ? 0 : 1);
            TopPlaceHolder.TranslateTo(isEmptyText ? PlaceHolder.Length * 1.2 : 0, isEmptyText ? 28 : 0, 250,
                Easing.CubicOut);
            TopPlaceHolder.ScaleTo(isEmptyText ? 1.5 : 1);

            if (ValidatableText.IsSecondPartOfPair) return;
            ValidatableText.Validate();
            SetValid();
        }
    }
}