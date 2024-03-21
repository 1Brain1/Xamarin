using System;
using Xamarin.Forms;

namespace CarouselView.Controls
{
    public class MyEntry : Entry
    {
        public new event EventHandler Completed;

        public void InvokeCompleted()
        {
            Completed?.Invoke(this, EventArgs.Empty);
        }
    }
}