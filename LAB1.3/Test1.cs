using ConsoleApp;
/*
 * Опишите класс "одномерный массив строк". Поля класса: число элементов в массиве, сам массив
 * Методы: подсчитать сумму элементов массива, число чётных элементов, число нечётных элементов
 */
namespace LAB1._3
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            int[] array = [1, 2, 3, 4, 5];
            CuteArray cuteArray = new(5, array);
            Assert.AreEqual(15, cuteArray.Sum());
        }
        [TestMethod]
        public void TestMethodSumEven()
        {
            int[] array = [1, 2, 3, 4, 5];
            CuteArray cuteArray = new(5, array);
            Assert.AreEqual(2, cuteArray.Even());
        }
        [TestMethod]
        public void TestMethodSumNotEven()
        {
            int[] array = [1, 2, 3, 4, 5];
            CuteArray cuteArray = new(5, array);
            Assert.AreEqual(3, cuteArray.NotEven());
        }
        [TestMethod]
        public void TestMethodNegative()
        {
            int[] array = [1, 3, 5];
            CuteArray cuteArray = new(5, array);
            Assert.AreEqual(0, cuteArray.Even());
        }
    }
}
