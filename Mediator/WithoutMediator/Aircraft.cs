using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutMediator
{
    abstract class Aircraft
    {
        int currentAltitude;
        protected IList<Aircraft> _acknowledgedAircraft;

        public Aircraft(string callSign)
        {
            _acknowledgedAircraft = new List<Aircraft>();
            this.CallSign = callSign;
        }

        public void Acknowledges(Aircraft flight)
        {
            _acknowledgedAircraft.Add(flight);
        }

        public string CallSign { get; private set; }
        public abstract int Ceiling { get; }
        public abstract bool IsTrailingGapAcceptable();

        public int Altitude
        {
            get { return currentAltitude; }
            set { currentAltitude = value; }
        }
    }
}
