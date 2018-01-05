using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZMCWJZS.DDD.Domain.Model;

namespace XZMCWJZS.DDD.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetNewProducts(int count = 0);

    }
}
