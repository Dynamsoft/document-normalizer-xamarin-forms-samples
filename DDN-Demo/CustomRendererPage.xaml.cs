using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDNDemo;
using DDNXamarin.DCE;
using DDNXamarin.DDN;
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
            App.ddn.setCameraEnhancer();
            App.ddn.addResultListener(this);
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
            App.ddn.startDetecting();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dce.Close();
            App.ddn.stopDetecting();

        }

        void OnButtonClicked(object sender, EventArgs e) {
            App.ddn.fetchResult();
        }
    }
}
