using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomSwitch
    {
        private const int AnimationDuration = 250;
        private const double ThumbPadding = 10;

        private double _initialX;
        private double _maxX;
        private bool _isSwitchOn;

        public MyCustomSwitch()
        {
            InitializeComponent();
            UpdateMainFrameBackgroundColor();
        }

        private void OnTaped(object sender, EventArgs eventArgs)
        {
            _isSwitchOn = !_isSwitchOn;
            InitializeSliderValues();
            UpdateThumbPosition();
            UpdateMainFrameBackgroundColor();
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    InitializeSliderValues();
                    break;

                case GestureStatus.Running:
                    var newX = _initialX + e.TotalX;
                    thumbFrame.TranslationX = Clamp(newX, 0, _maxX);
                    break;

                case GestureStatus.Completed:
                    _isSwitchOn = thumbFrame.TranslationX >= _maxX / 2; // Определяем состояние переключателя
                    UpdateThumbPosition();
                    UpdateMainFrameBackgroundColor();
                    break;
            }
        }

        private void InitializeSliderValues()
        {
            _initialX = thumbFrame.TranslationX;
            _maxX = mainFrame.Width - thumbFrame.Width - ThumbPadding;
        }

        private void UpdateThumbPosition()
        {
            thumbFrame.TranslateTo(_isSwitchOn ? _maxX : 0, 0, AnimationDuration, Easing.CubicInOut);
        }

        private void UpdateMainFrameBackgroundColor()
        {
            mainFrame.BackgroundColor = _isSwitchOn ? Color.FromHex("#60E17C") : Color.FromHex("#CCCCCC");

            // var toColor = _isSwitchOn ? Color.FromHex("#60E17C") : Color.FromHex("#CCCCCC");
            //
            // await mainFrame.FadeTo(0, AnimationDuration / 2); // Изменяем прозрачность до нуля за половину времени анимации
            // mainFrame.BackgroundColor = toColor; // Устанавливаем новый цвет фона
            // await mainFrame.FadeTo(1, AnimationDuration / 2); // Изменяем прозрачность до максимума за оставшуюся половину времени
        }

        private static double Clamp(double value, double min, double max)
        {
            return value < min ? min : value > max ? max : value;
        }
    }
}