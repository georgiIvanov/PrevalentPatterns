﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IAsset
    {
        void Accept(IVisitor visitor);
    }
}
