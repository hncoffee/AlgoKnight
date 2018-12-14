using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSum.ArrayQ
{
    class A80
    {
        public int RemoveDuplicates(int[] nums)
        {
            int p = 0, time = 1;
            if (nums.Length == 0)
                return 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[p] != nums[i])
                {
                    time = 0;
                    nums[++p] = nums[i];
                    time++;
                }
                else
                {
                    time++;
                    if (time <= 2)
                    { nums[++p] = nums[i]; }
                }

            }
            return p + 1;

        }
    }
}
