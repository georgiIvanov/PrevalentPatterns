using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.ValueHolder
{
    class ValueHolder<T>
    {
        T value;
        readonly IValueLoader<T> loader;

        public ValueHolder(IValueLoader<T> loader)
        {
            this.loader = loader;
        }

        public T Value
        {
            get
            {
                if (value == null)
                {
                    value = loader.Load();
                }

                return value;
            }
        }
    }
}
