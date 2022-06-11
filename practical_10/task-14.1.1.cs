using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListStr = new List<string> { "str1", "str2", "str3", "str4", "str3", "str4", "str5", "str6", "str7", "str8" };
            ListStr.Add("add_1");
            ListStr.Add("add_2");

            Console.WriteLine($"masivis sigrdzea: {ListStr.Count}\n");
            Console.WriteLine($"masivis elementebi: \n");
            ListStr.ForEach(a => Console.WriteLine(a));
            Console.ReadKey();
        }
    }
}
