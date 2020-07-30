using System;
using System.Collections.Generic;
using UnityIoCContainer.Interfaces;
using UnityIoCContainer.Models;

namespace UnityIoCContainer.Services
{
    public class ProductsService: IProductsService
    {
        public ProductsService()
        {
        }

        public IEnumerable<Product> Getproducts()
        {
            return new List<Product> {
                new Product { Name = "Food 1", Price = 5 },
                new Product { Name = "Food 2", Price = 12 },
            };
        }
    }
}
