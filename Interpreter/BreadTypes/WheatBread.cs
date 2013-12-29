﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.BreadTypes
{
    class WheatBread : Bread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format(" {0} ", "Wheat Bread");
        }
    }
}
