namespace Singleton
{
    public abstract class SingletonBase
    {
        public static void Log(Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
