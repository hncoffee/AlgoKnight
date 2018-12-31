using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeSum.ArrayQ;
using LeetcodeSum.StringQ;

namespace LeetcodeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ljsdfjsdfjlaf";
            A344 a = new A344();
            string t = a.ReverseString(s);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
