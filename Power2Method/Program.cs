using System;

namespace Power2Method
{
    class Program
    {
        private static void Power2OfUntil5M()
        {
           PowerOf2UntilN(5);
        }

        private static void PowerOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Power2OfUntil5M();
            PowerOf2UntilN(6);
            PowerOf2UntilN(12);
        }
    }
}
