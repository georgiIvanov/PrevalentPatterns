﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class FAQ : Manuscript
    {
        public FAQ(IFormatter formatter)
            :base(formatter)
        {
            Questions = new Dictionary<string, string>();

        }
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }
        public override void Print()
        {
            Console.WriteLine( formatter.Format("Title", Title));
            foreach (var item in Questions)
            {
                Console.WriteLine(formatter.Format("Question", item.Key));
                Console.WriteLine(formatter.Format("Answer", item.Value));
            }
            Console.WriteLine();
        }
    }
}
