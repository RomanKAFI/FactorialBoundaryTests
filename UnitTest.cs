using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(1, Factorial(0));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod2() { Factorial(int.MinValue); }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod3() { Factorial(int.MinValue + 1); }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod4() { Factorial(-1); }

    [TestMethod]
    public void TestMethod5() { Assert.AreEqual(1, Factorial(1)); }

    [TestMethod]
    public void TestMethod6() { Assert.AreEqual(39916800, Factorial(11)); }

    [TestMethod]
    public void TestMethod7() { Assert.AreEqual(479001600, Factorial(12)); }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod8() { Factorial(13); }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod9() { Factorial(int.MaxValue - 1); }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod10() { Factorial(int.MaxValue); }

    
    private static int Factorial(int n)
    {
        
        if (n < 0 || n > 12)
            throw new ArgumentOutOfRangeException(nameof(n));

        int result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
}
