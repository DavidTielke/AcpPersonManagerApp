using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonManagerApp
{
    public class PersonCommands
    {
        private readonly PersonManager _personManager;

        public PersonCommands()
        {
            _personManager = new PersonManager();
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