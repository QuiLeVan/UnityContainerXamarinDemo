using System;
using CommonServiceLocator;
using Unity;
using Unity.ServiceLocation;
using UnityIoCContainer.Interfaces;
using UnityIoCContainer.Services;
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

            //Init UnityContainer
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IProductsService, ProductsService>();

            var unityServiceLocator = new UnityServiceLocator(unityContainer);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

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
