using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestPass()
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(114147, i, 1, "Error");
        }
        [TestMethod]
        public void TestFailProductType()
        {
            int productType = 5;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailMaterialType()
        {
            int productType = 3;
            int materialType = 4;
            int count = 15;
            float width = 20;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailCount()
        {
            int productType = 1;
            int materialType = 2;
            int count = -11;
            float width = 20;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailWidht()
        {
            int productType = 3;
            int materialType = 4;
            int count = 15;
            float width = -20;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFaillength()
        {
            int productType = 3;
            int materialType = 4;
            int count = 15;
            float width = 20;
            float length = -45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailCountZero()
        {
            int productType = 1;
            int materialType = 2;
            int count = 0;
            float width = 20;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailWidthZero()
        {
            int productType = 1;
            int materialType = 2;
            int count = 15;
            float width = 0;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailLengthZero()
        {
            int productType = 1;
            int materialType = 2;
            int count = 15;
            float width = 11;
            float length = 0;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
        [TestMethod]
        public void TestFailProductAndMaterialType()
        {
            int productType = 6;
            int materialType = 5;
            int count = 15;
            float width = 11;
            float length = 45;

            int i = WSUniversalLib.Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(-1, i, 0, "Error");
        }
    }
}