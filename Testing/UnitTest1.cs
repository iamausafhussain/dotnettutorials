namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sumResult = new TestPro.Program();

            double sum = sumResult.Sum(10, 20);

            Assert.AreEqual(30, sum);
        }

        [TestMethod]
        public void Calculator_Subtract_Difference()
        {
            var subResult = new TestPro.Calculator();

            double sub = subResult.Sub(20, 10);
            double sum = subResult.Sum(10, 20);

            Assert.AreEqual(10, sub);
            Assert.AreEqual(30, sum);
        }
    }
}