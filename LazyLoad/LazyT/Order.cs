using LazyLoad.LazyInitialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.LazyT
{
    class Order
    {
        Lazy<Customer> customer;

        public Order()
        {
            customer = new Lazy<Customer>(() => new Customer());
        }

        public Customer Customer
        {
            get
            {
                return customer.Value;
            }
        }

        public string PrintLabel()
        {
            // have to use the property or will throw
            string result = Customer.CompanyName + "\n" + customer.Value.Address;
            // its ok to acces through .Value

            return result;
        }
    }
}
