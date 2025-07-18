using Singleton;

SingletonBase singletonBase1 = StaticSingletonLogger.GetInstance();

SingletonBase singletonBase2 = StaticSingletonLogger.GetInstance();

if (singletonBase1 == singletonBase2)
{
    Console.WriteLine("Same instance, singleton pattern correctly implemented");
}
SingletonBase.Log("This message is logged using a singleton logging system");
