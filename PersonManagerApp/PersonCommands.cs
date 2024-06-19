using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    public class PersonCommands : IPersonCommands
    {
        private readonly IPersonManager _personManager;

        public PersonCommands(IPersonManager personManager)
        {
            _personManager = personManager;
        }

        public void DisplayAllAdults()
        {
            var adults = _personManager.GetAllAdults().ToList();
            Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
            adults.ForEach(a => Console.WriteLine(a.Name));
        }

        public void DisplayAllChildren()
        {
            var children = _personManager.GetAllChildren().ToList();
            Console.WriteLine($"### Kinder ({children.Count}) ###");
            children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}