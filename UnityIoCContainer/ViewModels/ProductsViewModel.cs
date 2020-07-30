using System;
using System.Collections.Generic;
using UnityIoCContainer.Interfaces;
using UnityIoCContainer.Models;
using UnityIoCContainer.Services;

namespace UnityIoCContainer.ViewModels
{
    public class ProductsViewModel
    {
        private readonly IProductsService _productsService;

        public IEnumerable<Product> Products { get; set; }


        public ProductsViewModel(IProductsService productsService)
        {
            _productsService = productsService; //new ProductsService();

            DownloadProduct();
        }

        void DownloadProduct() {
            Products = _productsService.Getproducts();
        }
    }
}
