using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        /* Project-euler problem 1
         * This program adds up the intergers divisible by 3 and 5
         * between 1 and 1000 and outputs the sum
         */
        static void Main(string[] args)
        {
            int sum = 0;
            for(int  i = 1; i < 1000; i++)
            {
                if((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            // Outputs 233168
            Console.WriteLine(sum);
        }
    }
}
