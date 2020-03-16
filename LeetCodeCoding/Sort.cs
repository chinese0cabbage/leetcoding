using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCoding
{
    static class Sort
    {
        public static void QuickSort(this int[] nums,int start = 0,int end = 0)
        {
            if (end == 0)
            {
                end = nums.Length - 1;
            }
            int originalStart = start, originalEnd = end;
            if (start < 0 || end > nums.Length - 1 || start > end)
            {
                throw new InvalidOperationException("输入非法");
            }
            switch (end - start)
            {
                case 0:
                    return;
                case 1:
                    {
                        if (nums[start] > nums[end])
                        {
                            var tmp = nums[start];
                            nums[start] = nums[end];
                            nums[end] = tmp;
                        }
                        return;
                    }
                default:
                    break;
            }
            int dividedValue = nums[start];
            while (end > start)
            {
                while (nums[end] >= dividedValue && end > start)
                {
                    end--;
                }
                if (end > start)
                {
                    nums[start] = nums[end];
                }
                else
                {
                    break;
                }
                while (nums[start] <= dividedValue && end > start)
                {
                    start++;
                }
                if (end > start)
                {
                    nums[end] = nums[start];
                }
            }
            if(nums[start] == dividedValue)
            {//当前第一个数已经是最小的数，不能引起end和start的变化
                nums.QuickSort(originalStart + 1, originalEnd);
            }
            else
            {
                nums[start] = dividedValue;
                nums.QuickSort(end, originalEnd);
                nums.QuickSort(originalStart, start);
            }
            
        }

        /// <summary>
        /// 将数组进行切片操作，包括start不包括end，end可为负，最后一个元素表示-1，jump表示每隔多少个元素取一个
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="jump"></param>
        /// <returns></returns>
        public static int[] CutSlice(this int[] nums,int start = 0,int end = 0,int jump = 0)
        {
            if (start < 0 || jump < 0)
            {
                throw new InvalidOperationException("输入非法");
            }
            int[] result = new int[] { };
            if (end == 0)
            {
                if (start == 0 && jump == 0)
                {
                    return nums;
                }
                int count = jump;
                for (int i = start; i < nums.Length; i++)
                {
                    if (count == jump)
                    {
                        result = result.Append(nums[i]).ToArray();
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
                return result;
            }
            else
            {
                if (end < 0)
                {
                    end = nums.Length + end;
                }
                int count = jump;
                for (int i = start; i < end; i++)
                {
                    if (count == jump)
                    {
                        result = result.Append(nums[i]).ToArray();
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
                return result;
            }
        }
    }
}
