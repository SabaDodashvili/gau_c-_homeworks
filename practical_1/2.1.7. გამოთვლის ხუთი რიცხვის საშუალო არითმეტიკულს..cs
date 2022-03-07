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
            int[] numbers = { 1, 2, 3, 4, 5, };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
            sum += numbers[i];
            }

            int arithmeticMean = sum / numbers.Length;

            Console.WriteLine(arithmeticMean);
        }
    }
}
