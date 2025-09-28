/*
 * Опишите класс "одномерный массив строк". Поля класса: число элементов в массиве, сам массив
 * Методы: отсортировать массив в порядке возрастания меодом выбора, 
 * отсортировать массив в порядке возрастания методом быстрой сортировки
 */

using ConsoleApp;
using System.Threading;

namespace LAB1._4
{

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethodChoice()
        {
            CuteArray cute = new([9, 5, 1, 4]);
            cute.SortChoice();
            int[] compareArr = [1, 4, 5, 9];
            CollectionAssert.AreEqual(compareArr, cute.cuteArray);
        }
        [TestMethod]
        public void TestMethodQuick()
        {
            CuteArray cute = new([9, 5, 1, 4]);
            cute.SortQuick();
            int[] compareArr = [1, 4, 5, 9];
            CollectionAssert.AreEqual(compareArr, cute.cuteArray);
        }
        [TestMethod]
        public void TestMethodNegativeChoice()
        {
            CuteArray cute = new([1,1,1]);
            cute.SortChoice();
            int[] compareArr = [1, 1, 1];
            CollectionAssert.AreEqual(compareArr, cute.cuteArray);
        }
        [TestMethod]
        public void TestMethodNegativeQuick()
        {
            CuteArray cute = new([1, 1, 1]);
            cute.SortQuick();
            int[] compareArr = [1, 1, 1];
            CollectionAssert.AreEqual(compareArr, cute.cuteArray);
        }
    }
}
