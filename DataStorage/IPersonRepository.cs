using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStorage;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}