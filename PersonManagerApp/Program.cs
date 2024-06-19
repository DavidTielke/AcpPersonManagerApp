using DavidTielke.PMA.CrossCutting.Configuration;
using DavidTielke.PMA.Infrastructure.Mappings;
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

            var config = provider.GetRequiredService<IConfigurator>();
            config.Set("AgeTreshold",18);
            config.Set("CsvPath","data.csv");

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
