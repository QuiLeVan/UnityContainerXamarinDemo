using System;
using CommonServiceLocator;

namespace UnityIoCContainer.ViewModels
{
    public class ViewModelLocator
    {
        public ProductsViewModel ProductsViewModel {
            get
            {
                return ServiceLocator.Current.GetInstance<ProductsViewModel>();
            }
        }
    }
}
