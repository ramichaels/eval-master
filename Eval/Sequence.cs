﻿using System.Collections.Generic;
using System.Linq;

namespace Eval
{
    public class Sequence
    {
        public static IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            List<int> odds = numbers.Where(n => n % 2 != 0).ToList();
            return odds;
        }

        public static IEnumerable<int> GetPositiveIntegers(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                yield return i;
            }

        }
    }
}
