using ConsoleApp;

namespace LAB1._3
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            CuteArray cuteArray = new CuteArray(5, array);
            Assert.AreEqual(15, cuteArray.Sum());
        }
        [TestMethod]
        public void TestMethodSumEven()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            CuteArray cuteArray = new CuteArray(5, array);
            Assert.AreEqual(6, cuteArray.SumEven());
        }
        [TestMethod]
        public void TestMethodSumNotEven()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            CuteArray cuteArray = new CuteArray(5, array);
            Assert.AreEqual(9, cuteArray.SumNotEven());
        }
        [TestMethod]
        public void TestMethodNegative()
        {
            int[] array = { 1, 3, 5 };
            CuteArray cuteArray = new CuteArray(5, array);
            Assert.AreEqual(0, cuteArray.SumEven());
        }
    }
}
