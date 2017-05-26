﻿using System;
using System.Configuration;

namespace MainProgram
{
    public class ServiceCollection : ConfigurationElementCollection
    {
        public ServiceCollection()
        {
            //Console.WriteLine("ServiceCollection Constructor");
        }

        public ServiceConfig this[int index]
        {
            get { return (ServiceConfig) BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        public void Add(ServiceConfig serviceConfig)
        {
            BaseAdd(serviceConfig);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ServiceConfig();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ServiceConfig) element).Port;
        }

        public void Remove(ServiceConfig serviceConfig)
        {
            BaseRemove(serviceConfig.Port);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }
    }
}