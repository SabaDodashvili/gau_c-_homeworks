using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("shemoitanet ricxvi");
            int num = Convert.ToInt32(Console.ReadLine()); 
            
            if (num % 2 == 0)
              Console.WriteLine("aris luwi");
            else 
              Console.WriteLine("kenti");

            Console.ReadKey();
        }
    }
}
