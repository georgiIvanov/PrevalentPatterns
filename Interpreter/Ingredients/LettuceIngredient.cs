using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Ingredients
{
    class LettuceIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Lettuce");
        }
    }
}
