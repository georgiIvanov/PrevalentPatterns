using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace ServiceLocator
{
    class ServiceLocator<T>
    {
        static readonly Dictionary<string, T> services = new Dictionary<string, T>();

        public static void AddService(T service)
        {
            services.Add(typeof(T).Name, service);
        }

        public static void AddService(string name, T service)
        {
            services.Add(name, service);
        }

        public static T GetService()
        {
            return services[typeof(T).Name];
        }

        public static T GetService(string serviceName)
        {
            return services[serviceName];
        }

        public static void RegisterServiceFromAppSettings(string serviceName)
        {
            //System.Configuration!System.Configuration.ConfigurationManager.AppSettings
            
            var loggerEntry = ConfigurationManager.AppSettings[serviceName];
            var loggingObject = Assembly.GetExecutingAssembly().CreateInstance(loggerEntry);
            //ServiceLocator<object>.AddService(serviceName, loggingObject);
            services.Add(serviceName, (T)loggingObject);

        }
    }
}
