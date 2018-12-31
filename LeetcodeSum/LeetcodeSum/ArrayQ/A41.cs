using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSum.ArrayQ
{
    class A41
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums.Count() == 0)
                return 0;
            else
            {
                HashSet<int> hs = new HashSet<int>();
                for(int i=0; i<nums.Length;i++)
                {
                    if (nums[i] > 0)
                    {
                        hs.Add(nums[i]);
                    }
                }
                int max = hs.Max();
                int min = hs.Min();
                if (min != 1)
                    return 1;
                else
                {
                    int temp = 1;             
                    while (temp <= max)
                    {
                        if (!hs.Contains(temp))
                        {  
                             return temp;
                        }
                        if (temp == max)
                            return ++temp;
                        temp++;
                        
                    }
                }
                return 0;

            }
        }

    }
}
