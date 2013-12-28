using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public void CreateNewSandwich()
        {
            this.sandwich = new Sandwich();
        }
        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();
    }
}
