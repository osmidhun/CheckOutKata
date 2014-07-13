using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace CheckOutProcessorTest
{
    [TestFixture]
    public class TestCheckOutProcessor
    {
  

        [Test]
        public void Test_CheckOut_Method_Returns_Total_Of_SKU()
        {
            var classUnderTest = new CheckOutProcessor.CheckOutProcessor();
            var total = classUnderTest.CheckOut("A", 50);
            Assert.AreEqual(50, total);
          total = classUnderTest.CheckOut("B", 60);
          Assert.AreEqual(110, total);
        }
    }
}

