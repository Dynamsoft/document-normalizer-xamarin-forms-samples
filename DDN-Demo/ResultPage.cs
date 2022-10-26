using System;
using DDNXamarin;
using Xamarin.Forms;

namespace DDNDemo
{
    public class ResultPage : ContentPage
    {
        public ResultPage(ImageData data)
        {
            Image image = new Image { Source = data.ToImageSource() };
            if (Device.RuntimePlatform == Device.iOS)
            {
                image.RotateTo(data.orientation);
            }
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    image
                }
            };
        }
    }
}

