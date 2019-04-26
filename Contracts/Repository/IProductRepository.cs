using System;
using System.Collections.Generic;
using System.Text;
using Domain_Layer.Entities.Catalog;

namespace Contracts.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetProduct(int id);
        bool RemoveProduct(int id);
        ICollection<Product> GetAllProducts();

    }
}