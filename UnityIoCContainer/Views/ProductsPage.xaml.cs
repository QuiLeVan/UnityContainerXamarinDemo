using System;
using System.Collections.Generic;
using CommonServiceLocator;
using UnityIoCContainer.ViewModels;
using Xamarin.Forms;

namespace UnityIoCContainer.Views
{
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();

            //BindingContext = ServiceLocator.Current.GetInstance<ProductsViewModel>();
        }
    }
}
