using DavidTielke.PMA.Data.DataStorage;
using DavidTielke.PMA.Data.FileStorage;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public static class ServiceCollectionFactory
    {
        public static IServiceCollection Create()
        {
            var collection = new ServiceCollection();
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();
            return collection;
        }

    }
}
