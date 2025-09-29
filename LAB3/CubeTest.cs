namespace LAB3
{
    [TestClass]
    public class CubeTest
    {
        /// <summary>
        /// позитивный тест
        /// вычисление объема
        /// </summary>
        [TestMethod]
        public void TestPositiveVolume()
        {
            Cube cube = new Cube(4);
            Assert.AreEqual(64, cube.Volume());
        }
        /// <summary>
        /// негативный тест
        /// неправильное значение длины ребра
        /// вычисление объема
        /// </summary>
        [TestMethod]
        public void TestNegativeVolume()
        {
            Cube cube = new Cube(-4);
            Assert.AreEqual(0, cube.Volume());
        }
        /// <summary>
        /// позитивный тест
        /// вычисление площади поверхности
        /// </summary>
        [TestMethod]
        public void TestPositiveSurfaceArea()
        {
            Cube cube = new Cube(4);
            Assert.AreEqual(96, cube.SurfaceArea());
        }
        /// <summary>
        /// негативный тест
        /// неправильное значение длины ребра
        /// вычисление площади поверхности
        /// </summary>
        [TestMethod]
        public void TestNegativeSurfaceArea()
        {
            Cube cube = new Cube(-4);
            Assert.AreEqual(0, cube.SurfaceArea());
        }
        /// <summary>
        /// позитивный тест
        /// изменение объема
        /// </summary>
        [TestMethod]
        public void TestPositiveChangeVolume()
        {
            Cube cube = new Cube(4);
            cube.ChangeVolume(4);
            Assert.AreEqual(6.35, cube.Edge);
        }
        /// <summary>
        /// негативный тест
        /// неправильное значение длины ребра
        /// изменение объема
        /// </summary>
        [TestMethod]
        public void TestNegativeChangeVolume1()
        {
            Cube cube = new Cube(-4);
            cube.ChangeVolume(4);
            Assert.AreEqual(0, cube.Edge);
        }
        /// <summary>
        /// негативный тест
        /// изменение объема
        /// неправильное значение для изменения объема
        /// </summary>
        [TestMethod]
        public void TestNegativeChangeVolume2()
        {
            Cube cube = new Cube(4);
            cube.ChangeVolume(-4);
            Assert.AreEqual(4, cube.Edge);
        }
    }
}
