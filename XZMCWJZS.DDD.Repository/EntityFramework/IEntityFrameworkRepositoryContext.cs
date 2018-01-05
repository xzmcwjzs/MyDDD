using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZMCWJZS.DDD.Domain.Repositories;

namespace XZMCWJZS.DDD.Repository.EntityFramework
{ 
    public interface IEntityFrameworkRepositoryContext : IRepositoryContext
    {
        #region Properties
        OnlineStoreDbContext DbContex { get; }
        #endregion 
    }


}
