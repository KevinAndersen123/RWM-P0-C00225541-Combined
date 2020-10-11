using NUnit.Framework;
using UnityEngine;
//@author Kevin Andersen

namespace Tests
{
    public class Modulo3FilterTest
    {
        [Test]
        public void Modulo3FilterSimple()
        {
            int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = Modulo3Filter.moduloInput(input);
            int[] expected = { 1, 2, 2, 0, 0, 1, 1, 2, 2, 0 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Modulo3FilterNegVal()
        {
            int[] input = {0, -7, -9999999, -1234567};
            int[] output = Modulo3Filter.moduloInput(input);
            int[] expected = {0, 2, 0, 2};

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }


}
