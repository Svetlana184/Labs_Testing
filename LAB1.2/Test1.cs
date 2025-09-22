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
            return Math.Round(kv / mas.Length, x);
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
