using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSum.ArrayQ
{
    class A189
    {
        public void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            int[] newarr = new int[len];
            if (len >= k)
            {
                int start = len - k;

                int newstart = 0;
                for (int i = start; i < len; i++)
                {
                    newarr[newstart] = nums[i];
                    newstart++;
                }
                for (int j = 0; j < start; j++)
                {
                    newarr[newstart] = nums[j];
                    newstart++;
                }
            }
            nums = newarr;
        }


        public void Rotate2(int[] nums, int k)
        {
            int len = nums.Length;
            if (len == 1) return;
            if (len < k)
            {
                k = k % len;
            }
            int[] newnums = new int[len];
            Array.Copy(nums, len - k, newnums, 0, k);
            Array.Copy(nums, 0, newnums, k, len - k);
            Array.Copy(newnums, nums, len);


        }
    }
}
