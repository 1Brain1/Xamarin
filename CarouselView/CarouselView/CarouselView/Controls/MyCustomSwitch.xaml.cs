using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomSwitch
    {
        private double initialX;
        private double maxX;

        public MyCustomSwitch()
        {
            InitializeComponent();
            mainFrame.GestureRecognizers.Add(TapGesture);
            UpdateMainFrameBackgroundColor(); // Обновляем цвет при инициализации
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    initialX = thumbFrame.TranslationX;
                    maxX = mainFrame.Width - thumbFrame.Width - 10;
                    break;

                case GestureStatus.Running:
                    var newX = initialX + e.TotalX;
                    thumbFrame.TranslationX = Clamp(newX, 0, maxX);
                    break;

                case GestureStatus.Completed:
                    if (thumbFrame.TranslationX < maxX / 2)
                        thumbFrame.TranslateTo(0, 0, 250, Easing.CubicInOut);
                    else
                        thumbFrame.TranslateTo(maxX, 0, 250, Easing.CubicInOut);
                    UpdateMainFrameBackgroundColor();
                    break;
            }
        }

        private double Clamp(double value, double min, double max)
        {
            return value < min ? min : value > max ? max : value;
        }

        public TapGestureRecognizer TapGesture => new TapGestureRecognizer
        {
            Command = new Command(() =>
            {
                if (thumbFrame.TranslationX < maxX / 2)
                    thumbFrame.TranslateTo(maxX, 0, 250, Easing.CubicInOut);
                else
                    thumbFrame.TranslateTo(0, 0, 250, Easing.CubicInOut);
                UpdateMainFrameBackgroundColor(); // Обновляем цвет при нажатии
            })
        };

        private void UpdateMainFrameBackgroundColor()
        {
            if (thumbFrame.TranslationX < maxX / 2)
                mainFrame.BackgroundColor = Color.FromHex("#60E17C"); // Цвет, когда Switch включен
            else
                mainFrame.BackgroundColor = Color.FromHex("#CCCCCC"); // Цвет, когда Switch выключен
        }
    }
}