namespace Singleton;

public class ClassicSingletonLogger
{
    private static ClassicSingletonLogger? instance;

    private ClassicSingletonLogger() { }

    public static ClassicSingletonLogger GetInstance()
    {
        if (instance is null)
            instance = new ClassicSingletonLogger();

        return instance;
    }

    public static void Log(Exception exception)
    {
        Console.WriteLine(exception.ToString());
    }

    public static void Log(string message)
    {
        Console.WriteLine(message);
    }


}
