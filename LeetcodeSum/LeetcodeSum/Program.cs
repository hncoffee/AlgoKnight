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
            string secret = "11";
            string guess = "10";

            
            A299 a = new A299();
            string t = a.GetHint(secret, guess);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
