using Tn.Sdk;

namespace KernCatalog.UseCase;

internal class Configuration : ConfigurationGroup
{
    public Configuration()
    {
        Add<NgduConfiguration>();
        Add<UbrConfiguration>();
        Add<OilfieldConfiguration>();
        Add<OilsquareConfiguration>();
        Add<WelldataConfiguration>();        
    }
}
