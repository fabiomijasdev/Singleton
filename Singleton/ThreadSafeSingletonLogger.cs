namespace Singleton;

public class ThreadSafeSingletonLogger : SligletonBase
{
    private static readonly object threadSafeLock = new object();

    private static ThreadSafeSingletonLogger instance;
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
