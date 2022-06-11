using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string> { "str1", "str2", "str3", "str4", "str5" };

            Console.WriteLine($"Pirveli stri: {strList[0]}");
            Console.WriteLine($"List-is zoma: {strList.Count}\nstrebi:\n");
            strList.ForEach(s => Console.WriteLine(s));

            strList.Clear();
            Console.WriteLine($"\nelementebis raodenoba washlis shemdeg: {strList.Count}");
            Console.ReadKey();
        }
    }
}