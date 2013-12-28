using LazyLoad.LazyInitialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.VirtualProxy
{
    class Order
    {
        public virtual Customer Customer { get; set; }
        public virtual int Id { get; set; }

        public string PrintLabel()
        {
            return Customer.CompanyName + "\n" + Customer.Address;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
