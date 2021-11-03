using System;
using System.Net;
using VCargo_Courier.Services;
using VCargo_Courier.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VCargo_Courier
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<UserMockDataStore>();
            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
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
