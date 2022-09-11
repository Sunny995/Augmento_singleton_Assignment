using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter.Instance.Increament();
            Counter.Instance.Decreament();
            Console.WriteLine(Counter.Instance.count);
        }
    }
}
