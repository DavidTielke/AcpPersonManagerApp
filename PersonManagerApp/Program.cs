using System.ComponentModel.DataAnnotations;
using DavidTielke.PMA.Data.DataStorage;
using DavidTielke.PMA.Data.FileStorage;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddTransient<IPersonCommands, PersonCommands>();
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();

            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
