using System.Configuration;

namespace ConfigTransforms
{
    public class TestConfig
    {
        public static string SomeValues => ConfigurationManager.AppSettings["Test:SomeValues"];
    }
}