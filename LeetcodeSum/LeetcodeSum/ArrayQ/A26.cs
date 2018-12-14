using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSum.ArrayQ
{
    class A26
    {
        public int RemoveDuplicates1(int[] nums)
        {
            int p = 0;
            if (nums.Length == 0)
                return 0;
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[p] != nums[i])
                {
                    nums[++p] = nums[i];
                }

            }
            return p + 1;
        }
    }
}
