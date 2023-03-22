using System;

namespace Power2Method
{
    class Program
    {
        private static void Power2Until5M()
        {
            for(int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
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
            Power2Until5M();
            PowerOf2UntilN(6);
            PowerOf2UntilN(8);
        }
    }
}
