using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_s2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if(Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
        }
        void mujSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            mujLabel.Text = String.Format("Hodnota je {0:F2}", e.NewValue);
            mujLabel.Opacity = e.NewValue;
            mujButton.Opacity = e.NewValue;
            mujEntry.Opacity = e.NewValue;
        }

        void mujButton_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Nová zpráva!", mujEntry.Text, "OK");
        }
    }
}
