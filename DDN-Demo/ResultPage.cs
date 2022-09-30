using System;
using DDNXamarin;
using Xamarin.Forms;

namespace DDNDemo
{
    public class ResultPage : ContentPage
    {
        public ResultPage(ImageData data)
        {
            Content = new StackLayout
            {
                Children = {
                    new Image {Source = data.toImageSource()}
                }
            };
        }
    }
}

