using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XZMCWJZS.DDD.Domain.Model;
using XZMCWJZS.DDD.Domain.Repositories;
using XZMCWJZS.DDD.Repository.EntityFramework;
using XZMCWJZS.DDD.WCF.Application.ServiceContracts;

namespace XZMCWJZS.DDD.WCF.Application.ServiceImplementations
{
    // 商品服务的实现
    public class ProductServiceImp : IProductService
    {
        private readonly IProductRepository productRepository= new ProductRepository(new EntityFrameworkRepositoryContext());
        private readonly ICategoryRepository categoryRepository= new CategoryRepository(new EntityFrameworkRepositoryContext());
        //public ProductServiceImp(IProductRepository productRepository, ICategoryRepository categoryRepository)
        //{
        //    this.categoryRepository = categoryRepository;
        //    this.productRepository = productRepository;
        //}
        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }

        public IEnumerable<Product> GetNewProducts(int count)
        {
            return productRepository.GetNewProducts(count);
        }

        public Product GetProductById(Guid id)
        {
            var product = productRepository.GetByKey(id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public void Add(Product aggregateRoot)
        {
            productRepository.Add(aggregateRoot);
        }
    }
}