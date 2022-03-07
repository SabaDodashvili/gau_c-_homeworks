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
            Console.Write("airchiet ramden elementiani masivi unda iyos ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] numbersArr = new int[arrLength];
            int minValue = 0;

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"numbersArr[{i}]:");
                numbersArr[i] = Convert.ToInt32(Console.ReadLine());

                if (numbersArr[i] > 0)
                {
                   minValue = numbersArr[i];
                }


            }

            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] > 0 && numbersArr[i] < minValue)
                {
                    minValue = numbersArr[i];
                }
            }

            Console.WriteLine("dadebitebis shoris minimaluri aris: " + minValue);
        }
    }
}
