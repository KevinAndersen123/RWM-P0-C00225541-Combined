
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 2, 3, 5, 7, 9, 8 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 0, 1, 1, 1, 1, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

