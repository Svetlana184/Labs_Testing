/*
 * метод получает одномерный массив вещ. чисел и заданную точность.
 * Метод должен вычислить среднеквадратичное отклонение элементов массива с заданной точностью
 */
namespace LAB1._2
{
    [TestClass]
    public class Test1
    {
        static double Deviation(double[] mas, int x)
        {
            double average = mas.Average();
            double kv = 0;
            foreach (double v in mas)
            {
                kv += (v - average) * (v - average);
            }
            return Math.Round(Math.Sqrt(kv / mas.Length), x);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0.82, Deviation([1, 2, 3], 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, Deviation([0,0,0], 2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4.92, Deviation([-5, 2, -10], 2));
        }
    }
}
