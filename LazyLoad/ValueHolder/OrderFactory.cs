using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.ValueHolder
{
    class OrderFactory
    {
        public Order CreateFromId(int id)
        {
            var order = new Order(id);
            order.SetItems(new ValueHolder<List<OrderItem>>(
                new OrderItemLoader(id)));

            return order;
        }
    }
}
