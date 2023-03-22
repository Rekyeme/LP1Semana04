using System;

namespace Power2Method
{
    /// <summary>
    /// Defines 2 additional private methods;
    /// </summary>
    class Program
    {
        /// <summary>
        /// Call for the method PowerOf2UntilN to print the powers of 2 from 2 to 32;
        /// </summary>
        private static void Power2OfUntil5()
        {
           PowerOf2UntilN(5);
        }


        /// <summary>
        /// Prints the powers from of 2 from 1 to n using a for loop; 
        /// </summary>
        /// <param name="args"></param>
        private static void PowerOf2UntilN(int n)
        {
            for(int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        
        /// <summary>
        /// Summons the method Power2OfUntil5 to print the powers of 2 from 1 to 32. 
        /// After that summons the methods PowerOf2UntilN(6) and PowerOf2UntilN(12) and print
        ///the powers of 2 from 1 to 64 and 1 to 4096.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Power2OfUntil5();
            PowerOf2UntilN(6);
            PowerOf2UntilN(12);
        }
    }
}
