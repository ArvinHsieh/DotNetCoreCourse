using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLibrary.Test
{
    [TestClass]
    public class MyLibraryTest
    {
        [TestMethod]
        public void TestSum()
        {
            #region Arrange �ƦC
            MyClass fooMyLibrary = new MyClass();

            int expected = 5;
            #endregion

            #region Act �@��
            int actual = fooMyLibrary.Sum(2,3);
            #endregion

            #region Asset �P�_����
            Assert.AreEqual(expected, actual);
            #endregion
        }
    }
}
