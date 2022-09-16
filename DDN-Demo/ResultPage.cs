using System;
using DDNXamarin.DDN;
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
                    new Image {Source = data.imageSource}
                }
            };
        }
    }
}

