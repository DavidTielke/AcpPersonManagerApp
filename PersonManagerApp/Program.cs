using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var collection = ServiceCollectionFactory.Create();
            
            collection.AddTransient<IPersonCommands, PersonCommands>();

            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
