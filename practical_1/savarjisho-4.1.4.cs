using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region masivisformireba
            Console.Write("airchiet ramden elementiani masivi unda iyos ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] numbersArr = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                Console.Write($"numbersArr[{i}]:");
                numbersArr[i] = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine(numbersArr[i]);

            }
            #endregion

            #region minimumisPovnaMasivshi
            int minValue = numbersArr[0];

            for (int i = 1; i < numbersArr.Length; i++)
            {
                if (minValue > numbersArr[i])
                {
                    minValue = numbersArr[i];
                }
            }
            #endregion


            Console.WriteLine("minimaluria - " + minValue);
            Console.ReadKey();
        }
    }
}
