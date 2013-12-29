using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class IngredientList : Expression
    {
        readonly List<Ingredient> ingredients;

        public IngredientList(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}
