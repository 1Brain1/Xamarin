using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomSwitch
    {
        private const int AnimationDuration = 250;
        private const double ThumbPadding = 4;

        private bool _isSwitchOn = true;
        private bool _isAnimationInProgress;

        public MyCustomSwitch()
        {
            InitializeComponent();
            UpdateMainFrameBackgroundColor();

            mainFrame.SizeChanged += MainFrame_SizeChanged;
            BindingContext = this;
        }


        #region PanEvent

        private double _initialX;
        private double _maxX;

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    _maxX = mainFrame.Width - thumbFrame.Width - ThumbPadding * 2;
                    _initialX = thumbFrame.TranslationX;
                    //_initialX = _isSwitchOn ? _maxX : thumbFrame.TranslationX;
                    break;

                case GestureStatus.Running:
                    var newX = _initialX + e.TotalX;
                    eTotalX.Text = e.TotalX.ToString("0");

                    thumbFrame.TranslationX = Clamp(newX, 0, _maxX);
                    TranslationX.Text = thumbFrame.TranslationX.ToString("0");
                    break;

                case GestureStatus.Completed:
                    //_isSwitchOn = _isSwitchOn ? thumbFrame.TranslationX >= _maxX - _maxX / 6 : thumbFrame.TranslationX >= _maxX / 6;
                    _isSwitchOn = thumbFrame.TranslationX >= _maxX / 2;
                    thumbFrame.TranslateTo(_isSwitchOn ? _maxX : 0, 0, AnimationDuration, Easing.CubicInOut);
                    UpdateMainFrameBackgroundColor();
                    break;
            }
        }

        private static double Clamp(double value, double min, double max)
        {
            return value < min ? min : value > max ? max : value;
        }

        #endregion


        private async void OnTaped(object sender, EventArgs eventArgs)
        {
            if (_isAnimationInProgress) return;
            _isSwitchOn = !_isSwitchOn;

            _isAnimationInProgress = true;
            await UpdateThumbPosition();
            _isAnimationInProgress = false;
        }

        private async Task UpdateThumbPosition()
        {
            var originalWidth = thumbFrame.Width;
            var mainFrameWidth = mainFrame.Width - ThumbPadding;
            var enlargedWidth = originalWidth * 1.5;

            var targetX = _isSwitchOn ? mainFrameWidth - enlargedWidth : ThumbPadding;
            var thumbFrameBounds = new Rectangle(targetX, thumbFrame.Y, enlargedWidth, thumbFrame.Height);
            await thumbFrame.LayoutTo(thumbFrameBounds, AnimationDuration);

            await Task.Delay(AnimationDuration / 3);

            UpdateMainFrameBackgroundColor();

            targetX = _isSwitchOn ? mainFrameWidth - originalWidth : ThumbPadding;
            var originalBounds = new Rectangle(targetX, thumbFrame.Y, originalWidth, thumbFrame.Height);
            await thumbFrame.LayoutTo(originalBounds, AnimationDuration);
        }


        private void MainFrame_SizeChanged(object sender, EventArgs e)
        {
            if (!(mainFrame.Width > 0)) return;
            UpdateThumbPosition();

            mainFrame.SizeChanged -= MainFrame_SizeChanged;
        }

        private void UpdateMainFrameBackgroundColor()
        {
            mainFrame.BackgroundColor = _isSwitchOn ? Color.FromHex("#60E17C") : Color.FromHex("#CCCCCC");
        }
    }
}