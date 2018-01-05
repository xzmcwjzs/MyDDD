using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using XZMCWJZS.DDD.Domain.Model;
using XZMCWJZS.DDD.WCF.Application.ServiceContracts;
using XZMCWJZS.DDD.WCF.Application.ServiceImplementations;

namespace XZMCWJZS.DDD.WCF.Application
{
    // 商品WCF服务
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class ProductService: IProductService
    {
        // 引用商品服务接口
        private readonly IProductService productService=new ProductServiceImp();

        public void Add(Product aggregateRoot)
        {
             productService.Add(aggregateRoot);
        }

        public IEnumerable<Category> GetCategories()
        {
            return productService.GetCategories();
        }

        public IEnumerable<Product> GetNewProducts(int count)
        {
            return productService.GetNewProducts(count);
        }

        public Product GetProductById(Guid id)
        {
            return productService.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productService.GetProducts();
        }
         
    }
}
