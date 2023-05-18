using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayout_Exercise_2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
