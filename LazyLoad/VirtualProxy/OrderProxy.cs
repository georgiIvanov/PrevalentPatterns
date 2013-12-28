using LazyLoad.LazyInitialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.VirtualProxy
{
    class OrderProxy : Order
    {

        public override LazyInitialization.Customer Customer
        {
            get
            {
                if (base.Customer == null)
                {
                    Debug.Print("Customer initialized");
                    base.Customer = new Customer();
                }
                return base.Customer;
            }
            set
            {
                base.Customer = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Order;
            if (other == null)
            {
                return false;
            }

            return other.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
