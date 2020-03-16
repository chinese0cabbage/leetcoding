using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCoding
{
    class Question765
    {
        public static int MinSwapsCouples(int[] row)
        {
            var cuple = row.Select(x => x % 2 == 0 ? x : x - 1).ToList();
            return 0;
        }
    }
}
