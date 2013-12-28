using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    interface IAirTrafficControl
    {
        void RecieveAircraftLocation(Aircraft location);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}
