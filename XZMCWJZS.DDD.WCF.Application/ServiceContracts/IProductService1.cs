using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XZMCWJZS.DDD.Domain.Model;

namespace XZMCWJZS.DDD.WCF.Application.ServiceContracts
{
    public interface IProductService1
    { 
        IEnumerable<Product> GetProducts();
         
        IEnumerable<Product> GetNewProducts(int count);
         
        IEnumerable<Category> GetCategories();
         
        Product GetProductById(Guid id);
         
        void Add(Product aggregateRoot);
    }
}