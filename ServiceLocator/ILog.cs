using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    interface ILog
    {
        void Log(string txt);
        void LogFormat(string txt, params object[] p);
    }
}
