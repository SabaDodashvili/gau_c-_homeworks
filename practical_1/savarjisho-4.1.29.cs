using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._1._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("airchiet ramden elementiani masivi unda iyos ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] numbersArr = new int[arrLength];
            int counter = 0;

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"numbersArr[{i}]:");
                numbersArr[i] = Convert.ToInt32(Console.ReadLine());
                if (numbersArr[i] > i)
                {
                    counter++;
                }
                //Console.WriteLine(numbersArr[i]);

            }
            Console.WriteLine("raodenobaa - " + counter);
            Console.ReadKey();
        }
    }
}
