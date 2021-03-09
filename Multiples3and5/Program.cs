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


            //List<int> mult = new List<int>();
            //for (int i = 3; i < 1000; i++)
            //{
            //    mult.Add(i);
            //}
            
            //for (int x = 5; x < 1000; x++)
            //{
            //    mult.Add(x);
            //}
            //Console.WriteLine(mult.Sum());

            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                int x = i % 3;
                int y = i % 5;
                if (x == 0 || y == 0)
                {
                    //Console.Write("{0}  ", i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("Multiples sum is: {0}", sum);
            
        }//end Main()
    }//end class
}//end namespace
