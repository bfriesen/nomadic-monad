using System;

namespace RandomSkunk.NomadicMonad.Demo
{
    class Program
    {
        static void Main()
        {
            PublicConstructorSimpleUsage();

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }

        private static void PublicConstructorSimpleUsage()
        {
            var m = new Monad<int>(128);
            Console.WriteLine("The value of m is {0}.", m.Value);
        }
    }
}
