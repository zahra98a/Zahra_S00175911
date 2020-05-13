using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zahra_S00175911;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            //Arrange
            Phone p1 = new Phone();
            decimal expectedPrice = 0m;
            //Act         
            p1.IncreasePrice(0.5m);        
            //Assert
            Assert.AreEqual(expectedPrice, p1.Price);
            
        }
        [TestMethod]
        public void TestMethod2()
        {

            //Arrange
            Phone p1 = new Phone();
            decimal expectedPrice = 550m;
            //Act         
            p1.IncreasePrice(0.1m);
            //Assert
            Assert.AreEqual(expectedPrice, p1.Price);

        }
    }
}
