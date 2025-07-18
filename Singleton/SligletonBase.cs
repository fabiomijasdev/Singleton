using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class SligletonBase
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
