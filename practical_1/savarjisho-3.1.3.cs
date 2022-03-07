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
            Console.Write("airchiet ricxvi: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("ricxvi 5-is jeradia");
            }
            else
            {
                Console.WriteLine("ricxvi ar aris 5-is jeradi");
            }
        }
    }
}
