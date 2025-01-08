using Marten;

namespace EneePrueba.Api;

public class UserMartenConfig : IConfigureMarten
{
    public void Configure(IServiceProvider services, StoreOptions options)
    {
        Console.WriteLine("Extendiendo configuración Marten : UserMartenConfig");
        options.Logger(new ConsoleMartenLogger());
    }
}
