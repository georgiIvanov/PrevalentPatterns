using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad
{
    // used to increase the performance of an app
    // by reducing the amount of work it needs to do
    // when the work is not necessary
    class Program
    {
        static void Main(string[] args)
        {

            // virtual proxy
            int orderId = 123;
            var order = new VirtualProxy.OrderFactory().CreateFromId(orderId);
            Console.WriteLine("Created with Id {0}, has Id {1}", orderId, order.Id);
            // print label is empty, but customer is initialized
            Console.WriteLine(order.PrintLabel());


            // value holder
            orderId = 99;
            var valueHolderorder = new ValueHolder.OrderFactory().CreateFromId(orderId);
            Console.WriteLine("\nVH - Created with Id {0}, has Id {1}", orderId, valueHolderorder.Id);
            // call to db
            var items = valueHolderorder.Items;
            
        }
    }
}
