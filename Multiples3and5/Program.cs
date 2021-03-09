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
            //declaring the variable sum as an int, 0
            int sum = 0;
                //counter I=1 , condition increment until i is less than 1000, update i =1
            for (int i = 1; i < 1000; i++)
            {
                int x = i % 3;//x = i modulus 3 to find remainder
                int y = i % 5;
                if (x == 0 || y == 0)//if x or y are = to 0 then are a power or 3 or 5
                {
                    //Console.Write("{0}  ", i);
                    sum = sum + i;//if x or y are = to 0 then are a power or 3 or 5, add i to the sum which will equal the sum 
                }
            }
            Console.WriteLine("Multiples sum is: {0}", sum);//printing out the sum as
            
        }//end Main()
    }//end class
}//end namespace
