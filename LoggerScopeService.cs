namespace LoggerScope;

public class LoggerScopeService : ILoggerScopeService
{
    public Dictionary<string, object> Properties { get; }

    public LoggerScopeService()
    {
        Properties = new Dictionary<string, object>();
    }

    public void AddProperty(string key, object value)
    {
        if (Properties.ContainsKey(key))
        {
            Properties[key] = value;
        }
        else
        {
            Properties.Add(key, value);
        }
    }
}