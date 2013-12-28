using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // separates the construction of a complex object from its
    // representation so that the same construction process
    // can create different representations
    class Program
    {
        static void Main(string[] args)
        {
            // result obj <-- director(builder)

            //var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            var sandwichMaker = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich1 = sandwichMaker.GetSandwich();

            sandwich1.Display();
        }
    }
}
