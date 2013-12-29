using Interpreter.BreadTypes;
using Interpreter.Condiments;
using Interpreter.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    // given a language, define a representation for its grammar
    // along with interpreter that uses the representation
    // to interpret sentences in the language
    class Program
    {
        // BNF:
        // <sandwich> ::= <bread> <condimentList> <ingredientList> <condimentList> <bread>
        // <condimentList> ::= { <condiment> }
        // <ingredientList> ::= { <ingredient> }
        // <bread> ::= <whiteBread> | <wheatBread>
        // <condiment> ::= <mayoCondiment> | <mustardCondiment> | <ketchupCondiment>
        // <ingredient> ::= <lettuceIngredient> | <tomatoIngredient> | <chickenIngredient>
        static void Main(string[] args)
        {
            var sandwich = new Sandwich(
                new WheatBread(),
                new CondimentList(new List<Condiment>{
                    new MayoCondiment(), 
                    new MustardCondiment() 
                }),
                new IngredientList(new List<Ingredient>{
                    new LettuceIngredient(), 
                    new ChickenIngredient() 
                }),
                new CondimentList(new List<Condiment>{
                    new KetchupCondiment()
                }),
                new WheatBread()
                );

            sandwich.Interpret(new Context());
        }
    }
}
