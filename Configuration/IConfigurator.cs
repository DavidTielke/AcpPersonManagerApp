namespace DavidTielke.PMA.CrossCutting.Configuration;

public interface IConfigurator
{
    TItem Get<TItem>(string key);
    void Set(string key, object value);
}