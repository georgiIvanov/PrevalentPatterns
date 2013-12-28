using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.LazyInitialization
{
    class Order
    {
        Customer customer;

        public Customer Customer
        {
            get
            {
                if (customer == null)
                {
                    // db fetch
                    customer = new Customer();
                }
                return customer;
            }
        }

        public string PrintLabel()
        {
            // have to use the property or will throw
            string result = Customer.CompanyName + "\n" + Customer.Address;

            return result ;
        }
    }
}
