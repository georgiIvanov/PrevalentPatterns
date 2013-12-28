using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    class Airbus321 : Aircraft
    {
        public Airbus321(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 52000; }
        }
    }
}
