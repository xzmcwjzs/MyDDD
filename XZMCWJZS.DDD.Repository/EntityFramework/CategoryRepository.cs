using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZMCWJZS.DDD.Domain.Model;
using XZMCWJZS.DDD.Domain.Repositories;

namespace XZMCWJZS.DDD.Repository.EntityFramework
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IEntityFrameworkRepositoryContext efContext;

        public IEntityFrameworkRepositoryContext EfContext { get { return this.efContext; } }

        public CategoryRepository(IRepositoryContext context)
        {
            var efContext = context as IEntityFrameworkRepositoryContext;
            if (efContext != null)
                this.efContext = efContext;
        }

        public void Add(Category aggregateRoot)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            var ctx = this.EfContext.DbContex as OnlineStoreDbContext;
            if (ctx == null)
                return null;
            var query = from c in ctx.Categories
                        select c;
            return query.ToList();
        }

        public Category GetByKey(Guid key)
        {
            return this.EfContext.DbContex.Categories.First(c => c.Id == key);
        }
    }
}
