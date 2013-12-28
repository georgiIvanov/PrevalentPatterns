using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class FancyFormatter : IFormatter
    {

        public string Format(string key, string value)
        {
            return string.Format("-= {0} ------- =- {1}", key, value);
        }
    }
}
