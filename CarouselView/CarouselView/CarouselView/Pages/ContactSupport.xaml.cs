using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactSupport : ContentPage
    {
        public ContactSupport()
        {
            InitializeComponent();
        }

        private void TypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ServicePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PriorityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Your message was sent successfully", "One of our operators will be with you shortly ",
                "Got it");
        }
    }
}