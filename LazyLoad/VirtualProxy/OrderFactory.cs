using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.VirtualProxy
{
    class OrderFactory
    {
        public Order CreateFromId(int id)
        {
            return new OrderProxy()
            {
                Id = id
            };
        }
    }
}
