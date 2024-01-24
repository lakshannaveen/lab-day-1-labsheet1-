using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nEnter a numbers");
                 number = int.Parse(Console.ReadLine());
                if(number %2 == 0)
                {
                    Console.Write("It is even");
                }
                else
                {
                    Console.Write("It is odd");
                }
            }
            Console.ReadLine();
            }


    }
}
