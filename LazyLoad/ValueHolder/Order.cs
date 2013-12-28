using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.ValueHolder
{
    class Order
    {
        ValueHolder<List<OrderItem>> items;

        public int Id { get; set; }
        public Order(int id)
        {
            Id = id;
        }

        public List<OrderItem> Items
        {
            get { return items.Value; }
        }

        internal void SetItems(ValueHolder<List<OrderItem>> valueHolder)
        {
            items = valueHolder;
        }
    }
}
