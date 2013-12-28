using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    class Boeing737200 : Aircraft
    {
        public Boeing737200(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }
}
