using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaborLedce.Services;
using TaborLedce.Views;

namespace TaborLedce
{
    public partial class App : Application
    {

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTQwMTY2QDMxMzcyZTMyMmUzMGM3SkkvUUtQZVVoZzRYQXhua0drYTQxVE0xbmhlOVIyTW9IOTZZb0krVVk9");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
