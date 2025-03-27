namespace Singleton;

public sealed class TypicalSingleton
{
    private static TypicalSingleton? _instance;

    public static TypicalSingleton Instance
    {
        get
        {
            Console.WriteLine("Instance called");
            return _instance ??= new TypicalSingleton();
        }
    }

    private TypicalSingleton()
    {
        Console.WriteLine("TypicalSingleton constructor invoked");
    }
}