using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZMCWJZS.DDD.Repository.EntityFramework
{
    public class EntityFrameworkRepositoryContext : IEntityFrameworkRepositoryContext
    {
        // 引用我们定义的OnlineStoreDbContext类对象
        public OnlineStoreDbContext DbContex
        {
            get { return new OnlineStoreDbContext(); }
        }
    }
}
