namespace Singleton;

public class ClassicSingletonLogger : SingletonBase
{
    private static ClassicSingletonLogger? instance;

    private ClassicSingletonLogger() { }

    public static ClassicSingletonLogger GetInstance()
    {
        if (instance is null)
            instance = new ClassicSingletonLogger();

        return instance;
    }
}
