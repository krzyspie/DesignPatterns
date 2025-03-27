namespace Singleton;

public sealed class TypicalSingleton
{
    private static TypicalSingleton? _instance;

    public static TypicalSingleton Instance
    {
        get
        {
            //Console.WriteLine("Instance called");
            Logger.Log("Instance called");
            return _instance ??= new TypicalSingleton();
        }
    }

    private TypicalSingleton()
    {
        Logger.Log("TypicalSingleton constructor invoked");
    }
}