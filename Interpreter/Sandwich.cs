using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Sandwich : Expression
    {
        readonly Bread topBread;
        readonly CondimentList topCondiments;
        readonly IngredientList ingredients;
        readonly CondimentList bottomCondiments;
        readonly Bread bottomBread;

        public Sandwich(Bread topBread, CondimentList topCondiments,
            IngredientList ingredients, CondimentList bottomCondiments, Bread bottomBread)
        {
            this.topBread = topBread;
            this.topCondiments = topCondiments;
            this.ingredients = ingredients;
            this.bottomCondiments = bottomCondiments;
            this.bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            topCondiments.Interpret(context);
            context.Output += "-";
            ingredients.Interpret(context);
            context.Output += "-";
            bottomCondiments.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            bottomBread.Interpret(context);
            context.Output += "|";
            Console.WriteLine(context.Output);
            
        }
    }

  
}
