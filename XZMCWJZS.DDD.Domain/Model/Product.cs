using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZMCWJZS.DDD.Domain.Model
{
      // 商品类
    public class Product : AggregateRoot
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public string ImageUrl { get; set; }

        public bool IsNew{ get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
