using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    class YytCenter : IAirTrafficControl
    {
        readonly IList<Aircraft> aircraftUnderGuidance = new List<Aircraft>();

        public void RecieveAircraftLocation(Aircraft reportingAircraft)
        {
            foreach (var currentAircraft in aircraftUnderGuidance
                .Where(x => x != reportingAircraft))
            {
                if (Math.Abs(currentAircraft.Altitude - reportingAircraft.Altitude) < 50)
                {
                    reportingAircraft.Climb(1000);
                    // communicate to the object
                    currentAircraft.WarnOfAirspaceIntrusionBy(reportingAircraft);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!aircraftUnderGuidance.Contains(aircraft))
            {
                aircraftUnderGuidance.Add(aircraft);
            }
        }
    }
}
