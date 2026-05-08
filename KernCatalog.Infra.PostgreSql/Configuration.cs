using Tn.Sdk;

namespace KernCatalog.Infra.PostgreSql
{
    internal class Configuration : ConfigurationGroup
    {
        public Configuration()
        {
            Add<NgduConfiguration>();
            Add<OilfieldConfiguration>();
            Add<OilsquareConfiguration>();
            Add<UbrConfiguration>();
            Add<WelldataConfiguration>();
        }
    }
}
