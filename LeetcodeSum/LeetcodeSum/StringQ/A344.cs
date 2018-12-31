using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSum.StringQ
{
    class A344
    {
        public string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;
            else
            {
                char[] charArrS = s.ToCharArray();
                char temp;
                int left = 0;
                int right = charArrS.Length - 1;
                while(left<right)
                {
                    temp = charArrS[left];
                    charArrS[left] = charArrS[right];
                    charArrS[right] = temp;
                    left++;
                    right--;
                }
                return new string(charArrS);
            }
        }
    }
}
