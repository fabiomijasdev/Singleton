namespace Singleton;

public class StaticSingletonLogger : SingletonBase
{
    private static readonly StaticSingletonLogger instance = new StaticSingletonLogger();
    private StaticSingletonLogger() { }

    public static StaticSingletonLogger GetInstance()
    {
        return instance;
    }
}
