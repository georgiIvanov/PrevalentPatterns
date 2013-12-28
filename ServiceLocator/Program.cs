using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    class Program
    {
        // helps abstract the application from the services it uses
        // plays as the middleman
        // example usage: logging
        static void Main(string[] args)
        {
            // log4net needs to take configurations from App.config
            XmlConfigurator.Configure();

            // registering service

            // directly adding a class in the locator
            // ServiceLocator<ILog>.AddService("logger", new LoggingClass());

            // using app settings to register
            ServiceLocator<ILog>.RegisterServiceFromAppSettings("logger");

            // getting service
            ILog log = ServiceLocator<ILog>.GetService("logger");

            string msg = "First log " + DateTime.Now + "\n";
            log.Log(msg);

            msg = "Second Log " + DateTime.Now + "\n";
            log.Log(msg);
        }
    }
}
