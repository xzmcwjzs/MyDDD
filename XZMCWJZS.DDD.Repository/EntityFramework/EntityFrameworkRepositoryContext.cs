using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XZMCWJZS.DDD.Domain.Repositories;

namespace XZMCWJZS.DDD.Repository.EntityFramework
{
    public class EntityFrameworkRepositoryContext : IEntityFrameworkRepositoryContext
    {
        // ThreadLocal代表线程本地存储，主要相当于一个静态变量
        // 但静态变量在多线程访问时需要显式使用线程同步技术。
        // 使用ThreadLocal变量，每个线程都会一个拷贝，从而避免了线程同步带来的性能开销

        private readonly ThreadLocal<OnlineStoreDbContext> localCtx = new ThreadLocal<OnlineStoreDbContext>(() => new OnlineStoreDbContext());
        public OnlineStoreDbContext DbContex
        {
            get { return localCtx.Value; }
        }
        private readonly Guid id = Guid.NewGuid();
        public Guid Id
        {
            get
            {
                return id;
            }
        }

        public void Commit()
        {
            var validationError = localCtx.Value.GetValidationErrors();
            localCtx.Value.SaveChanges();
        }

        public void RegisterNew<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, Domain.IAggregateRoot
        {
            localCtx.Value.Set<TAggregateRoot>().Add(entity);
        }

        public void RegisterModified<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, Domain.IAggregateRoot
        {
            localCtx.Value.Entry<TAggregateRoot>(entity).State = EntityState.Modified;
        }

        public void RegisterDeleted<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, Domain.IAggregateRoot
        {
            localCtx.Value.Set<TAggregateRoot>().Remove(entity);
        }
    }
}
