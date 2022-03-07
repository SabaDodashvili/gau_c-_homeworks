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

            if (num <= 23)
            {
                Console.WriteLine("ricxvi naklebia an toli 23ze");
            }
            else
            {
                Console.WriteLine("ricxvi metia 23ze");
            }
        }
    }
}
