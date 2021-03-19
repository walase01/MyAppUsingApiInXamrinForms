using MyApplicationUsingApi.Services;
using MyApplicationUsingApi.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApplicationUsingApi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
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
