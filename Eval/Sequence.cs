using System.Collections.Generic;
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

        public static IEnumerable<int> GetPositiveIntegers()
        {
            List<int> positiveIntegers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                positiveIntegers.Add(i);
            }
            return positiveIntegers;
        }
    }
}
