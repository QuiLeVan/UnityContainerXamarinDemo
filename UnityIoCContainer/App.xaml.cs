using System;
using UnityIoCContainer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnityIoCContainer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductsPage();
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
