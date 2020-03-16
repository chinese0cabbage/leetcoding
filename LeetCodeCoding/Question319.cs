using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCoding
{
    class Question319
    {
        public static int BulbSwitch(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            Dictionary<int, int> numTimesPairs = new Dictionary<int, int>();
            for (int i = 2; i < n+1; i++)
            {//统计每个灯泡的开闭次数，key为灯泡的位置，value为灯泡的开闭次数
                int j = 1;
                while (i * j <= n)
                {
                    if (numTimesPairs.Keys.Contains(i * j))
                    {
                        numTimesPairs[i * j]++;
                    }
                    else
                    {
                        numTimesPairs.Add(i * j, 1);
                    }
                    j++;
                }
            }
            int total = 0;
            for (int i = 1; i < n+1; i++)
            {//根据灯泡的开闭次数判断灯泡的当前状态，为偶数表示打开，为奇数表示关闭，为0表示未循环到，为开启状态
                if (numTimesPairs.ContainsKey(i))
                {
                    if (numTimesPairs[i] % 2 == 0)
                    {
                        total++;
                    }
                }
                else
                {
                    total++;
                }
            }
            return total;
        }
        public static int BulbSwitchByFactor(int n)
        {
            return 0;
        }
        public static int Sqrt(int n)
        {
            int result = n;
            while (result * result > n)
            {
                result /= 2;
                if (result * result == n)
                {
                    return result;
                }
            }
            int start = result, end = 2 * result;
            while (!(result * result < n && (result + 1) * (result + 1) > n))
            {
                int dynamic = (start + end) / 2;
                if (dynamic * dynamic == n)
                {
                    return dynamic;
                }
                else if (dynamic * dynamic > n)
                {
                    end = dynamic;
                }
                else
                {
                    start = dynamic;
                }
                result = dynamic;
            }
            return result;
        }
    }
}
