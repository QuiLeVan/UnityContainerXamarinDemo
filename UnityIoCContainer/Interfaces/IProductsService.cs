using System;
using System.Collections.Generic;
using UnityIoCContainer.Models;

namespace UnityIoCContainer.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<Product> Getproducts();
    }
}
