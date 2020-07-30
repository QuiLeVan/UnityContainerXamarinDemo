using System;
using System.Collections.Generic;
using UnityIoCContainer.Models;
using UnityIoCContainer.Services;

namespace UnityIoCContainer.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public ProductsViewModel()
        {
            var productsService = new ProductsService();
            Products = productsService.Getproducts();
        }
    }
}
