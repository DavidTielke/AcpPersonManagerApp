using System.ComponentModel.DataAnnotations;
using DavidTielke.PMA.Data.DataStorage;
using DavidTielke.PMA.Data.FileStorage;
using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var reader = new FileReader();
            var parser = new PersonParser();
            var repo = new PersonRepository(parser, reader);
            var manager = new PersonManager(repo);
            var commands = new PersonCommands(manager);

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
