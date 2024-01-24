using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your width:");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter your length:");
            double length = double.Parse(Console.ReadLine());

            double area = Area(length ,width);

            Console.Write("Your area is :" + area);
            Console.ReadLine();

            


        }
        static double Area(double length,double width)
        {
            return length * width;
        }
    }
}
