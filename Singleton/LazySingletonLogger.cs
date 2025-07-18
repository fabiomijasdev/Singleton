﻿namespace Singleton;

public class LazySingletonLogger : SingletonBase
{
    private static readonly Lazy<LazySingletonLogger> instance = new Lazy<LazySingletonLogger>(() => new LazySingletonLogger());

    private LazySingletonLogger() { }

    public static LazySingletonLogger GetInstance()
    {
        return instance.Value;
    }
}
