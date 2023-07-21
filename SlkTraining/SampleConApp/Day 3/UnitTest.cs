using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleConApp.Day_3;

[TestClass]
public class MyTestClass
{
   [TestMethod]
    public void TestAddMethod()
    {
        double input1 = 123;
        double input2 = 23;
        double expected = 123 + 23;
        double actual = MathClassV3.AddFunction(input1, input2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestSubtractMethod()
    {
        double v1 = 3;
        double v2 = 1;
        double expected = 2;
        double actual = MathClassV3.SubFunction(v1, v2);
        Assert.AreEqual(expected, actual);
    }
}