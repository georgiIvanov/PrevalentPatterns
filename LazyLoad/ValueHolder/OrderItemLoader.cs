using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.ValueHolder
{
    class OrderItemLoader : IValueLoader<List<OrderItem>>
    {
        readonly int orderId;

        public OrderItemLoader(int orderId)
        {
            this.orderId = orderId;
        }

        public List<OrderItem> Load()
        {
            // fetch from db by id
            Debug.Print("Fetching orderItems");
            return new List<OrderItem>();
        }
    }
}
