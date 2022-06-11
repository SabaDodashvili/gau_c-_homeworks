using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12._3._50
{
    internal class Program
    {
        static string FindLongerWord(string wordOne, string wordTwo)
        {
            if (wordOne.Length > wordTwo.Length)
            {
                return wordTwo + wordOne;
            }
            else
            {
                return wordOne + wordTwo;
            }
        }

        static void Main(string[] args)
        {

            Console.Write("sheiyvanet sityva 1: ");
            string wordOne = Console.ReadLine();
            Console.Write("sheiyvanet sityva 2: ");
            string wordTwo = Console.ReadLine();

            Console.WriteLine("shedegi - " + FindLongerWord(wordOne, wordTwo));
        }
    }
}
