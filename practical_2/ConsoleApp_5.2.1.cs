using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_5._2._1
{
    public class StudentClass
    {
        public double GetGradesAverage(double[] gradesArr)
        {
            double sum = 0;

            for (int i = 0; i < gradesArr.Length; i++)
            {
                sum += gradesArr[i];
            }

            return sum / gradesArr.Length;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] gradesArr = new double[10];

            for (int i = 0; i < gradesArr.Length; i++)
            {
                Console.Write($"anter your {i + 1} grade: ");
                gradesArr[i] = Convert.ToDouble(Console.ReadLine());
            }

            StudentClass studentClass_01 = new StudentClass();
            double gradesAvarage = studentClass_01.GetGradesAverage(gradesArr);
            Console.WriteLine($"your average score is {gradesAvarage} ");

        }
    }
}
