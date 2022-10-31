using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;
        // A Test behaves as an ordinary method
        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            yield return null;
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestSQ()
        {
            result = Calculator.CalculatePair(64,0, "√");
            Assert.AreEqual(result, 8);
        }
        [UnityTest]
        public IEnumerator TestUnitySQ()
        {
            yield return null;
            result = Calculator.CalculatePair(64, 0, "√");
            Assert.AreEqual(result, 8);
        }
    }
}
