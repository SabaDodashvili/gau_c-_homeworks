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
            Console.Write("shemoitane ricxvi 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("shemoitane ricxvi 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("shemoitane ricxvi 3:");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("shemoitane ricxvi 4:");
            double number4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("shemoitane ricxvi 5:");
            double number5 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2 + number3 + number4 + number5;
            double avg = sum / 5;

            Console.WriteLine("sashvalo aritmetikuli aris: " + avg);
        }
    }
}
