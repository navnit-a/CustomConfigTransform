﻿using System.Configuration;

namespace MainProgram
{
    public class ServiceConfig : ConfigurationElement
    {
        public ServiceConfig()
        {
        }

        public ServiceConfig(int port, string reportType)
        {
            Port = port;
            ReportType = reportType;
        }

        [ConfigurationProperty("Port", DefaultValue = 0, IsRequired = true, IsKey = true)]
        public int Port
        {
            get { return (int) this["Port"]; }
            set { this["Port"] = value; }
        }

        [ConfigurationProperty("ReportType", DefaultValue = "File", IsRequired = true, IsKey = false)]
        public string ReportType
        {
            get { return (string) this["ReportType"]; }
            set { this["ReportType"] = value; }
        }
    }
}