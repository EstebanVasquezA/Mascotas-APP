using Mascotas_APP.Services;
using Mascotas_APP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mascotas_APP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
