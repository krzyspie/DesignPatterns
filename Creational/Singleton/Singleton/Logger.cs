namespace Singleton;

public static class Logger
{
    private static readonly List<string> Logs = [];

    public static void Log(string message)
    {
        Logs.Add(message);
    }

    public static List<string> GetLogs()
    {
        return Logs;
    }
}