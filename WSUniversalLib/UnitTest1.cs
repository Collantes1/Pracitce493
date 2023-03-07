using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NormalValueTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 114147;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void materialTypeEqualtoZeroTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 0;
            int count = 15;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void countEqualtoZeroTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 1;
            int count = 0;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void countlassthanzeroTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 1;
            int count = 0;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void EverythingislesstothanzeroTest()
        {
            Calculation Calculator = new Calculation();

            int productType = -1;
            int materialType = -1;
            int count = -1;
            float width = -1;
            float length = -1;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void WidthAndLengthIsLessToThanZeroTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = -5;
            float length = -5;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void WidthEqualToZeroTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 0;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void ProductTypeMoreTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 6;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void MaterialTypeMoreTest()
        {
            Calculation Calculator = new Calculation();

            int productType = 3;
            int materialType = 6;
            int count = 15;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }

        [TestMethod]
        public void ProdyctTypeEqualToZero()
        {
            Calculation Calculator = new Calculation();

            int productType = 0;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int materialCount = Calculator.GetQuantityForProduct(productType, materialType, count, width, length);
            Console.WriteLine(materialCount);

            int actualCount = 0;
            Assert.AreEqual(materialCount, actualCount);
        }
    }
}