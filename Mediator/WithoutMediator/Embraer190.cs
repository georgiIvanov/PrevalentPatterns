using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutMediator
{
    class Embraer190 : Aircraft
    {
        public Embraer190(string name)
            :base(name)
        {
        }

        public override int Ceiling
        {
            get { return 39000; }
        }

        public override bool IsTrailingGapAcceptable()
        {
            foreach (var acknowledgedAircraft in _acknowledgedAircraft)
            {
                if (acknowledgedAircraft.GetType() == typeof(Boeing737200))
                {
                    // logic to calc dist between 2 planes
                }
                if (acknowledgedAircraft.GetType() == typeof(Embraer190))
                {
                    // logic to calc dist between 2 planes
                }
            }

            return false;
        }
    }
}
