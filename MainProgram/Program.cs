using System;
using System.Configuration;

namespace MainProgram
{
    internal class Program
    {
        public static string DefaultLoginName => ConfigurationManager.AppSettings["Test:Environment"];

        private static void Main(string[] args)
        {
            var serviceConfigSection =
                ConfigurationManager.GetSection("ServicesSection") as ServiceConfigurationSection;

            ServiceConfig serviceConfig = serviceConfigSection.Services[0];

            Console.WriteLine(serviceConfig.Port);
            Console.ReadLine();
        }
    }
}