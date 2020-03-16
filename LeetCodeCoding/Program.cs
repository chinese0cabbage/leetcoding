using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 73, 55, 36, 5, 55, 14, 9, 7, 72, 52 };
            //arr.QuickSort();
            //var nums = arr;
            //Console.WriteLine(nums.Length);
            PlayMahjong playMahjong = new PlayMahjong();
            Console.WriteLine("请输入0：结束，1：开始");
            int tag = Convert.ToInt32(int.Parse(Console.ReadLine()));
            while (tag != 0)
            {
                playMahjong.Play();
                Console.WriteLine("本轮结束，请输入0：结束，1：开始，2：结算");
                tag = Convert.ToInt32(int.Parse(Console.ReadLine()));
                if (tag == 2)
                {
                    playMahjong.Settlement();
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
