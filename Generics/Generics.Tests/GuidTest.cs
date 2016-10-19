using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Linq;

namespace Generics.Tests
{
    [TestClass]
    public class GuidTest
    {
        [TestInitialize()]
        public void Initialize()
        {
            for (int i = 0; i < 10; i++)
                MyGuid.CreateObjectWithGuid<int>();

            for (int i = 0; i < 5; i++)
                MyGuid.CreateObjectWithGuid<StringBuilder>();
        }

        [TestMethod]
        public void MyGuidCreateCorrectCountOfObjects()
        {
            var countOfInt = MyGuid.GetAllPairsOfType<int>().Count;
            var countOfStringBuilder = MyGuid.GetAllPairsOfType<StringBuilder>().Count;

            Assert.AreEqual(10, countOfInt);
            Assert.AreEqual(5, countOfStringBuilder);
        }

        [TestMethod]
        public void MyGuidDoesNotContainAnyExtraObject()
        {
            var countOfString = MyGuid.GetAllPairsOfType<string>().Count;

            Assert.AreEqual(0, countOfString);
        }

        [TestMethod]
        public void MyGuidReturnCorrectObject()
        {
            var result = MyGuid.GetAllPairsOfType<StringBuilder>().FirstOrDefault().Value;
            
            Assert.IsTrue(result is StringBuilder);
        }

        [TestMethod]
        public void MyGuidReturnCorrectObjectByGuid() 
        {
            var guid = MyGuid.GetAllPairsOfType<int>().FirstOrDefault().Key;
            var result = MyGuid.GetObjectByGuid<int>(guid);

            Assert.AreEqual(typeof(int), result.GetType());
        }

        [TestMethod]
        public void MyGuidReturnNullByNonexistentGuid()
        {
            var guid = Guid.NewGuid();
            var result = MyGuid.GetObjectByGuid<int>(guid);

            Assert.IsNull(result);
        }
    }
}
