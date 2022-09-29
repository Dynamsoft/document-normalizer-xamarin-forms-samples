using System;
using DDNXamarin;

using Xamarin.Forms;

namespace DDNDemo
{
    public partial class App : Application, IDCVLicenseVerificationListener
    {
        public static ICameraEnhancer dce;
        public static IDocumentNormalizer ddn;
        public static ILicenseManager licenseManager;


        public App(ICameraEnhancer enhancer, IDocumentNormalizer normalizer, ILicenseManager manager)
        {
            dce = enhancer;
            ddn = normalizer;
            licenseManager = manager;
            licenseManager.initLicense("DLS2eyJvcmdhbml6YXRpb25JRCI6IjIwMDAwMSJ9", this);
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
