/*
 * метод получает квадратную матрицу целых чисел и определяет,
 * симметрична ли она относительно побочной диагонали
 */

namespace LAB1
{
    [TestClass]
    public class Test1
    {
        static bool Symmetry(int[,] matrix){
            bool symmetry = true;
            if (matrix.GetLength(0) != matrix.GetLength(1)) return false;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1) - i; j++)
                {
                    if ((matrix[i, j] != matrix[matrix.GetLength(0)  -1 - j, matrix.GetLength(1) -1 - i]))
                        symmetry = false; break;
                }
            }
            return symmetry;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[,] arr = { { 1, 2,3 }, { 4,5,2 }, { 6,4,1}};
            Assert.IsTrue(Symmetry(arr));
        }
        [TestMethod]
        public void TestNegativeMethod2()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 2 } };
            Assert.IsFalse(Symmetry(arr));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[,] arr = { { 7, 2, 3 }, { 4, 5, 2 }, { 6, 4, 1 } };
            Assert.IsFalse(Symmetry(arr));
        }
    }
}
