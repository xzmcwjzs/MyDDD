using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using XZMCWJZS.DDD.Domain.Model;

namespace XZMCWJZS.DDD.WCF.Application.ServiceContracts
{
    // 商品服务契约的定义
    [ServiceContract]
    public interface IProductService
    {
        // 获得所有商品的契约方法
        [OperationContract]
        IEnumerable<Product> GetProducts();

        // 获得新上市的商品的契约方法
        [OperationContract]
        IEnumerable<Product> GetNewProducts(int count);

        // 获得所有类别的契约方法
        [OperationContract]
        IEnumerable<Category> GetCategories();

        // 根据商品Id来获得商品的契约方法
        [OperationContract]
        Product GetProductById(Guid id);
        // 添加商品
        [OperationContract]
        void Add(Product aggregateRoot);
    }
}