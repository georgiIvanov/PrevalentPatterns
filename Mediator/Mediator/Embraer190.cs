using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    class Embraer190 : Aircraft
    {
        public Embraer190(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 39000; }
        }
    }
}
