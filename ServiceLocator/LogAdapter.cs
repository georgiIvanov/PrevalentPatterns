using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ServiceLocator
{
    class LogAdapter : ILog
    {
        static log4net.ILog log = 
            log4net.LogManager.GetLogger(typeof(LogAdapter));

        public void Log(string txt)
        {
            log.Info(txt);
        }

        public void LogFormat(string txt, params object[] p)
        {
            log.InfoFormat(txt, p);
        }
    }
}
