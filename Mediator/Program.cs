using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // without mediator pattern
            var flight1 = new WithoutMediator.Airbus321("AC159");
            var flight2 = new WithoutMediator.Boeing737200("WS203");
            flight2.Acknowledges(flight1);
            flight1.Acknowledges(flight2);

            var flight3 = new WithoutMediator.Embraer190("AC602");
            flight3.Acknowledges(flight1);
            flight1.Acknowledges(flight3);
            flight3.Acknowledges(flight2);
            flight2.Acknowledges(flight3);

            // components
            // - colleagues - individual components that need to communicate with each other
            // usually implement same base class or interface, have knowledge about 
            // the mediator class

            // - mediator - the centralized component that manages communication
            // between colleague components
            // implements the abstraction that is used by the colleague components

            var yytCenter = new Mediator.YytCenter();

            var mflight1 = new Mediator.Airbus321("AC159", yytCenter);
            var mflight2 = new Mediator.Boeing737200("WS203", yytCenter);
            var mflight3 = new Mediator.Embraer190("AC602", yytCenter);

            mflight1.Altitude += 1000;
        }
    }
}
