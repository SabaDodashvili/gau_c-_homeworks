using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace taks_12._3._52
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("sheiyvanet winadadeba: ");
            string str = Console.ReadLine();

            List<string> palindroms = str.Split().Where(x => x.SequenceEqual(x.Reverse())).ToList();
            Console.WriteLine("polindromebis raodenoba = " + palindroms.Count);
            Console.WriteLine("polindromebi striqonshi: " + String.Join(", ", palindroms));
        }


    }
}
