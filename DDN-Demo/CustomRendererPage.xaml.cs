using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDNDemo;
using DDNXamarin;
using Xamarin.Forms;

namespace DDNDemo
{
    public partial class CustomRendererPage : ContentPage, IDocumentResultListener
    {
        public static IDCVCameraEnhancer dce;
        public static IDocumentNormalizer ddn;

        public CustomRendererPage()
        {
            InitializeComponent();
            App.ddn.SetCameraEnhancer(App.dce);
            App.ddn.AddResultListener(this);
        }

        public void DocumentResultCallback(int id, ImageData imageData, DetectedQuadResult[] documentResults)
        {
            if (imageData !=null) {

                Device.BeginInvokeOnMainThread(async ()=> {
                    await Navigation.PushAsync(new QuadEditorPage(imageData, documentResults));
                });
            }
        }

        protected override void OnAppearing()
        {

            base.OnAppearing();
            App.dce.Open();
            App.ddn.StartDetecting();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dce.Close();
            App.ddn.StopDetecting();

        }

        void OnButtonClicked(object sender, EventArgs e) {
            App.ddn.fetchResult();
        }
    }
}
