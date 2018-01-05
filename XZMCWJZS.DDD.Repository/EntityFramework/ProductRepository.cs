using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZMCWJZS.DDD.Domain.Model;
using XZMCWJZS.DDD.Domain.Repositories;

namespace XZMCWJZS.DDD.Repository.EntityFramework
{
    // 商品仓储的实现
    public class ProductRepository : IProductRepository
    {
        private readonly IEntityFrameworkRepositoryContext efContext;

        public IEntityFrameworkRepositoryContext EfContext { get { return this.efContext; } }

        public ProductRepository(IRepositoryContext context)
        {
            var efContext = context as IEntityFrameworkRepositoryContext;
            if (efContext != null)
                this.efContext = efContext;
        }


        public void Add(Product aggregateRoot)
        {
            var ctx = this.EfContext.DbContex as OnlineStoreDbContext;
            ctx.Products.Add(aggregateRoot);
            ctx.SaveChanges(); 
        }

        public IEnumerable<Product> GetAll()
        {
            var ctx = this.EfContext.DbContex as OnlineStoreDbContext;
            if (ctx == null)
                return null;
            var query = from p in ctx.Products
                        select p;
            return query.ToList();
        }

        public Product GetByKey(Guid key)
        {
            return EfContext.DbContex.Products.FirstOrDefault(p => p.Id == key);
        }

        public IEnumerable<Product> GetNewProducts(int count = 0)
        {
            var ctx = this.EfContext.DbContex as OnlineStoreDbContext;
            if (ctx == null) return null;
            var query = from u in ctx.Products
                        where u.IsNew == true
                        select u;
            if (count == 0) return query.ToList();
            else return query.Take(count).ToList();
        }
    }
}
