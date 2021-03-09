using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.


            List<int> mult = new List<int>();
            for (int i = 3; i < 1000; i++)
            {
                mult.Add(i);
            }
            for (int x = 5; x < 1000; x++)
            {
                mult.Add(x);
            }
            Console.WriteLine(mult.Sum());

        }//end Main()
    }//end class
}//end namespace
