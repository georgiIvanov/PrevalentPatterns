using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    class LoggingClass : ILog
    {
        StreamWriter logFile;

        public void Log(string txt)
        {
            InternalLog(txt);
        }

        public void LogFormat(string txt, params object[] p)
        {
            string msg = string.Format(txt, p);
            InternalLog(msg);
        }

        private void InternalLog(string txt)
        {
            if (logFile == null)
            {
                logFile = new StreamWriter("actions.log", true);
            }
            logFile.WriteLine(txt);
            logFile.Flush();
        }
    }
}
