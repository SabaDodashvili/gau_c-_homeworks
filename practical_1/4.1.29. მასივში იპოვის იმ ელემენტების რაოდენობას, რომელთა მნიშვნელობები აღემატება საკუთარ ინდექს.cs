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
            int count = 0;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] > i)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
