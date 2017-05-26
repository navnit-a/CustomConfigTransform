using System.Configuration;

namespace MainProgram
{
    public class ServiceConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Services", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ServiceCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public ServiceCollection Services => (ServiceCollection) base["Services"];
    }
}