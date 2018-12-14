using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSum.ArrayQ
{
    class A27
    {
        //Method 1, faster than 2.29%
        public int RemoveElementWay1(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            else
            {
                int outputLen = 0;
                foreach (int i in nums)
                {
                    if (i != val)
                    {
                        outputLen++;
                        nums[outputLen - 1] = i;
                    }
                }
                return outputLen;
            }
        }

        //faster than 44.85%
        public int RemoveElementWay2(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            else
            {
                int outputLen = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        outputLen++;
                        nums[outputLen - 1] = nums[i];
                    }
                }
                return outputLen;
            }
        }

        //56.74%
        public int RemoveElementWay3(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            else
            {
                if (!nums.Contains(val))
                    return nums.Length;
                else
                {
                    int outputLen = 0;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] != val)
                        {
                            outputLen++;
                            nums[outputLen - 1] = nums[i];
                        }
                    }
                    return outputLen;
                }
            }
        }


        //30.28%
        public int RemoveElementWay4(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            else
            {
                if (!nums.Contains(val))
                    return nums.Length;
                else
                {
                    Array.Sort(nums);
                    int len = Array.LastIndexOf(nums, val) - Array.IndexOf(nums, val) + 1;
                    int end = Array.LastIndexOf(nums, val);
                    if (end < nums.Length - 1)
                    {
                        for (int i = end + 1; i < nums.Length; i++)
                        {
                            nums[i - len] = nums[i];
                        }
                    }
                    return nums.Length - len;
                }
            }
        }


        //56.74%
        public int removeElementWay5(int[] nums, int val)
        {
            int last = nums.Length - 1;
            int index = 0;
            while (last >= index)
            {
                if (nums[index] == val)
                {
                    int swap = nums[index];
                    nums[index] = nums[last];
                    nums[last] = swap;
                    last--;
                }
                else
                {
                    index++;
                }
            }
            return index;
        }

    }
}
