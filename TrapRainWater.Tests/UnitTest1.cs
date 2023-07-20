namespace TrapRainWater.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }
    [TestMethod]
    public void UpAndThenDownSlope()
    {
        int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int result = _test.Trap(height);
        Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void UpDownUpSlope()
    {
        int[] height = { 4, 2, 0, 3, 2, 5 };
        int result = _test.Trap(height);
        Assert.AreEqual(9, result);
    }
    [TestMethod]
    public void DownSlope()
    {
        int[] height = { 4, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int result = _test.Trap(height);
        Assert.AreEqual(14, result);
    }
    [TestMethod]
    public void StraightUpNOTHING()
    {
        int[] height = { };
        int result = _test.Trap(height);
        Assert.AreEqual(0, result);
    }
}