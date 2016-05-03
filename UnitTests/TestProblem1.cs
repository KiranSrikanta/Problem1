using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestProblem1
    {
        [TestMethod]
        public void P1Test1()
        {
            int[] A = new int[] { 4, 5, 2, 5, 4, 3, 1, 3, 4 };
            int K = 2;
            int[] expResult = new int[] {4, 5, 3};
            int[] result = new Problem1.Problem1().WriteSonutionHere(A, K);

            AssertIfArraysAreEqual(result, expResult);
        }

        private void AssertIfArraysAreEqual(int[] A, int[] B)
        {
            Assert.IsNotNull(A);
            Assert.IsNotNull(B);

            Assert.AreEqual(A.Length, B.Length);

            var aEnum = A.GetEnumerator();
            var bEnum = B.GetEnumerator();

            while (aEnum.MoveNext() && bEnum.MoveNext())
            {
                Assert.AreEqual(aEnum.Current, bEnum.Current);
            }
        }
    }
}
