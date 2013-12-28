using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MySandwichBuilder : SandwichBuilder
    {
        public void CreateSandwich()
        {
            CreateNewSandwich();
            PrepareBread();
            ApplyMeatAndCheese();
            ApplyVegetables();
            AddCondiments();
        }

        public override void AddCondiments()
        {
            this.sandwich.HasMayo = false;

            this.sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            this.sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            this.sandwich.CheeseType = CheeseType.Cheddar;
            this.sandwich.MeatType = MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            this.sandwich.BreadType = BreadType.Wheat;
            this.sandwich.IsToasted = true;
        }
    }
}
