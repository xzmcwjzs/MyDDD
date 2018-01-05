using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZMCWJZS.DDD.Domain.Model;

namespace XZMCWJZS.DDD.Repository.EntityFramework
{
    public sealed class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext():base("OnlineStoreContext")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Product> Products
        {
            get { return this.Set<Product>(); }
        }

        public DbSet<Category> Categories
        {
            get { return this.Set<Category>(); }
        }


    }
}
