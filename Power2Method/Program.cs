using System;

namespace Power2Method
{
    class Program
    {
        private static void Power2Until5M()
        {
            for(int i = 1; i <= (1 << 5); i << 1)
            {
                Console.WriteLine(i);
            }
        }
    
        static void Main(string[] args)
        {
        
        
        }
    }
}
