using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // this class is not part of the pattern
    // its one way of solving the problem
    // but the number of implementations for Manuscripts could grow exponentially
    // by just creating this kind of hierarchy

    //class BackwardsBook : Book
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("Title: {0}", new String(Title.Reverse().ToArray()));
    //        Console.WriteLine("Author: {0}", new String(Author.Reverse().ToArray()));
    //        Console.WriteLine("Text: {0}", new String(Text.Reverse().ToArray()));
    //        Console.WriteLine();
    //    }
    //}
}
