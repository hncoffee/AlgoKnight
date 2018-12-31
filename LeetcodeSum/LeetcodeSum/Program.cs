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
            //string s = "ljsdfjsdfjlaf";
            //A344 a = new A344();
            int[] i = { 7 };
            A41 a = new A41();
            int t = a.FirstMissingPositive(i);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
