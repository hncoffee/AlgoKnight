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
                Dictionary<int, char> dtGuess = new Dictionary<int, char>();
                for (int i = 0; i < guess.Length; i++)
                {
                    dtGuess.Add(i, guess[i]);
                }

                Dictionary<int, char> dtSecret = new Dictionary<int, char>();
                for (int j = 0; j < secret.Length; j++)
                {
                    dtSecret.Add(j, secret[j]);
                }
                              

                int bull = 0;
                int cow = 0;
                for(int a=0; a<guess.Length; a++)
                {
                    if(dtSecret[a]==guess[a])
                    {
                        bull++;                       
                        dtSecret.Remove(a);
                        dtGuess.Remove(a);
                    }
                }

               for(int t=0; t<guess.Length; t++)
                {
                    if(dtSecret.ContainsValue(guess[t]) && dtGuess.ContainsValue(guess[t]))
                    {                        
                        cow++;
                        dtSecret.Remove(dtSecret.FirstOrDefault(x => x.Value == guess[t]).Key);
                        dtGuess.Remove(dtGuess.FirstOrDefault(x => x.Value == guess[t]).Key);
                    }
                }
                return bull + "A" + cow + "B";

            }
        }
    }
}
