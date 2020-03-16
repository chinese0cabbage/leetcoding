using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCoding
{
    class Question795
    {
        public static int NumSubarrayBoundedMax(int[] A, int L, int R)
        {
            int total = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int max = A[i], dynamic = i;
                while (dynamic < A.Length)
                {
                    if (A[dynamic] > max)
                    {
                        max = A[dynamic];
                    }
                    if (max > R)
                    {
                        break;
                    }
                    else if (max >= L)
                    {
                        total++;
                    }
                    dynamic++;
                }
            }
            return total;
        }
        public static int AnotherWay(int[] A, int L, int R)
        {
            int total = 0;
            int standardAccount = 0;
            Tuple<int, int> lessCountPosition = null;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= R)
                {
                    standardAccount++;
                    if (A[i] < L)
                    {
                        if (lessCountPosition == null)
                        {
                            lessCountPosition = new Tuple<int, int>(1, i);
                        }
                        else
                        {
                            if (lessCountPosition.Item2 + 1 == i)
                            {
                                lessCountPosition = new Tuple<int, int>(lessCountPosition.Item1 + 1, i);
                            }
                            else
                            {
                                total -= lessCountPosition.Item1 * (lessCountPosition.Item1 + 1) / 2;
                                lessCountPosition = null;
                            }
                        }
                    }
                }
                else
                {
                    if (standardAccount == 0)
                    {
                        continue;
                    }
                    total += standardAccount * (standardAccount + 1) / 2;
                }
            }
            return total;
        }
    }
}
