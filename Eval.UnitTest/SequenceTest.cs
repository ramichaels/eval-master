using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eval.UnitTest
{
    [TestClass]
    public class SequenceTest
    {
        [TestMethod]
        public void CanGetOddNumbers()
        {
            List<int> odds = Sequence
                .GetOddNumbers(new int[] { 1, 2, 3, 6, 7, 9, 12, 16, 17 })
                .ToList();

            Assert.IsTrue(odds.Contains(1));
            Assert.IsTrue(odds.Contains(3));
            Assert.IsTrue(odds.Contains(7));
            Assert.IsTrue(odds.Contains(9));
            Assert.IsTrue(odds.Contains(17));

            Assert.IsFalse(odds.Contains(2));
            Assert.IsFalse(odds.Contains(6));
            Assert.IsFalse(odds.Contains(12));
            Assert.IsFalse(odds.Contains(16));
            
        }

        [TestMethod]
        public void CanExamineInfiniteSet()
        {
            List<int> odds = Sequence
                .GetOddNumbers(Sequence.GetPositiveIntegers())
                .Take(10)
                .ToList();

            Assert.IsTrue(odds.Contains(1));
            Assert.IsTrue(odds.Contains(3));
            Assert.IsTrue(odds.Contains(5));
            Assert.IsTrue(odds.Contains(7));
            Assert.IsTrue(odds.Contains(9));

            Assert.IsFalse(odds.Contains(2));
            Assert.IsFalse(odds.Contains(4));
            Assert.IsFalse(odds.Contains(6));
            Assert.IsFalse(odds.Contains(8));
            Assert.IsFalse(odds.Contains(10));

        }
    }
}
