namespace LoggerScope;

public class LoggerScope : ILoggerScope
{
    public Dictionary<string, object> Properties { get; }

    public LoggerScope()
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