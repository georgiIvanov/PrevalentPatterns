﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Condiments
{
    class KetchupCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Ketchup");
        }
    }
}
