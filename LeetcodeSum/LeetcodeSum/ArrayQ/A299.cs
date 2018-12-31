using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetcodeSum.ArrayQ
{
    class A299
    {
        public string GetHint(string secret, string guess)
        {
            if ((string.IsNullOrEmpty(secret))||string.IsNullOrEmpty(guess))
                return null;
            else
            {
                Dictionary<char, int> dtGuess = new Dictionary<char, int>();
                for (int i = 0; i < guess.Length; i++)
                {
                    dtGuess.Add(guess[i], i);
                }

                return "hello";

            }
        }
    }
}
