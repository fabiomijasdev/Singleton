
namespace Singleton;

public class ThreadSafeSingletonLogger : SingletonBase
{
    private static readonly Lock threadSafeLock = new();

    private static ThreadSafeSingletonLogger? instance;
    private ThreadSafeSingletonLogger() { }


    public static ThreadSafeSingletonLogger GetInstance()
    {

        if (instance is null)
        {
            lock (threadSafeLock)
            {
                instance = new ThreadSafeSingletonLogger();
            }
        }
        return instance;
    }

}
