using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("give year is leap year");
            }
            else
            {
                Console.WriteLine("given year is not leap year");
            }

        }
    }
}
