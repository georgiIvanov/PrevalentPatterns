using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator
{
    abstract class Aircraft
    {
        readonly IAirTrafficControl _atc;
        int currentAltitude;

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            this._atc = atc;
            this.CallSign = callSign;
            _atc.RegisterAircraftUnderGuidance(this);
        }

        public abstract int Ceiling { get; }
        public string CallSign { get; private set; }
        public int Altitude
        {
            get { return currentAltitude; }
            set 
            {
                currentAltitude = value;
                _atc.RecieveAircraftLocation(this);
            }
        }

        public void Climb(int heightToClimb)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        internal void WarnOfAirspaceIntrusionBy(Aircraft reportingAircraft)
        {
            // do something in responce to the warning
        }
    }
}
