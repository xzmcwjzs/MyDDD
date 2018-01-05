using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZMCWJZS.DDD.Domain.Model
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        public Guid Id
        {
            get;
            set;
        }
    }
}
