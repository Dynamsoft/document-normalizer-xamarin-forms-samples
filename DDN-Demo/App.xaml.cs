using System;
using DDNXamarin.DCE;
using DDNXamarin.DDN;

using Xamarin.Forms;

namespace DDNDemo
{
    public partial class App : Application, IDCVLicenseVerificationListener
    {
        public static IDCVCameraEnhancer dce;
        public static IDocumentNormalizer ddn;


        public App(IDCVCameraEnhancer enhancer, IDocumentNormalizer normalizer)
        {
            dce = enhancer;
            ddn = normalizer;
            ddn.initLicense("DLS2eyJvcmdhbml6YXRpb25JRCI6IjIwMDAwMSJ9", this);
            MainPage = new NavigationPage(new MainPage());
        }

        public void DCVLicenseVerificationCallback(bool isSuccess, string msg)
        {

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
