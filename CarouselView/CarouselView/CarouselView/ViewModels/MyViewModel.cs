using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CarouselView.ViewModels
{
    public class MyViewModel : ViewModelBase
    {
        private string _switchValue;

        public string SwitchValue
        {
            get => _switchValue;
            set => Set(ref _switchValue, value);
        }

        public ICommand MyCommand => new RelayCommand<bool>((value) => ExecuteSwitchCommand(value));

        public MyViewModel()
        {
        }

        private void ExecuteSwitchCommand(bool value)
        {
            SwitchValue = value.ToString();
        }
    }
}