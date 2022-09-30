using System;
using DDNXamarin;

using Xamarin.Forms;

namespace DDNDemo
{
    public partial class App : Application, ILicenseVerificationListener
    {
        public static ICameraEnhancer dce;
        public static IDocumentNormalizer ddn;
        public static ILicenseManager licenseManager;


        public App(ICameraEnhancer enhancer, IDocumentNormalizer normalizer, ILicenseManager manager)
        {
            dce = enhancer;
            ddn = normalizer;

            licenseManager = manager;

            licenseManager.InitLicense("DLS2eyJvcmdhbml6YXRpb25JRCI6IjIwMDAwMSJ9", this);
            MainPage = new NavigationPage(new MainPage());
        }


        public void LicenseVerificationCallback(bool isSuccess, string msg)
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
