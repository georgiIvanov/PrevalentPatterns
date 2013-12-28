using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SandwichMaker
    {
        readonly SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            this.builder.CreateNewSandwich();
            this.builder.PrepareBread();
            this.builder.ApplyMeatAndCheese();
            this.builder.ApplyVegetables();
            this.builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return builder.GetSandwich();
        }
    }
}
