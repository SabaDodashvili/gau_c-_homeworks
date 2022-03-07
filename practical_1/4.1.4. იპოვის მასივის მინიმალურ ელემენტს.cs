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
            int[] numbersArr = {5,6,3,4,112,4,9,190,10,0,-2,-5,23 };
            int minValue = numbersArr[0];

            for (int i = 1; i < numbersArr.Length; i++)
            {
                if (minValue > numbersArr[i])
                {
                    minValue = numbersArr[i];
                }
            }

            Console.WriteLine(minValue);
        }
    }
}
