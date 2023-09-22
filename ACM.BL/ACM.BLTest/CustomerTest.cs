using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest

    {
        [TestMethod]
        public void FullNameTestVailid()
        {
            //-- Arrange
            Customer customer = new Customer();
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
